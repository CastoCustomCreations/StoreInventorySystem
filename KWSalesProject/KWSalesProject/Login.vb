Public Class Login
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KWSalesDBDataSet)

    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KWSalesDBDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.KWSalesDBDataSet.Users)

    End Sub
    Public Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If PasswordTextBox.Text = "" Or UserNameTextBox.Text = "" Or UserTypeTextBox.Text = "" Then
            MessageBox.Show("Please enter your username and password", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            UserNameTextBox.Focus()
            Exit Sub
        End If

        'Connect to the Database

        Dim connection As New OleDb.OleDbConnection

        connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\AdvancedVisualBasics\KWSalesProject\KWSalesProject\KWSalesProject\KWSalesDB.mdb"


        'Assign values to variables
        Dim strUser, strPass, strU, strP, strLevel, strL As String
        strUser = Me.UserNameTextBox.Text
        strPass = Me.PasswordTextBox.Text
        strLevel = Me.UserTypeTextBox.Text

        'build sql command


        Dim sqlCommand As String = "SELECT * FROM Users WHERE UserName like '" & strUser & "' AND Password like '" & strPass & "'"
        Dim selectCommand As New OleDb.OleDbCommand(sqlCommand, connection)


        'open connection
        Try
            connection.Open()
            Dim myReader As OleDb.OleDbDataReader = selectCommand.ExecuteReader


            Do While myReader.Read
                strU = myReader("UserName").ToString
                strP = myReader("Password").ToString
                'grab the level of the user
                strL = myReader("UserType").ToString
                'See if username and password exist in table
                If strUser = strU And strPass = strP And strLevel = strL Then
                    'Dim GlobalUL As String
                    'GlobalUL = strL
                    'Login Successful
                    Me.Hide()
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    MainMenu.Show()
                    'close login--change properties so last form that closes also closes program
                    Me.Close()

                    Exit Sub
                End If

            Loop


            'Login Unsuccessful
            MessageBox.Show("Either your username or password was incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        Catch ex As Exception
            'error connecting to database
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub



End Class
