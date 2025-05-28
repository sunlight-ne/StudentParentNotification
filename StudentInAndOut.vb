Imports System.Configuration
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.IO.Ports
Imports System.Text
Imports System.Management
Imports System.Security.Cryptography

Public Class StudentInAndOut
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyDatabaseConnectionString").ConnectionString
    Private studentID As Integer = 0
    Private adminID As Integer = 0
    Private email As String = ""
    Private ParentNumber As String = ""
    Private WithEvents SerialPort1 As New SerialPort()
    Private com As String = ""
    ' Vendor ID and Product ID of the GSM device
    Private Const VID As String = "1A86" ' Vendor ID for GSM device
    Private Const PID As String = "7523" ' Product ID for GSM device
    Private found As Boolean = False
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim form As New verificationPassword
        form.ShowDialog()
        Me.Close()



    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Close()
    End Sub
    Private Sub GetCom()



        ' Use ManagementObjectSearcher to query USB devices
        Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity")
            For Each queryObj As ManagementObject In searcher.Get()
                Dim deviceID As String = queryObj("PNPDeviceID")?.ToString()
                Dim name As String = queryObj("Name")?.ToString()

                ' Check if the device matches our VID and PID
                If Not String.IsNullOrEmpty(deviceID) AndAlso deviceID.Contains("VID_" & VID) AndAlso deviceID.Contains("PID_" & PID) Then
                    ' Extract COM port from the name (e.g., "USB-SERIAL CH340 (COM3)")
                    If name.Contains("COM") Then
                        Dim startIndex As Integer = name.LastIndexOf("(") + 1
                        Dim endIndex As Integer = name.LastIndexOf(")")
                        com = name.Substring(startIndex, endIndex - startIndex)
                        found = True
                        Exit For ' Stop once the matching device is found
                    End If
                End If
            Next




    End Sub
    Private Async Sub smsconnection()
        ' Ensure the serial port is closed before re-opening
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If

        Try
            With SerialPort1
                .PortName = com ' Update as necessary
                .BaudRate = 9600
                .Parity = Parity.None
                .DataBits = 8
                .StopBits = StopBits.One
                .Handshake = Handshake.None
                .RtsEnable = True
                .DtrEnable = True
                .Open()

                ' Send the command to start receiving messages
                Await Task.Delay(1000) ' Async delay to allow the port to settle
                .WriteLine("AT+CNMI=1,2,0,0,0" & vbCr) ' Enable notifications for new messages
            End With

            Log("Serial port connected and SMS notifications enabled.")
        Catch ex As Exception
            ' MsgBox("Error opening serial port: " & ex.Message, MsgBoxStyle.Critical, "Connection Error")
            Log("Error opening serial port: " & ex.Message)
        End Try
    End Sub


    Private Sub SendSMSNotification(ByVal message As String)


        Dim phoneNumber As String = ParentNumber.Trim()

        ' Validate inputs


        ' Run the SMS sending in a background task
        Task.Run(Async Function()
                     Try
                         With SerialPort1
                             ' Initialize the GSM modem
                             Log("Sending AT command to initialize.")
                             .WriteLine("AT" & vbCr) ' Test command
                             Await Task.Delay(1000)

                             ' Set text mode for SMS
                             Log("Setting text mode.")
                             .WriteLine("AT+CMGF=1" & vbCr) ' Set text mode (GSM)
                             Await Task.Delay(1000)

                             ' Set the recipient number
                             Log($"Setting recipient number: {phoneNumber}.")
                             .WriteLine($"AT+CMGS=""{phoneNumber}""" & vbCr) ' Set recipient number
                             Await Task.Delay(1000)

                             ' Send the message
                             Log($"Sending GSM message: {message}.")
                             .Write(message & Chr(26)) ' Send the message with Ctrl+Z (26 in ASCII)
                             Await Task.Delay(3000)
                         End With

                         Log("SMS sent successfully.")
                     Catch ex As Exception
                         '  MsgBox("An error occurred while sending the SMS: " & ex.Message, MsgBoxStyle.Critical, "SMS Error")
                         Log("Error sending SMS: " & ex.Message)
                     End Try
                 End Function)
    End Sub
    Private Sub Log(message As String)
        Debug.WriteLine(message)
    End Sub
    Private Sub StudentInAndOut_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
            Log("Serial port closed.")
        End If
    End Sub
    Private Sub StudentInAndOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtrfid.Focus()
        listRecord()
        timer.Interval = 3000 ' 5 seconds
        timer.Enabled = False ' Initially disabled
        GetCom()
        smsconnection()

    End Sub
    Public Sub listRecord()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to retrieve users based on the adminID and role
                Dim query As String = "SELECT CONCAT(u.firstName, ' ', u.middleName, ' ', u.lastName) AS StudentName, r.dateIn AS 'Time In', r.dateOut AS 'Time Out', r.date AS 'Date' " &
                     "FROM records r " &
                     "LEFT JOIN user u ON u.userID = r.userID " &
                     "WHERE r.adminID = @adminID  AND date = @date"

                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters for adminID and role
                    cmd.Parameters.AddWithValue("@adminID", Login.adminID)
                    cmd.Parameters.AddWithValue("@date", Date.Today)

                    ' Create a DataTable to hold the query results
                    Dim dt As New DataTable()

                    ' Fill the DataTable with data from the MySQL query
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)

                    End Using

                    ' Check if the DataTable has rows (users)
                    If dt.Rows.Count > 0 Then
                        ' Clear any existing data
                        dtgListRecord.DataSource = Nothing

                        ' Bind the DataTable to the DataGridView
                        dtgListRecord.DataSource = dt
                        dtgListRecord.Refresh()



                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function ValidateEntries() As Boolean
        If String.IsNullOrWhiteSpace(txtrfid.Text) Then
            MessageBox.Show("Scan The Card", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtrfid.Focus()
            Return False
        End If



        Return True
    End Function

    Private Sub emailNotif(ByVal time As Date, ByVal inorout As String)
        ' Check if the email is not empty
        If Not String.IsNullOrEmpty(email) Then
            ' Compose the email message00000000000000000000000000000000
            Dim subject As String = "Student Notification"
            Dim message As String = $"Dear Parent/Guardian," & vbCrLf & vbCrLf &
                        $"We would like to inform you that your child is currently marked as '{inorout}'." & vbCrLf & vbCrLf &
                        $"Actual Time: {time}" & vbCrLf & vbCrLf &
                        "If you have any questions or need assistance, please do not hesitate to contact us." & vbCrLf & vbCrLf &
                        "Best regards," & vbCrLf &
                        "The Student Notification System Team"


            ' Set the URL of the API endpoint
            Dim url As String = "https://script.google.com/macros/s/AKfycbzq3WVc1oWwztigAwKz14-x8T10Fb6dOHrG_yTIuALSMi7HMIInHsww_zfrmK5H35HyNQ/exec"

            ' Initialize WebClient for sending the POST request
            Using client As New Net.WebClient()
                ' Set up the POST data
                Dim postData As New Specialized.NameValueCollection() From {
                {"recipient", email},
                {"subject", subject},
                {"body", message}
            }
                ' Send the POST request
                Dim responseBytes As Byte() = client.UploadValues(url, "POST", postData)
                Dim response As String = System.Text.Encoding.UTF8.GetString(responseBytes)
                'Try
                '    ' Send the POST request
                '    Dim responseBytes As Byte() = client.UploadValues(url, "POST", postData)
                '    Dim response As String = System.Text.Encoding.UTF8.GetString(responseBytes)



                'Catch ex As Exception
                '    ' Handle errors
                '    MessageBox.Show("Error sending email: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End Try
            End Using
            'Else
            '    ' Handle case where email is empty
            '    MessageBox.Show("Error: Email address is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnrfid_Click(sender As Object, e As EventArgs) Handles btnrfid.Click
        If ValidateEntries() = True Then

            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' Step 1: Verify user by RFID
                    Dim userQuery As String = "SELECT u.userID,u.profile, CONCAT(u.firstName, ' ', u.middleName, ' ', u.lastName) AS StudentName, p.email, p.phoneNumber 
                    FROM user u 
                    INNER JOIN parent p ON p.userID = u.userID
                    WHERE rfid = @rfid AND adminID = @adminID"
                    Using userCmd As New MySqlCommand(userQuery, connection)
                        userCmd.Parameters.AddWithValue("@rfid", txtrfid.Text)
                        userCmd.Parameters.AddWithValue("@adminID", Login.adminID)

                        Using reader As MySqlDataReader = userCmd.ExecuteReader()
                            If reader.HasRows Then
                                reader.Read()
                                studentID = Convert.ToInt32(reader("userID"))
                                email = Convert.ToString(reader("email"))
                                ParentNumber = Convert.ToString(reader("phoneNumber"))
                                lblstudentname.Text = Convert.ToString(reader("StudentName"))
                                lblstudentname.Visible = True

                                If reader("profile") IsNot DBNull.Value Then
                                    Dim profileData As Byte() = CType(reader("profile"), Byte())
                                    Using ms As New MemoryStream(profileData)
                                        ptbProfile.Image = Image.FromStream(ms)
                                    End Using
                                    timer.Start()
                                Else
                                    ' Handle case where profile image is null
                                    ptbProfile.Image = Nothing
                                End If
                            Else
                                MsgBox("Not Registered")
                                txtrfid.Clear()
                                txtrfid.Focus()
                                Return
                            End If
                        End Using
                    End Using

                    ' Step 2: Check if a record for today already exists with dateIn but no dateOut
                    Dim recordQuery As String = "SELECT recordID FROM records WHERE userID = @userID AND date = @date AND adminID = @adminID AND dateOut IS NULL ORDER BY recordID DESC LIMIT 1"
                    Dim recordID As Object
                    Using recordCmd As New MySqlCommand(recordQuery, connection)
                        recordCmd.Parameters.AddWithValue("@userID", studentID)
                        recordCmd.Parameters.AddWithValue("@date", Date.Today)
                        recordCmd.Parameters.AddWithValue("@adminID", Login.adminID)

                        recordID = recordCmd.ExecuteScalar()
                    End Using

                    If recordID IsNot Nothing AndAlso Not IsDBNull(recordID) Then
                        ' Step 3: If an open record exists, update it with dateOut
                        Dim updateQuery As String = "UPDATE records SET dateOut = @dateOut WHERE recordID = @recordID"
                        Using updateCmd As New MySqlCommand(updateQuery, connection)
                            updateCmd.Parameters.AddWithValue("@dateOut", DateTime.Now)
                            updateCmd.Parameters.AddWithValue("@recordID", recordID)
                            updateCmd.ExecuteNonQuery()
                        End Using
                        emailNotif(DateTime.Now, "Time OUT")
                        If found Then
                            SendSMSNotification($"Student Out{Environment.NewLine}{DateTime.Now:yyyy-MM-dd HH:mm:ss}{Environment.NewLine}This message is to notify that your child is out of the school.")
                        End If


                        'MessageBox.Show("Time out recorded successfully.")
                    Else
                        ' Step 4: No open record found, so insert a new record with dateIn
                        Dim insertQuery As String = "INSERT INTO records (dateIn, userID, adminID, date) VALUES (@dateIn, @userID, @adminID, @date)"
                        Using insertCmd As New MySqlCommand(insertQuery, connection)
                            insertCmd.Parameters.AddWithValue("@dateIn", DateTime.Now)
                            insertCmd.Parameters.AddWithValue("@userID", studentID)
                            insertCmd.Parameters.AddWithValue("@adminID", Login.adminID)
                            insertCmd.Parameters.AddWithValue("@date", Date.Today)
                            insertCmd.ExecuteNonQuery()
                        End Using
                        emailNotif(DateTime.Now, "Time In")
                        If found Then
                            SendSMSNotification($"Student In{Environment.NewLine}{DateTime.Now:yyyy-MM-dd HH:mm:ss}{Environment.NewLine}This message is to notify that your child is In on the school.")
                        End If


                        '  MessageBox.Show("Time in recorded successfully.")
                    End If

                    ' Clear RFID text and refresh list
                    txtrfid.Clear()
                    txtrfid.Focus()
                    Call listRecord()
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub

    ' Method to add parameters for either IN or OUT
    Private Sub AddUserParameters(cmd As MySqlCommand)
        cmd.Parameters.AddWithValue("@userID", studentID)
        cmd.Parameters.AddWithValue("@adminID", Login.adminID)
        cmd.Parameters.AddWithValue("@date", Date.Today)
        cmd.Parameters.AddWithValue("@dateIN", DateTime.Now)
        cmd.Parameters.AddWithValue("@dateOut", DateTime.Now)

    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        ptbProfile.Image = Nothing
        lblstudentname.Visible = False
        timer.Stop()
    End Sub
End Class
