Imports System.Configuration
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class addSubadmin
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyDatabaseConnectionString").ConnectionString
    Private isExistingUser As Boolean
    Private existingNumberEmail As Boolean
    Private role As String = "Subadmin"
    Private SubadminID As Integer = 0
    Public insert As Integer = 0
    Public EnableField As Boolean

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidateEntries() = True Then

            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    Dim query As String = "SELECT * FROM user WHERE logOnName = @logOnName AND adminID = @adminID AND role = @role"
                    Using cmd As New MySqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@logOnName", txtUsername.Text)
                        cmd.Parameters.AddWithValue("@adminID", Login.adminID)
                        cmd.Parameters.AddWithValue("@role", role)

                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            isExistingUser = reader.HasRows
                            If isExistingUser Then
                                reader.Read()
                                SubadminID = Convert.ToInt32(reader("userID"))
                            End If
                        End Using
                    End Using

                    Dim sqlquery As String = "SELECT * FROM user WHERE logOnName = @logOnName AND adminID = @adminID AND role = @role"
                    Using cmd As New MySqlCommand(sqlquery, connection)
                        cmd.Parameters.AddWithValue("@logOnName", txtUsername.Text)
                        cmd.Parameters.AddWithValue("@adminID", Login.adminID)
                        cmd.Parameters.AddWithValue("@role", role)

                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            existingNumberEmail = reader.HasRows
                           
                        End Using
                    End Using

                    Dim sql As String

                    If insert > 0 Then
                        If isExistingUser Then
                            MessageBox.Show("Username already exists. Please choose a different username.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Else



                            sql = "INSERT INTO user (firstName, lastName, middleName, role, email, phoneNumber, adminID, gender, logOnName, " &
                            "password, position) VALUES (@firstName, @lastName, @middleName, @role, @email, @phoneNumber, @adminID, " &
                            "@gender, @logOnName, @password, @position)"
                        End If



                    Else
                        sql = "UPDATE user SET firstName = @firstName, lastName = @lastName, middleName = @middleName, " &
                           "`role` = @role, email = @email, phoneNumber = @phoneNumber, adminID = @adminID, gender = @gender, " &
                            "logOnName = @logOnName, `password` = @password, position = @position " &
                            "WHERE adminID = @adminID AND userID = @userID"
                    End If

                    If isExistingUser Then


                    Else

                    End If

                    ' Begin a transaction for consistency
                    Using transaction = connection.BeginTransaction()
                        Try
                            Using cmd1 As New MySqlCommand(sql, connection, transaction)
                                AddUserParameters(cmd1)
                                cmd1.ExecuteNonQuery()
                                If Not isExistingUser Then
                                    SubadminID = cmd1.LastInsertedId ' Get the last inserted ID for new user
                                End If

                            End Using

                            If UsernameExists(txtUsername.Text) Then
                                MessageBox.Show("Username already exists. Please choose a different username.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                txtUsername.Focus()
                                Return ' Exit the event if the username already exists
                            End If

                            transaction.Commit()
                            MessageBox.Show("Save Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            enablefiled(False)
                            btnClose.Text = "Close"
                            btnEdit.Visible = True
                            btnEdit.Enabled = True
                            btnSave.Enabled = False
                            btnDelete.Enabled = True
                        Catch ex As Exception
                            transaction.Rollback()
                            Throw ' Re-throw exception to catch and handle it outside
                        End Try
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Database error during registration: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("An error occurred during registration: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function ValidateEntries() As Boolean
        If String.IsNullOrWhiteSpace(txtfName.Text) Then
            MessageBox.Show("Please enter First Name", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtfName.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Please enter Email", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmail.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtlName.Text) Then
            MessageBox.Show("Please enter Last Name", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtlName.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtmName.Text) Then
            MessageBox.Show("Please enter Middle Name", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtmName.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtMobile.Text) Then
            MessageBox.Show("Please enter Mobile Number", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMobile.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtPosition.Text) Then
            MessageBox.Show("Please enter Position ", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPosition.Focus()
            Return False

        End If

        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Please enter Username ", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsername.Focus()
            Return False

        End If
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter Password ", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPassword.Focus()
            Return False

        End If
        If String.IsNullOrWhiteSpace(cboGender.Text) Then
            MessageBox.Show("Please Select Gender ", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboGender.Focus()

        End If


        Dim emailPattern As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"

        If Not System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, emailPattern) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return False


        End If

        If Not IsNumeric(txtMobile.Text) OrElse txtMobile.Text.Length <> 11 OrElse Not txtMobile.Text.StartsWith("09") Then
            ' Display a warning if the input is invalid
            MessageBox.Show("Please enter a valid mobile number. It should be 11 digits and start with '09'.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMobile.Focus()
            Return False
        End If

        Return True
    End Function


    Private Sub AddUserParameters(cmd As MySqlCommand)
        cmd.Parameters.AddWithValue("@firstName", txtfName.Text)
        cmd.Parameters.AddWithValue("@lastName", txtlName.Text)
        cmd.Parameters.AddWithValue("@middleName", txtmName.Text)
        cmd.Parameters.AddWithValue("@role", role)
        cmd.Parameters.AddWithValue("@email", txtEmail.Text)
        cmd.Parameters.AddWithValue("@phoneNumber", txtMobile.Text)
        cmd.Parameters.AddWithValue("@adminID", Login.adminID)
        cmd.Parameters.AddWithValue("@gender", cboGender.Text)
        cmd.Parameters.AddWithValue("@position", txtPosition.Text)
        cmd.Parameters.AddWithValue("@logOnName", txtUsername.Text)
        cmd.Parameters.AddWithValue("@password", txtPassword.Text)
        cmd.Parameters.AddWithValue("@userID", SubadminID)
    End Sub

    Private Sub enablefiled(ByVal enable As Boolean)
        txtfName.Enabled = enable
        txtlName.Enabled = enable
        txtmName.Enabled = enable
        cboGender.Enabled = enable
        txtMobile.Enabled = enable

        If insert > 0 Then
            txtUsername.Enabled = enable
        End If

        txtPassword.Enabled = enable
        txtPosition.Enabled = enable
        txtEmail.Enabled = enable
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        enablefiled(True)
        btnClose.Text = "Cancel"
        btnSave.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If btnClose.Text = "Close" Then
            Me.Close()
        Else
            enablefiled(False)
            btnClose.Text = "Close"
            btnSave.Enabled = False
        End If
    End Sub

    Private Function UsernameExists(username As String) As Boolean
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT COUNT(*) FROM user WHERE logOnName = @logOnName AND userID <> @userID and role =  @role"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@logOnName", username)
                cmd.Parameters.AddWithValue("@userID", SubadminID)
                cmd.Parameters.AddWithValue("@role", role)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub addSubadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enablefiled(EnableField)
    End Sub

    Private Sub txtMobile_TextChanged(sender As Object, e As EventArgs) Handles txtMobile.TextChanged

    End Sub

    Private Sub txtMobile_LostFocus(sender As Object, e As EventArgs) Handles txtMobile.LostFocus

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs) Handles txtEmail.LostFocus

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Show confirmation dialog before proceeding with deletion
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check if the user clicked 'Yes'
        If result = DialogResult.Yes Then
            ' Proceed with deletion if 'Yes' was clicked
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Correct DELETE SQL query
                Dim sqlquery As String = "DELETE FROM user WHERE logOnName = @logOnName AND adminID = @adminID AND role = @role"

                Using cmd As New MySqlCommand(sqlquery, connection)
                    ' Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@logOnName", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@adminID", Login.adminID)
                    cmd.Parameters.AddWithValue("@role", role)

                    ' Execute the DELETE command
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Check if any row was affected (deleted)
                    If rowsAffected > 0 Then
                        MessageBox.Show("User deleted successfully.")
                        Me.Close()
                    Else
                        MessageBox.Show("User not found or deletion failed.")
                    End If
                End Using
            End Using
        Else
            ' If 'No' is clicked, do nothing or show a cancel message
            MessageBox.Show("Deletion canceled.")
        End If
    End Sub


End Class
