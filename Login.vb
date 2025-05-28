Imports System.Configuration
Imports MySql.Data.MySqlClient


Public Class Login
    Public userID As Integer = 0
    Public username As String = ""
    Public role As String = ""
    Public password As String = ""
    Public code As String = ""
    Public email As String = ""
    Public number As String = ""
    Public firstname As String = ""
    Public middlename As String = ""
    Public lastname As String = ""
    Public gender As String = ""
    Public adminID As Integer = 0
    ' Retrieve connection string from config file
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyDatabaseConnectionString").ConnectionString

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Click
        txtUsername.Focus()

        ' Optional: Any form initialization code
    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtUsername.Focus()
    End Sub

    Private Function ValidateEntries() As Boolean
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Please enter Username", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsername.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter Password", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPassword.Focus()
            Return False
        End If

        Return True
    End Function

    Public Sub ConnectToDatabase()
        ' Test connection separately
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to connect to the database. Error: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validate user input
        If ValidateEntries() = True Then
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' Prepare SQL query with parameterized inputs
                    Dim query As String = "SELECT * FROM user WHERE logOnName = @logOnName AND password = @password"
                    Using cmd As New MySqlCommand(query, connection)
                        ' Use parameterized query to prevent SQL injection
                        cmd.Parameters.AddWithValue("@logOnName", txtUsername.Text)
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text)

                        ' Execute the command and use a reader to get the result
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                ' Retrieve the user ID from the row without Convert.ToInt32
                                userID = reader("userID") ' MySQL returns it as a native type
                                username = reader("logOnName")
                                role = reader("role")
                                password = reader("password")

                                If Not IsDBNull(reader("code")) Then

                                    code = reader("code")
                                End If
                                gender = reader("gender")
                                number = reader("phoneNumber")
                                email = reader("email")
                                firstname = reader("firstName")
                                middlename = reader("middleName")
                                lastname = reader("lastName")

                                If role = "Admin" Then
                                    adminID = userID
                                Else
                                    adminID = reader("adminID")
                                End If

                                If role = "Admin" Or role = "Subadmin" Then
                                    ' Display success message and open new form
                                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Dim form As New StudentInAndOut



                                    form.Show()
                                    Me.Hide()
                                Else
                                    MessageBox.Show("you Dont have Permission here", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If

                            Else
                                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                txtPassword.Focus()

                            End If
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error during login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub
End Class
