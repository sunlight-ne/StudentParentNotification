Imports System.Configuration
Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports Org.BouncyCastle.Crypto.Generators
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Windows.Forms.DataVisualization.Charting
Public Class DashBoardAdmin
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyDatabaseConnectionString").ConnectionString


    Private isExistingUser As Boolean
    Private visibilityState As Integer = 0
    Private Student As String = "Student"
    Private Subadmin As String = "Subadmin"
    Private role As String = Login.role
    Private january As Integer = 0
    Private february As Integer = 0
    Private march As Integer = 0
    Private april As Integer = 0
    Private may As Integer = 0
    Private june As Integer = 0
    Private july As Integer = 0
    Private august As Integer = 0
    Private september As Integer = 0
    Private october As Integer = 0
    Private november As Integer = 0
    Private december As Integer = 0


    Private Sub viewsubadminenable()
        If role = "Admin" Then
            btnViewSubAdmin2.Visible = True
            gpbGeneratecode.Visible = True
            btnSubadminCount.Visible = True
            ptbimageprofilesubadmin.Visible = True


        Else
            btnViewSubAdmin2.Visible = False
            gpbGeneratecode.Visible = False
            btnSubadminCount.Visible = False
            ptbimageprofilesubadmin.Visible = False

        End If
    End Sub

    Private Sub data()
        txtUsername.Text = Login.username
        txtOldPassword.Text = Login.password
        txtCode.Text = Login.code
        txtFirstNameProfile.Text = Login.firstname
        txtMiddleNameProfile.Text = Login.middlename
        txtLastNameProfile.Text = Login.lastname
        txtEmailProfile.Text = Login.email
        txtNumberProfile.Text = Login.number
        cboGenderProfile.Text = Login.gender

    End Sub
    Private Sub DashBoardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAddStudent.Visible = False
        viewsubadminenable()
        data()
        visiblepanel()
        liststudent()
        listSubadmin()
        listRecord()
        liststudentpending()
        GetStudentCount()
        GetSUbadminCount()
        GetRecordCount()
        Chart()
    End Sub

    Private Sub Chart()
        ' Clear any existing series
        GetAttendanceByMonths()

        Chart1.Series.Clear()

        ' Create a new series for the Pie Chart
        Dim salesSeries As New Series("Sales")
        salesSeries.ChartType = SeriesChartType.Pie ' Set chart type to Pie

        ' Add data manually
        salesSeries.Points.AddXY("January", january)
        salesSeries.Points.AddXY("February", february)
        salesSeries.Points.AddXY("March", march)
        salesSeries.Points.AddXY("April", april)
        salesSeries.Points.AddXY("May", may)
        salesSeries.Points.AddXY("June", june)
        salesSeries.Points.AddXY("July", july)
        salesSeries.Points.AddXY("August", august)
        salesSeries.Points.AddXY("September", september)
        salesSeries.Points.AddXY("October", october)
        salesSeries.Points.AddXY("November", november)
        salesSeries.Points.AddXY("December", december)

        ' Add the series to the chart
        Chart1.Series.Add(salesSeries)

        ' Add a title to the chart
        Chart1.Titles.Clear()
        Chart1.Titles.Add("Monthly Attendance")

        ' Add a legend for the pie chart
        Chart1.Legends.Clear()
        Dim legend = Chart1.Legends.Add("Legend1")
        legend.Title = "Months"
        legend.Docking = Docking.Right

        ' Optional: Customize slice labels to show percentages only
        salesSeries.Label = "#PERCENT{P1}" ' Show only percentage inside the pie slices
        salesSeries.LegendText = "#VALX" ' Display category names in the legend

    End Sub

    Private Sub GetAttendanceByMonths()


        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' SQL query to get the count for each month
            Dim query As String = "
            SELECT MONTH(date) AS month, COUNT(*) AS attendanceCount
            FROM records
            WHERE adminID = @adminID
            GROUP BY MONTH(date)
            ORDER BY MONTH(date);"

            Using cmd As New MySqlCommand(query, connection)
                ' Use parameterized query to prevent SQL injection
                cmd.Parameters.AddWithValue("@adminID", Login.adminID)

                ' Execute the command and use a reader to get the result
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim month As Integer = Convert.ToInt32(reader("month"))
                        Dim attendanceCount As Integer = Convert.ToInt32(reader("attendanceCount"))

                        ' Store the count in corresponding month variable
                        Select Case month
                            Case 1
                                january = attendanceCount
                            Case 2
                                february = attendanceCount
                            Case 3
                                march = attendanceCount
                            Case 4
                                april = attendanceCount
                            Case 5
                                may = attendanceCount
                            Case 6
                                june = attendanceCount
                            Case 7
                                july = attendanceCount
                            Case 8
                                august = attendanceCount
                            Case 9
                                september = attendanceCount
                            Case 10
                                october = attendanceCount
                            Case 11
                                november = attendanceCount
                            Case 12
                                december = attendanceCount
                        End Select
                    End While
                End Using
            End Using
        End Using


    End Sub

    Private Sub GetStudentCount()

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Prepare SQL query with parameterized inputs
            Dim query As String = "SELECT count(*) as totalStudent FROM user WHERE adminID = @adminID AND role = @role and rfid is not null"
            Using cmd As New MySqlCommand(query, connection)
                ' Use parameterized query to prevent SQL injection
                cmd.Parameters.AddWithValue("@adminID", Login.adminID)
                cmd.Parameters.AddWithValue("@role", Student)

                ' Execute the command and use a reader to get the result
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Retrieve the user ID from the row without Convert.ToInt32
                        btnStudentCount.Text = "Student(" & reader("totalStudent").ToString() & ")"



                    End If
                End Using
            End Using
        End Using



    End Sub

    Private Sub GetSUbadminCount()

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Prepare SQL query with parameterized inputs
            Dim query As String = "SELECT count(*) as totalSubadmin FROM user WHERE adminID = @adminID AND role = @role "
            Using cmd As New MySqlCommand(query, connection)
                ' Use parameterized query to prevent SQL injection
                cmd.Parameters.AddWithValue("@adminID", Login.adminID)
                cmd.Parameters.AddWithValue("@role", Subadmin)

                ' Execute the command and use a reader to get the result
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Retrieve the user ID from the row without Convert.ToInt32
                        btnSubadminCount.Text = "Subadmin(" & reader("totalSubadmin").ToString() & ")"
                    End If
                End Using
            End Using
        End Using

    End Sub
    Private Sub GetRecordCount()

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Prepare SQL query with parameterized inputs
            Dim query As String = "SELECT count(*) as totalRecord FROM records WHERE adminID = @adminID  "
            Using cmd As New MySqlCommand(query, connection)
                ' Use parameterized query to prevent SQL injection
                cmd.Parameters.AddWithValue("@adminID", Login.adminID)

                ' Execute the command and use a reader to get the result
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Retrieve the user ID from the row without Convert.ToInt32
                        btnRecordCount.Text = "Record(" & reader("totalRecord").ToString() & ")"



                    End If
                End Using
            End Using
        End Using

    End Sub
    Public Sub liststudentpending()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to retrieve users based on the adminID and role
                Dim query As String = "SELECT u.firstName as FirstName, u.middleName as MiddleName, u.lastName as LastName, u.studentNumber AS 'StudentNumber', u.email AS 'Email', u.phoneNumber AS 'MobileNumber', 
                                   u.gender AS 'Gender', u.year AS 'Year', u.course AS 'Course', u.rfid as RFID, p.firstName as ParentFirstName, p.middleName as ParentMiddleName, 
                                   p.lastName as ParentLastName, p.phoneNumber as ParentMobile, p.email as ParentEmail, p.gender as ParentGender , u.studentStat as Status , u.profile as Profile
                                   FROM user u 
                                   INNER JOIN parent p ON p.userID = u.userID
                                   WHERE adminID = @adminID AND role = @role and u.rfid IS NULL"

                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters for adminID and role
                    cmd.Parameters.AddWithValue("@adminID", Login.adminID)
                    cmd.Parameters.AddWithValue("@role", Student)

                    ' Create a DataTable to hold the query results
                    Dim dt As New DataTable()

                    ' Fill the DataTable with data from the MySQL query
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using

                    ' Check if the DataTable has rows (users)
                    If dt.Rows.Count > 0 Then
                        ' Clear any existing data
                        dtgStudentPending.DataSource = Nothing

                        ' Bind the DataTable to the DataGridView
                        dtgStudentPending.DataSource = dt
                        dtgStudentPending.Refresh()

                        ' Set column styles
                        dtgStudentPending.Columns("LastName").DefaultCellStyle.ForeColor = Color.Blue
                        dtgStudentPending.Columns("LastName").DefaultCellStyle.Font = New Font(dtgStudentPending.Font, FontStyle.Underline)

                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub liststudent()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to retrieve users based on the adminID and role
                Dim query As String = "SELECT u.firstName as FirstName, u.middleName as MiddleName, u.lastName as LastName, u.studentNumber AS 'StudentNumber', u.email AS 'Email', u.phoneNumber AS 'MobileNumber', 
                                   u.gender AS 'Gender', u.year AS 'Year', u.course AS 'Course', u.rfid as RFID, p.firstName as ParentFirstName, p.middleName as ParentMiddleName, 
                                   p.lastName as ParentLastName, p.phoneNumber as ParentMobile, p.email as ParentEmail, p.gender as ParentGender , u.studentStat as Status , u.profile as Profile
                                   FROM user u 
                                   INNER JOIN parent p ON p.userID = u.userID
                                   WHERE adminID = @adminID AND role = @role and u.rfid IS Not NULL"

                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters for adminID and role
                    cmd.Parameters.AddWithValue("@adminID", Login.adminID)
                    cmd.Parameters.AddWithValue("@role", Student)

                    ' Create a DataTable to hold the query results
                    Dim dt As New DataTable()

                    ' Fill the DataTable with data from the MySQL query
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using

                    ' Check if the DataTable has rows (users)
                    If dt.Rows.Count > 0 Then
                        ' Clear any existing data
                        dtgStudent.DataSource = Nothing

                        ' Bind the DataTable to the DataGridView
                        dtgStudent.DataSource = dt
                        dtgStudent.Refresh()

                        ' Set column styles
                        dtgStudent.Columns("LastName").DefaultCellStyle.ForeColor = Color.Blue
                        dtgStudent.Columns("LastName").DefaultCellStyle.Font = New Font(dtgStudent.Font, FontStyle.Underline)

                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub listRecord()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to retrieve users based on the adminID and role
                Dim query As String = "SELECT u.firstName as FirstName, u.middleName as MiddleName, u.lastName as LastName, r.dateIN AS TimeIN, r.dateOut AS TimeOut, r.date AS Date " &
                      "FROM user u " &
                      "inner JOIN records r ON r.userID = u.userID " &
                      "WHERE u.adminID = @adminID AND u.role = @role"


                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters for adminID and role
                    cmd.Parameters.AddWithValue("@adminID", Login.adminID)
                    cmd.Parameters.AddWithValue("@role", Student)

                    ' Create a DataTable to hold the query results
                    Dim dt As New DataTable()

                    ' Fill the DataTable with data from the MySQL query
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using

                    ' Check if the DataTable has rows (users)
                    If dt.Rows.Count > 0 Then
                        ' Clear any existing data
                        dtgViewRecord.DataSource = Nothing

                        ' Bind the DataTable to the DataGridView
                        dtgViewRecord.DataSource = dt
                        dtgViewRecord.Refresh()



                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub listSubadmin()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to retrieve users based on the adminID and role
                Dim query As String = "SELECT firstName as FirstName, lastName as LastName, middleName as MiddleName , position as Position, email as Email, phoneNumber as MobileNumber,
                                   gender as Gender, password as Password , logOnName as Username
                                   FROM user
                                   WHERE adminID = @adminID AND role = @role"

                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters for adminID and role
                    cmd.Parameters.AddWithValue("@adminID", Login.adminID)
                    cmd.Parameters.AddWithValue("@role", Subadmin)

                    ' Create a DataTable to hold the query results
                    Dim dt As New DataTable()

                    ' Fill the DataTable with data from the MySQL query
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using

                    ' Check if the DataTable has rows (users)
                    If dt.Rows.Count > 0 Then
                        ' Clear any existing data
                        dtgListSubadmin.DataSource = Nothing

                        ' Bind the DataTable to the DataGridView
                        dtgListSubadmin.DataSource = dt
                        dtgListSubadmin.Refresh()

                        ' Set column styles
                        dtgListSubadmin.Columns("Password").Visible = False
                        dtgListSubadmin.Columns("LastName").DefaultCellStyle.ForeColor = Color.Blue
                        dtgListSubadmin.Columns("LastName").DefaultCellStyle.Font = New Font(dtgListSubadmin.Font, FontStyle.Underline)

                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dtgStudent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgStudent.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dtgStudent.Columns("LastName").Index Then
            ' Check if the form is already open
            For Each f As Form In Application.OpenForms
                If TypeOf f Is AddStudent Then
                    f.Focus() ' Bring the form to the front if already open
                    Return
                End If
            Next

            ' Create a new instance of AddStudent form
            Dim studentDetailsForm As New AddStudent()

            ' Pass the selected student's data to the new form
            studentDetailsForm.txtfName.Text = dtgStudent.Rows(e.RowIndex).Cells("FirstName").Value.ToString()
            studentDetailsForm.txtmName.Text = dtgStudent.Rows(e.RowIndex).Cells("MiddleName").Value.ToString()
            studentDetailsForm.txtlName.Text = dtgStudent.Rows(e.RowIndex).Cells("LastName").Value.ToString()
            studentDetailsForm.txtstudentEmail.Text = dtgStudent.Rows(e.RowIndex).Cells("Email").Value.ToString()
            studentDetailsForm.txtstudentMobile.Text = dtgStudent.Rows(e.RowIndex).Cells("MobileNumber").Value.ToString()
            studentDetailsForm.txtstudentNumber.Text = dtgStudent.Rows(e.RowIndex).Cells("StudentNumber").Value.ToString()
            studentDetailsForm.cboGender.Text = dtgStudent.Rows(e.RowIndex).Cells("Gender").Value.ToString()
            studentDetailsForm.cboYear.Text = dtgStudent.Rows(e.RowIndex).Cells("Year").Value.ToString()
            studentDetailsForm.txtCourse.Text = dtgStudent.Rows(e.RowIndex).Cells("Course").Value.ToString()
            studentDetailsForm.rfid = dtgStudent.Rows(e.RowIndex).Cells("RFID").Value.ToString()
            studentDetailsForm.cboStudentStat.Text = dtgStudent.Rows(e.RowIndex).Cells("Status").Value.ToString()

            ' Handle Profile Image Data
            ' Handle Profile Image Data
            Dim profileData As Object = dtgStudent.Rows(e.RowIndex).Cells("Profile").Value

            If profileData IsNot DBNull.Value Then
                ' Safe to cast to Byte[] if the value is not DBNull
                Dim profileByteArray As Byte() = CType(profileData, Byte())
                If profileByteArray IsNot Nothing AndAlso profileByteArray.Length > 0 Then
                    ' Convert the byte array to an image and set it to the ptbStudent Image
                    Using ms As New MemoryStream(profileByteArray)
                        studentDetailsForm.ptbStudent.Image = Image.FromStream(ms)
                    End Using
                Else
                    ' If the profile image is empty, set to a default image or null
                    studentDetailsForm.ptbStudent.Image = Nothing
                End If
            Else
                ' If the profile data is DBNull, set the image to null
                studentDetailsForm.ptbStudent.Image = Nothing
            End If


            ' Populate Parent's Data
            studentDetailsForm.txtEmailP1.Text = dtgStudent.Rows(e.RowIndex).Cells("ParentEmail").Value.ToString()
            studentDetailsForm.txtFnameP1.Text = dtgStudent.Rows(e.RowIndex).Cells("ParentFirstName").Value.ToString()
            studentDetailsForm.txtLnameP1.Text = dtgStudent.Rows(e.RowIndex).Cells("ParentLastName").Value.ToString()
            studentDetailsForm.txtMnameP1.Text = dtgStudent.Rows(e.RowIndex).Cells("ParentMiddleName").Value.ToString()
            studentDetailsForm.cboGenderParent.Text = dtgStudent.Rows(e.RowIndex).Cells("ParentGender").Value.ToString()
            studentDetailsForm.txtMobileP1.Text = dtgStudent.Rows(e.RowIndex).Cells("ParentMobile").Value.ToString()

            ' Disable fields if needed
            studentDetailsForm.EnableField = False

            ' Show the AddStudent form
            studentDetailsForm.ShowDialog()
            liststudent()
        End If
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnViewRecord2_Click(sender As Object, e As EventArgs) Handles btnViewRecord2.Click
        visibilityState = 1

        visiblepanel()
        listRecord()
    End Sub

    Private Sub btnViewSubAdmin2_Click(sender As Object, e As EventArgs) Handles btnViewSubAdmin2.Click
        visibilityState = 2
        visiblepanel()
        listSubadmin()
    End Sub
    Private Sub visiblepanel()
        If visibilityState = 1 Then
            pnlViewRecord.Location = New Point(216, 62)
            pnlViewRecord.Visible = True
            pnlViewSubadmin.Visible = False
            pnlSettings.Visible = False
            pnlViewStudent.Visible = False
            lblPanelname.Text = "View Record"
            lblPanelname.Visible = True
            pnlProfileInformation.Visible = False
            pnlDashboard.Visible = False

        ElseIf visibilityState = 2 Then
            pnlViewSubadmin.Location = New Point(216, 62)
            pnlViewSubadmin.Visible = True
            pnlViewRecord.Visible = False
            pnlSettings.Visible = False
            pnlViewStudent.Visible = False
            lblPanelname.Text = "View Sub Admin"
            lblPanelname.Visible = True
            pnlPendingStudents.Visible = False
            pnlProfileInformation.Visible = False
            pnlDashboard.Visible = False

        ElseIf visibilityState = 3 Then
            pnlViewStudent.Location = New Point(216, 62)
            pnlViewStudent.Visible = True
            pnlViewRecord.Visible = False
            pnlSettings.Visible = False
            pnlViewSubadmin.Visible = False
            lblPanelname.Text = "View Student"
            lblPanelname.Visible = True
            pnlPendingStudents.Visible = False
            pnlProfileInformation.Visible = False
            pnlDashboard.Visible = False

        ElseIf visibilityState = 4 Then
            pnlSettings.Location = New Point(216, 62)
            pnlSettings.Visible = True
            pnlViewStudent.Visible = False
            pnlViewRecord.Visible = False
            pnlViewSubadmin.Visible = False
            lblPanelname.Text = "Settings"
            lblPanelname.Visible = True
            pnlPendingStudents.Visible = False
            pnlProfileInformation.Visible = False
            pnlDashboard.Visible = False
        ElseIf visibilityState = 5 Then
            pnlProfileInformation.Location = New Point(216, 62)
            pnlProfileInformation.Visible = True
            pnlSettings.Visible = False
            pnlViewStudent.Visible = False
            pnlViewRecord.Visible = False
            pnlViewSubadmin.Visible = False
            lblPanelname.Text = "Profile"
            lblPanelname.Visible = True
            pnlPendingStudents.Visible = False
            pnlDashboard.Visible = False
        ElseIf visibilityState = 6 Then
            pnlPendingStudents.Location = New Point(216, 62)
            pnlPendingStudents.Visible = True
            pnlProfileInformation.Visible = False
            pnlSettings.Visible = False
            pnlViewStudent.Visible = False
            pnlViewRecord.Visible = False
            pnlViewSubadmin.Visible = False
            lblPanelname.Text = "Student Pending"
            lblPanelname.Visible = True
            pnlDashboard.Visible = False
        Else
            pnlPendingStudents.Visible = False
            pnlProfileInformation.Visible = False
            pnlSettings.Visible = False
            pnlViewStudent.Visible = False
            pnlViewRecord.Visible = False
            pnlViewSubadmin.Visible = False
            lblPanelname.Text = "Home"
            lblPanelname.Visible = True
            pnlDashboard.Location = New Point(216, 62)
            pnlDashboard.Visible = True
        End If
    End Sub

    Private Sub btnViewStudent2_Click(sender As Object, e As EventArgs) Handles btnViewStudent2.Click
        visibilityState = 3
        liststudent()
        visiblepanel()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()

        Dim form As New StudentInAndOut

        form.Show()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click


        Login.txtUsername.Clear()
        Login.txtPassword.Clear()

        Login.Show()
        Me.Dispose()

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        visibilityState = 6
        visiblepanel()
        liststudentpending()
    End Sub

    Private Sub btnViewRecord_Click(sender As Object, e As EventArgs)
        visibilityState = 1

        visiblepanel()
    End Sub

    Private Sub btnViewStudent_Click(sender As Object, e As EventArgs)
        visibilityState = 3

        visiblepanel()
    End Sub

    Private Sub btnViewSubAdmin_Click(sender As Object, e As EventArgs)
        visibilityState = 2
        visiblepanel()
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click


        Dim form As New AddStudent
        form.EnableField = True
        form.btnEdit.Visible = False
        form.btnSave.Enabled = True
        form.ShowDialog()


    End Sub

    Private Sub btnAddSub_Click(sender As Object, e As EventArgs) Handles btnAddSub.Click
        Dim form As New addSubadmin
        form.EnableField = True
        form.insert = 1
        form.btnEdit.Visible = False
        form.btnSave.Enabled = True
        form.ShowDialog()



    End Sub

    Private Sub dtgListSubadmin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgListSubadmin.CellContentClick
        ' Ensure the clicked cell is the "LastName" column
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dtgListSubadmin.Columns("LastName").Index Then
            ' Create a new instance of AddStudent form
            Dim subadmindetails As New addSubadmin()

            ' Pass the selected student's data to the new form
            subadmindetails.txtfName.Text = dtgListSubadmin.Rows(e.RowIndex).Cells("FirstName").Value.ToString()
            subadmindetails.txtmName.Text = dtgListSubadmin.Rows(e.RowIndex).Cells("MiddleName").Value.ToString()
            subadmindetails.txtlName.Text = dtgListSubadmin.Rows(e.RowIndex).Cells("LastName").Value.ToString()
            subadmindetails.txtEmail.Text = dtgListSubadmin.Rows(e.RowIndex).Cells("Email").Value.ToString()
            subadmindetails.txtMobile.Text = dtgListSubadmin.Rows(e.RowIndex).Cells("MobileNumber").Value.ToString()
            subadmindetails.cbogender.Text = dtgListSubadmin.Rows(e.RowIndex).Cells("Gender").Value.ToString()
            subadmindetails.txtPosition.Text = dtgListSubadmin.Rows(e.RowIndex).Cells("Position").Value.ToString()
            subadmindetails.txtUsername.Text = dtgListSubadmin.Rows(e.RowIndex).Cells("Username").Value.ToString()
            subadmindetails.txtPassword.Text = dtgListSubadmin.Rows(e.RowIndex).Cells("Password").Value.ToString()

            subadmindetails.EnableField = False

            subadmindetails.ShowDialog()
            listSubadmin()
        End If
    End Sub

    Private Sub pnlViewStudent_Paint(sender As Object, e As PaintEventArgs) Handles pnlViewStudent.Paint

    End Sub

    Private Sub btnFilterSub_Click(sender As Object, e As EventArgs) Handles btnFilterSub.Click
        Dim filterQuery As String = ""

        ' Determine the filter condition based on the selected value in the combo box
        If cboFilterSub.Text = "FirstName" Then
            filterQuery = "firstName = @filter"
        ElseIf cboFilterSub.Text = "LastName" Then
            filterQuery = "lastName = @filter"
        ElseIf cboFilterSub.Text = "Number" Then
            filterQuery = "phoneNumber = @filter"
        ElseIf cboFilterSub.Text = "Position" Then
            filterQuery = "position = @filter"
        ElseIf cboFilterSub.Text = "Gender" Then
            filterQuery = "gender = @filter"
        ElseIf cboFilterSub.Text = "Email" Then
            filterQuery = "email = @filter"
        End If


        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to retrieve users based on the adminID and role
                Dim query As String = "SELECT firstName AS FirstName, lastName AS LastName, middleName AS MiddleName, " &
                              "position AS Position, email AS Email, phoneNumber AS MobileNumber, " &
                              "gender AS Gender, password AS Password, logOnName AS Username " &
                              "FROM user " &
                              "WHERE adminID = @adminID AND role = @role"

                If Not String.IsNullOrEmpty(filterQuery) Then
                    query &= " AND " & filterQuery
                End If

                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters for adminID and role
                    cmd.Parameters.AddWithValue("@adminID", Login.adminID)
                    cmd.Parameters.AddWithValue("@role", Subadmin)
                    cmd.Parameters.AddWithValue("@filter", txtFilterSub.Text)

                    ' Create a DataTable to hold the query results
                    Dim dt As New DataTable()

                    ' Fill the DataTable with data from the MySQL query
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using

                    ' Check if the DataTable has rows (users)
                    If dt.Rows.Count > 0 Then
                        ' Clear any existing data
                        dtgListSubadmin.DataSource = Nothing

                        ' Bind the DataTable to the DataGridView
                        dtgListSubadmin.DataSource = dt
                        dtgListSubadmin.Refresh()

                        ' Set column styles
                        dtgListSubadmin.Columns("Password").Visible = False
                        dtgListSubadmin.Columns("LastName").DefaultCellStyle.ForeColor = Color.Blue
                        dtgListSubadmin.Columns("LastName").DefaultCellStyle.Font = New Font(dtgListSubadmin.Font, FontStyle.Underline)

                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnFilterStudent_Click(sender As Object, e As EventArgs) Handles btnFilterStudent.Click
        Dim filterQuery As String = ""

        ' Determine the filter condition based on the selected value in the combo box
        If cboFilterStudent.Text = "FirstName" Then
            filterQuery = "u.firstName = @filter"
        ElseIf cboFilterStudent.Text = "LastName" Then
            filterQuery = "u.lastName = @filter"
        ElseIf cboFilterStudent.Text = "Number" Then
            filterQuery = "u.phoneNumber = @filter"
        ElseIf cboFilterStudent.Text = "StudentNumber" Then
            filterQuery = "u.studentNumber = @filter"
        ElseIf cboFilterStudent.Text = "Gender" Then
            filterQuery = "u.gender = @filter"
        ElseIf cboFilterStudent.Text = "Email" Then
            filterQuery = "u.email = @filter"
        ElseIf cboFilterStudent.Text = "Status" Then
            filterQuery = "u.studentStat = @filter"
        ElseIf cboFilterStudent.Text = "Course" Then
            filterQuery = "u.course = @filter"
        End If


        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Base query
                Dim query As String = "SELECT u.firstName AS 'FirstName', u.middleName AS 'MiddleName', u.lastName AS 'LastName', " &
                                      "u.studentNumber AS 'StudentNumber', u.email AS 'Email', u.phoneNumber AS 'MobileNumber', " &
                                      "u.gender AS 'Gender', u.year AS 'Year', u.course AS 'Course', u.rfid AS 'RFID', " &
                                      "p.firstName AS 'ParentFirstName', p.middleName AS 'ParentMiddleName', p.lastName AS 'ParentLastName', " &
                                      "p.phoneNumber AS 'ParentMobile', p.email AS 'ParentEmail', p.gender AS 'ParentGender', " &
                                      "u.studentStat AS 'Status', u.profile AS 'Profile' " &
                                      "FROM user u " &
                                      "INNER JOIN parent p ON p.userID = u.userID " &
                                      "WHERE adminID = @adminID AND role = @role"

                ' Append dynamic filter condition if specified
                If Not String.IsNullOrEmpty(filterQuery) Then
                    query &= " AND " & filterQuery
                End If

                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("@adminID", Login.adminID)
                    cmd.Parameters.AddWithValue("@role", "Student") ' Ensure the role is passed correctly
                    cmd.Parameters.AddWithValue("@filter", txtFilterStudent.Text)

                    ' Fill DataTable
                    Dim dt As New DataTable()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using

                    If dt.Rows.Count > 0 Then
                        dtgStudent.DataSource = Nothing
                        dtgStudent.DataSource = dt
                        dtgStudent.Refresh()

                        ' Apply column styles if "LastName" column exists
                        If dtgStudent.Columns.Contains("LastName") Then
                            dtgStudent.Columns("LastName").DefaultCellStyle.ForeColor = Color.Blue
                            dtgStudent.Columns("LastName").DefaultCellStyle.Font = New Font(dtgStudent.Font, FontStyle.Underline)
                        End If

                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Log the error and show a user-friendly message
            MessageBox.Show("An error occurred while retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnFilterRecord_Click(sender As Object, e As EventArgs) Handles btnFilterRecord.Click
        Dim filterQuery As String = ""

        ' Determine the filter condition based on the selected value in the combo box
        If cboFilterRecord.Text = "FirstName" Then
            filterQuery = "u.firstName = @filters"
        ElseIf cboFilterRecord.Text = "LastName" Then
            filterQuery = "u.lastName = @filters"
        ElseIf cboFilterRecord.Text = "Date" Then
            filterQuery = "DATE(r.date) = @filter"

        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Base query
                Dim query As String = "SELECT u.firstName AS FirstName, u.middleName AS MiddleName, u.lastName AS LastName, " &
                                      "r.dateIN AS TimeIN, r.dateOut AS TimeOut, r.date AS Date " &
                                      "FROM user u " &
                                      "INNER JOIN records r ON r.userID = u.userID " &
                                      "WHERE u.adminID = @adminID AND u.role = @role"

                ' Append dynamic filter condition if specified
                If Not String.IsNullOrEmpty(filterQuery) Then
                    query &= " AND " & filterQuery
                End If

                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters for adminID and role
                    cmd.Parameters.AddWithValue("@adminID", Login.adminID)
                    cmd.Parameters.AddWithValue("@role", Student)

                    ' Add filter parameters based on the selected condition
                    If cboFilterRecord.Text = "FirstName" OrElse cboFilterRecord.Text = "LastName" Then
                        cmd.Parameters.AddWithValue("@filters", txtFilterRecord.Text)
                    ElseIf cboFilterRecord.Text = "Date" Then
                        cmd.Parameters.AddWithValue("@filter", dtpRecord.Value.ToString("yyyy-MM-dd"))
                    End If

                    ' Create a DataTable to hold the query results
                    Dim dt As New DataTable()

                    ' Execute the query and load results into the DataTable
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using

                    ' Display results in DataGridView
                    If dt.Rows.Count > 0 Then
                        dtgViewRecord.DataSource = Nothing
                        dtgViewRecord.DataSource = dt
                        dtgViewRecord.Refresh()

                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cboFilterRecord_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterRecord.SelectedIndexChanged
        If cboFilterRecord.Text = "FirstName" Or cboFilterRecord.Text = "LastName" Then
            dtpRecord.Enabled = False
            txtFilterRecord.Enabled = True

        Else
            txtFilterRecord.Enabled = False
            dtpRecord.Enabled = True
        End If
    End Sub

    Private Sub btnPrintRecord_Click(sender As Object, e As EventArgs) Handles btnPrintRecord.Click
        Dim filterQuery As String = ""

        ' Determine the filter condition based on the selected value in the combo box
        If cboFilterRecord.Text = "FirstName" Then
            filterQuery = "u.firstName = @filters"
        ElseIf cboFilterRecord.Text = "LastName" Then
            filterQuery = "u.lastName = @filters"
        ElseIf cboFilterRecord.Text = "Date" Then
            filterQuery = "DATE(r.date) = @filter"

        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to retrieve users based on the adminID and role
                Dim query As String = "SELECT u.firstName AS FirstName, u.middleName AS MiddleName, u.lastName AS LastName, " &
                                      "r.dateIN AS TimeIN, r.dateOut AS TimeOut, r.date AS Date " &
                                      "FROM user u " &
                                      "INNER JOIN records r ON r.userID = u.userID " &
                                      "WHERE u.adminID = @adminID AND u.role = @role"

                ' Append dynamic filter condition if specified
                If Not String.IsNullOrEmpty(filterQuery) Then
                    query &= " AND " & filterQuery
                End If

                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters for adminID and role
                    cmd.Parameters.AddWithValue("@adminID", Login.adminID)
                    cmd.Parameters.AddWithValue("@role", Student)

                    ' Add filter parameters based on the selected condition
                    If cboFilterRecord.Text = "FirstName" OrElse cboFilterRecord.Text = "LastName" Then
                        cmd.Parameters.AddWithValue("@filters", txtFilterRecord.Text)
                    ElseIf cboFilterRecord.Text = "Date" Then
                        cmd.Parameters.AddWithValue("@filter", dtpRecord.Value.ToString("yyyy-MM-dd"))
                    End If
                    ' Create a DataTable to hold the query results
                    Dim dt As New DataTable()

                    ' Fill the DataTable with data from the MySQL query
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using

                    ' Check if the DataTable has rows (users)
                    If dt.Rows.Count > 0 Then
                        ' Clear any existing data
                        dt.TableName = "PendingStudents"
                        ' dt.WriteXmlSchema("C:\Users\HP\Desktop\StudentParentNotification-20241117T234955Z-001\StudentParentNotification\XML\ListRecord.xml")

                        Dim report As New PrintListRecord
                        report.SummaryInfo.ReportTitle = "List Student Record "
                        report.SetDataSource(dt)
                        Dim frmReport As New Print(report)
                        frmReport.ShowDialog()

                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        visibilityState = 4
        visiblepanel()
    End Sub

    Private Sub btnUpdateCredentials_Click(sender As Object, e As EventArgs) Handles btnUpdateCredentials.Click
        Dim yes As Boolean = True

        ' Check if the old password matches
        If txtOldPassword.Text <> Login.password Then
            MsgBox("The Old password did not match the previous password.")
            yes = False
        End If

        ' Check if the new password matches the re-entered password
        If txtNewPassword.Text <> txtReEnterPassword.Text Then
            MsgBox("The new password did not match the re-entered password.")
            yes = False
        End If
        If txtNewPassword.Text = "" Or txtReEnterPassword.Text = "" Or txtUsername.Text = "" Then
            MsgBox("Fill the Empty Fields")
            yes = False
        End If

        ' Proceed if all conditions are satisfied
        If yes = True Then
            Try
                ' Hash the new password before storing it in the database (for security)
                ' Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(txtNewPassword.Text)

                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' SQL query to update the user's password and logOnName
                    Dim sql As String = "UPDATE user SET password = @password, logOnName = @logOnName WHERE userID = @adminID"

                    ' Create the MySQL command
                    Using cmd As New MySqlCommand(sql, connection)
                        ' Add parameters to the SQL query
                        cmd.Parameters.AddWithValue("@password", txtNewPassword.Text)
                        cmd.Parameters.AddWithValue("@logOnName", txtUsername.Text) ' Assuming there's a textbox for the logOnName
                        cmd.Parameters.AddWithValue("@adminID", Login.userID) ' Assuming Login.adminID contains the current user's adminID

                        ' Execute the update query
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                ' Inform the user that the password was successfully updated
                MessageBox.Show("Your password has been updated successfully.", "Password Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Login.Show()
                Login.txtUsername.Clear()
                Login.txtPassword.Clear()

                Me.Dispose()

            Catch ex As MySqlException
                ' Handle any MySQL specific exceptions
                MessageBox.Show("Database error during registration: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                ' Handle any other general exceptions
                MessageBox.Show("An error occurred during registration: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If



    End Sub
    Private Function GenerateCode() As String
        ' Define a string containing all possible characters (uppercase letters and digits)
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"

        ' Random object to generate the code
        Dim rand As New Random()

        ' Define the length of the code (e.g., 12 characters for a longer code)
        Dim codeLength As Integer = 12  ' Change this number to generate longer codes if needed

        ' Build the generated code by picking random characters
        Dim generatedCode As String = ""
        For i As Integer = 1 To codeLength
            ' Select a random character from the chars string and append it to the generated code
            generatedCode &= chars(rand.Next(chars.Length))
        Next

        ' Return the generated alphanumeric code
        Return generatedCode
    End Function


    Private Sub btnGenerateCode_Click(sender As Object, e As EventArgs) Handles btnGenerateCode.Click
        ' Generate a random alphanumeric code
        Dim generatedCode As String = GenerateCode()

        ' Set the generated code to the txtCode textbox
        txtCode.Text = generatedCode
    End Sub

    Private Sub btnUpdateCode_Click(sender As Object, e As EventArgs) Handles btnUpdateCode.Click
        If txtCode.Text <> Login.code Then
            Try
                ' Hash the new password before storing it in the database (for security)
                ' Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(txtNewPassword.Text)

                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' SQL query to update the user's Code (assuming Code is for verification)
                    Dim sql As String = "UPDATE user SET Code = @Code WHERE userID = @adminID"

                    ' Create the MySQL command
                    Using cmd As New MySqlCommand(sql, connection)
                        ' Add parameters to the SQL query
                        cmd.Parameters.AddWithValue("@Code", txtCode.Text) ' Corrected to use @Code as per the SQL query
                        cmd.Parameters.AddWithValue("@adminID", Login.adminID) ' Assuming Login.adminID contains the current user's adminID

                        ' Execute the update query
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                ' Inform the user that the code was successfully updated
                MessageBox.Show("Your code has been updated successfully.", "Code Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Login.Show()
                Login.txtUsername.Clear()
                Login.txtPassword.Clear()

                ' Close the current form
                Me.Dispose()

            Catch ex As MySqlException
                ' Handle any MySQL-specific exceptions
                MessageBox.Show("Database error during registration: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                ' Handle any other general exceptions
                MessageBox.Show("An error occurred during registration: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub ptbProfile_Click(sender As Object, e As EventArgs)
        visibilityState = 5
        visiblepanel()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Try
            ' Hash the new password before storing it in the database (for security)
            ' Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(txtNewPassword.Text)

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to update the user's Code (assuming Code is for verification)
                Dim sql As String = "UPDATE user SET email = @email, phoneNumber = @phoneNumber, gender = @gender, firstName = @firstName, middleName = @middleName, lastName = @lastName WHERE userID = @adminID"

                ' Create the MySQL command
                Using cmd As New MySqlCommand(sql, connection)
                    ' Add parameters to the SQL query
                    cmd.Parameters.AddWithValue("@email", txtEmailProfile.Text) ' Corrected to use @Code as per the SQL query
                    cmd.Parameters.AddWithValue("@phoneNumber", txtNumberProfile.Text) ' Corrected to use @Code as per the SQL query
                    cmd.Parameters.AddWithValue("@gender", cboGenderProfile.Text) ' Corrected to use @Code as per the SQL query
                    cmd.Parameters.AddWithValue("@firstName", txtFirstNameProfile.Text) ' Corrected to use @Code as per the SQL query
                    cmd.Parameters.AddWithValue("@middleName", txtMiddleNameProfile.Text) ' Corrected to use @Code as per the SQL query
                    cmd.Parameters.AddWithValue("@lastName", txtLastNameProfile.Text) ' Corrected to use @Code as per the SQL query
                    cmd.Parameters.AddWithValue("@adminID", Login.adminID) ' Assuming Login.adminID contains the current user's adminID

                    ' Execute the update query
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Inform the user that the code was successfully updated
            MessageBox.Show("Your Prfile has been updated successfully.", "Profile Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Login.Show()
            Login.txtUsername.Clear()
            Login.txtPassword.Clear()

            ' Close the current form
            Me.Dispose()

        Catch ex As MySqlException
            ' Handle any MySQL-specific exceptions
            MessageBox.Show("Database error during registration: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' Handle any other general exceptions
            MessageBox.Show("An error occurred during registration: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        visibilityState = 0

        visiblepanel()
    End Sub

    Private Sub dtgStudentPending_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgStudentPending.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dtgStudentPending.Columns("LastName").Index Then
            ' Check if the form is already open
            For Each f As Form In Application.OpenForms
                If TypeOf f Is AddStudent Then
                    f.Focus() ' Bring the form to the front if already open
                    Return
                End If
            Next

            ' Create a new instance of AddStudent form
            Dim studentDetailsForm As New AddStudent()

            ' Pass the selected student's data to the new form
            studentDetailsForm.txtfName.Text = dtgStudentPending.Rows(e.RowIndex).Cells("FirstName").Value.ToString()
            studentDetailsForm.txtmName.Text = dtgStudentPending.Rows(e.RowIndex).Cells("MiddleName").Value.ToString()
            studentDetailsForm.txtlName.Text = dtgStudentPending.Rows(e.RowIndex).Cells("LastName").Value.ToString()
            studentDetailsForm.txtstudentEmail.Text = dtgStudentPending.Rows(e.RowIndex).Cells("Email").Value.ToString()
            studentDetailsForm.txtstudentMobile.Text = dtgStudentPending.Rows(e.RowIndex).Cells("MobileNumber").Value.ToString()
            studentDetailsForm.txtstudentNumber.Text = dtgStudentPending.Rows(e.RowIndex).Cells("StudentNumber").Value.ToString()
            studentDetailsForm.cboGender.Text = dtgStudentPending.Rows(e.RowIndex).Cells("Gender").Value.ToString()
            studentDetailsForm.cboYear.Text = dtgStudentPending.Rows(e.RowIndex).Cells("Year").Value.ToString()
            studentDetailsForm.txtCourse.Text = dtgStudentPending.Rows(e.RowIndex).Cells("Course").Value.ToString()
            studentDetailsForm.rfid = dtgStudentPending.Rows(e.RowIndex).Cells("RFID").Value.ToString()
            studentDetailsForm.cboStudentStat.Text = dtgStudentPending.Rows(e.RowIndex).Cells("Status").Value.ToString()

            ' Handle Profile Image Data
            ' Handle Profile Image Data
            Dim profileData As Object = dtgStudentPending.Rows(e.RowIndex).Cells("Profile").Value

            If profileData IsNot DBNull.Value Then
                ' Safe to cast to Byte[] if the value is not DBNull
                Dim profileByteArray As Byte() = CType(profileData, Byte())
                If profileByteArray IsNot Nothing AndAlso profileByteArray.Length > 0 Then
                    ' Convert the byte array to an image and set it to the ptbStudent Image
                    Using ms As New MemoryStream(profileByteArray)
                        studentDetailsForm.ptbStudent.Image = Image.FromStream(ms)
                    End Using
                Else
                    ' If the profile image is empty, set to a default image or null
                    studentDetailsForm.ptbStudent.Image = Nothing
                End If
            Else
                ' If the profile data is DBNull, set the image to null
                studentDetailsForm.ptbStudent.Image = Nothing
            End If


            ' Populate Parent's Data
            studentDetailsForm.txtEmailP1.Text = dtgStudentPending.Rows(e.RowIndex).Cells("ParentEmail").Value.ToString()
            studentDetailsForm.txtFnameP1.Text = dtgStudentPending.Rows(e.RowIndex).Cells("ParentFirstName").Value.ToString()
            studentDetailsForm.txtLnameP1.Text = dtgStudentPending.Rows(e.RowIndex).Cells("ParentLastName").Value.ToString()
            studentDetailsForm.txtMnameP1.Text = dtgStudentPending.Rows(e.RowIndex).Cells("ParentMiddleName").Value.ToString()
            studentDetailsForm.cboGenderParent.Text = dtgStudentPending.Rows(e.RowIndex).Cells("ParentGender").Value.ToString()
            studentDetailsForm.txtMobileP1.Text = dtgStudentPending.Rows(e.RowIndex).Cells("ParentMobile").Value.ToString()

            ' Disable fields if needed
            studentDetailsForm.EnableField = False

            ' Show the AddStudent form
            studentDetailsForm.ShowDialog()
            liststudentpending()
        End If
    End Sub

    Private Sub btnPrinfPending_Click(sender As Object, e As EventArgs) Handles btnPrinfPending.Click
        Dim filterQuery As String = ""

        ' Determine the filter condition based on the selected value in the combo box
        If cboFilterPending.Text = "FirstName" Then
            filterQuery = "u.firstName = @filter"
        ElseIf cboFilterPending.Text = "LastName" Then
            filterQuery = "u.lastName = @filter"
        ElseIf cboFilterPending.Text = "Number" Then
            filterQuery = "u.phoneNumber = @filter"
        ElseIf cboFilterPending.Text = "StudentNumber" Then
            filterQuery = "u.studentNumber = @filter"
        ElseIf cboFilterPending.Text = "Gender" Then
            filterQuery = "u.gender = @filter"
        ElseIf cboFilterPending.Text = "Email" Then
            filterQuery = "u.email = @filter"
        ElseIf cboFilterPending.Text = "Status" Then
            filterQuery = "u.studentStat = @filter"
        ElseIf cboFilterPending.Text = "Course" Then
            filterQuery = "u.course = @filter"
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to retrieve users based on the adminID and role
                Dim query As String = "SELECT u.firstName as FirstName , u.middleName as MiddleName, u.lastName as LastName, u.studentNumber AS 'StudentNumber', u.email AS 'Email', u.phoneNumber AS 'MobileNumber', 
                                   u.gender AS 'Gender', u.year AS 'Year', u.course AS 'Course', u.rfid as RFID, p.firstName as ParentFirstName, p.middleName as ParentMiddleName, 
                                   p.lastName as ParentLastName, p.phoneNumber as ParentMobile, p.email as ParentEmail, p.gender as ParentGender , u.studentStat as Status , u.profile as Profile
                                   FROM user u 
                                   INNER JOIN parent p ON p.userID = u.userID
                                   WHERE adminID = @adminID AND role = @role and u.rfid IS NULL"

                ' Append dynamic filter condition if specified
                If Not String.IsNullOrEmpty(filterQuery) Then
                    query &= " AND " & filterQuery
                End If

                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters for adminID and role
                    cmd.Parameters.AddWithValue("@adminID", Login.adminID)
                    cmd.Parameters.AddWithValue("@role", Student)

                    ' Create a DataTable to hold the query results
                    Dim dt As New DataTable()

                    ' Fill the DataTable with data from the MySQL query
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using

                    ' Check if the DataTable has rows (users)
                    If dt.Rows.Count > 0 Then
                        ' Clear any existing data
                        dt.TableName = "PendingStudents"
                        'dt.WriteXmlSchema("C:\Users\HP\Desktop\StudentParentNotification-20241117T234955Z-001\StudentParentNotification\XML\StudentPending.xml")

                        Dim report As New PrintRecord
                        report.SummaryInfo.ReportTitle = "Pending Student "
                        report.SetDataSource(dt)
                        Dim frmReport As New Print(report)
                        frmReport.ShowDialog()

                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnPrintSub_Click(sender As Object, e As EventArgs) Handles btnPrintSub.Click
        Dim filterQuery As String = ""

        ' Determine the filter condition based on the selected value in the combo box
        If cboFilterSub.Text = "FirstName" Then
            filterQuery = "firstName = @filter"
        ElseIf cboFilterSub.Text = "LastName" Then
            filterQuery = "lastName = @filter"
        ElseIf cboFilterSub.Text = "Number" Then
            filterQuery = "phoneNumber = @filter"
        ElseIf cboFilterSub.Text = "Position" Then
            filterQuery = "position = @filter"
        ElseIf cboFilterSub.Text = "Gender" Then
            filterQuery = "gender = @filter"
        ElseIf cboFilterSub.Text = "Email" Then
            filterQuery = "email = @filter"
        End If




        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to retrieve users based on the adminID and role
                Dim query As String = "SELECT firstName as FirstName, lastName as LastName, middleName as MiddleName , position as Position, email as Email, phoneNumber as MobileNumber,
                                   gender as Gender, password as Password , logOnName as Username
                                   FROM user
                                   WHERE adminID = @adminID AND role = @role"

                If Not String.IsNullOrEmpty(filterQuery) Then
                    query &= " AND " & filterQuery
                End If
                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters for adminID and role
                    cmd.Parameters.AddWithValue("@adminID", Login.adminID)
                    cmd.Parameters.AddWithValue("@role", Subadmin)
                    cmd.Parameters.AddWithValue("@filter", txtFilterSub.Text)
                    ' Create a DataTable to hold the query results
                    Dim dt As New DataTable()

                    ' Fill the DataTable with data from the MySQL query
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using

                    ' Check if the DataTable has rows (users)
                    If dt.Rows.Count > 0 Then
                        ' Clear any existing data
                        dt.TableName = "PendingStudents"
                        ' dt.WriteXmlSchema("C:\Users\HP\Desktop\StudentParentNotification-20241117T234955Z-001\StudentParentNotification\XML\Subadmin.xml")

                        Dim report As New PrintSubadmin
                        report.SummaryInfo.ReportTitle = "Subadmin "
                        report.SetDataSource(dt)
                        Dim frmReport As New Print(report)
                        frmReport.ShowDialog()

                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnFilterPending_Click(sender As Object, e As EventArgs) Handles btnFilterPending.Click
        Dim filterQuery As String = ""

        ' Determine the filter condition based on the selected value in the combo box
        If cboFilterPending.Text = "FirstName" Then
            filterQuery = "u.firstName = @filter"
        ElseIf cboFilterPending.Text = "LastName" Then
            filterQuery = "u.lastName = @filter"
        ElseIf cboFilterPending.Text = "Number" Then
            filterQuery = "u.phoneNumber = @filter"
        ElseIf cboFilterPending.Text = "StudentNumber" Then
            filterQuery = "u.studentNumber = @filter"
        ElseIf cboFilterPending.Text = "Gender" Then
            filterQuery = "u.gender = @filter"
        ElseIf cboFilterPending.Text = "Email" Then
            filterQuery = "u.email = @filter"
        ElseIf cboFilterPending.Text = "Status" Then
            filterQuery = "u.studentStat = @filter"
        ElseIf cboFilterPending.Text = "Course" Then
            filterQuery = "u.course = @filter"
        End If


        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Base query
                Dim query As String = "SELECT u.firstName AS 'FirstName', u.middleName AS 'MiddleName', u.lastName AS 'LastName', " &
                                      "u.studentNumber AS 'StudentNumber', u.email AS 'Email', u.phoneNumber AS 'MobileNumber', " &
                                      "u.gender AS 'Gender', u.year AS 'Year', u.course AS 'Course', u.rfid AS 'RFID', " &
                                      "p.firstName AS 'ParentFirstName', p.middleName AS 'ParentMiddleName', p.lastName AS 'ParentLastName', " &
                                      "p.phoneNumber AS 'ParentMobile', p.email AS 'ParentEmail', p.gender AS 'ParentGender', " &
                                      "u.studentStat AS 'Status', u.profile AS 'Profile' " &
                                      "FROM user u " &
                                      "INNER JOIN parent p ON p.userID = u.userID " &
                                      "WHERE adminID = @adminID AND role = @role and rfid is null"

                ' Append dynamic filter condition if specified
                If Not String.IsNullOrEmpty(filterQuery) Then
                    query &= " AND " & filterQuery
                End If

                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("@adminID", Login.adminID)
                    cmd.Parameters.AddWithValue("@role", "Student") ' Ensure the role is passed correctly
                    cmd.Parameters.AddWithValue("@filter", txtFilterPending.Text)

                    ' Fill DataTable
                    Dim dt As New DataTable()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using

                    If dt.Rows.Count > 0 Then
                        dtgStudentPending.DataSource = Nothing
                        dtgStudentPending.DataSource = dt
                        dtgStudentPending.Refresh()

                        ' Apply column styles if "LastName" column exists
                        If dtgStudentPending.Columns.Contains("LastName") Then
                            dtgStudentPending.Columns("LastName").DefaultCellStyle.ForeColor = Color.Blue
                            dtgStudentPending.Columns("LastName").DefaultCellStyle.Font = New Font(dtgStudentPending.Font, FontStyle.Underline)
                        End If

                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Log the error and show a user-friendly message
            MessageBox.Show("An error occurred while retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnPrintStudent_Click(sender As Object, e As EventArgs) Handles btnPrintStudent.Click
        Dim filterQuery As String = ""

        ' Determine the filter condition based on the selected value in the combo box
        If cboFilterStudent.Text = "FirstName" Then
            filterQuery = "u.firstName = @filter"
        ElseIf cboFilterStudent.Text = "LastName" Then
            filterQuery = "u.lastName = @filter"
        ElseIf cboFilterStudent.Text = "Number" Then
            filterQuery = "u.phoneNumber = @filter"
        ElseIf cboFilterStudent.Text = "StudentNumber" Then
            filterQuery = "u.studentNumber = @filter"
        ElseIf cboFilterStudent.Text = "Gender" Then
            filterQuery = "u.gender = @filter"
        ElseIf cboFilterStudent.Text = "Email" Then
            filterQuery = "u.email = @filter"
        ElseIf cboFilterStudent.Text = "Status" Then
            filterQuery = "u.studentStat = @filter"
        ElseIf cboFilterStudent.Text = "Course" Then
            filterQuery = "u.course = @filter"
        End If


        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Base query
                Dim query As String = "SELECT u.firstName AS 'FirstName', u.middleName AS 'MiddleName', u.lastName AS 'LastName', " &
                                      "u.studentNumber AS 'StudentNumber', u.email AS 'Email', u.phoneNumber AS 'MobileNumber', " &
                                      "u.gender AS 'Gender', u.year AS 'Year', u.course AS 'Course', u.rfid AS 'RFID', " &
                                      "p.firstName AS 'ParentFirstName', p.middleName AS 'ParentMiddleName', p.lastName AS 'ParentLastName', " &
                                      "p.phoneNumber AS 'ParentMobile', p.email AS 'ParentEmail', p.gender AS 'ParentGender', " &
                                      "u.studentStat AS 'Status', u.profile AS 'Profile' " &
                                      "FROM user u " &
                                      "INNER JOIN parent p ON p.userID = u.userID " &
                                      "WHERE adminID = @adminID AND role = @role"

                ' Append dynamic filter condition if specified
                If Not String.IsNullOrEmpty(filterQuery) Then
                    query &= " AND " & filterQuery
                End If

                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("@adminID", Login.adminID)
                    cmd.Parameters.AddWithValue("@role", "Student") ' Ensure the role is passed correctly
                    cmd.Parameters.AddWithValue("@filter", txtFilterStudent.Text)
                    ' Create a DataTable to hold the query results
                    Dim dt As New DataTable()

                    ' Fill the DataTable with data from the MySQL query
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using

                    ' Check if the DataTable has rows (users)
                    If dt.Rows.Count > 0 Then
                        ' Clear any existing data
                        dt.TableName = "PendingStudents"
                        'dt.WriteXmlSchema("C:\Users\HP\Desktop\StudentParentNotification-20241117T234955Z-001\StudentParentNotification\XML\ListStudent.xml")

                        Dim report As New PrintStudent
                        report.SummaryInfo.ReportTitle = "Student "
                        report.SetDataSource(dt)
                        Dim frmReport As New Print(report)
                        frmReport.ShowDialog()

                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnStudentCount_Click(sender As Object, e As EventArgs) Handles btnStudentCount.Click
        visibilityState = 3
        liststudent()
        visiblepanel()
    End Sub

    Private Sub btnSubadminCount_Click(sender As Object, e As EventArgs) Handles btnSubadminCount.Click
        visibilityState = 2
        visiblepanel()
        listSubadmin()
    End Sub

    Private Sub btnRecordCount_Click(sender As Object, e As EventArgs) Handles btnRecordCount.Click
        visibilityState = 1

        visiblepanel()
        listRecord()
    End Sub

    Private Sub pnlPendingStudents_Paint(sender As Object, e As PaintEventArgs) Handles pnlPendingStudents.Paint

    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Clipboard.SetText(txtCode.Text)
    End Sub

End Class