Imports System.Configuration
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Public Class verificationPassword
    ' Retrieve connection string from config file
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyDatabaseConnectionString").ConnectionString

    Public userName As String = Login.username
    Private Sub verificationPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Focus()

    End Sub

    Private Function ValidateEntries() As Boolean


        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter Password", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPassword.Focus()
            Return False
        End If

        Return True
    End Function

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
                        cmd.Parameters.AddWithValue("@logOnName", userName)
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text)

                        ' Execute the command and use a reader to get the result
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                ' Retrieve the user ID from the row without Convert.ToInt32


                                ' Display success message and open new form
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Dim form As New DashBoardAdmin




                                form.Show()
                                Me.Hide()
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

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub
End Class