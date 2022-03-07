Public Class Customers
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        'one method to clear all textboxes without listing each one
        For Each objItem In Me.Controls
            If TypeOf objItem Is TextBox Then
                objItem.Text = ""
            End If

        Next

        FirstNameTextBox.Focus()    'put cursor in first name text box

    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click

            'ensure data is complete If not, prompt user to fix--prevent submitting until all is well
            'this is one way to deal with the issues--there are many other approaches--try playing with ErrorProvider

            Dim blnError As Boolean   'to see if there are errors--you could also use exit sub in each if to prevent data from being accepted

            blnError = False     'starts out with no errors
            'first name
            If FirstNameTextBox.TextLength < 3 Then
                MessageBox.Show("You need at least 3 characters in first name", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                blnError = True
            End If

            'last name
            If LastNameTextBox.TextLength < 3 Then
                MessageBox.Show("You need at least 3 characters in last name", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                blnError = True
            End If

            'zip code--must be 5 numbers
            Dim intZip As Integer
            Integer.TryParse(ZipTextBox.Text, intZip)
            If intZip <> 0 Then

                If ZipTextBox.TextLength <> 5 Then
                    MessageBox.Show("You need 5 numbers in zip code", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    blnError = True
                End If
            Else
                'not numeric
                MessageBox.Show("You need 5 numbers in zip code", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                blnError = True
            End If

            If blnError = False Then    'no errors

                'one method to clear all textboxes without listing each one
                MessageBox.Show("Data has been submitted", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' btnClear_Click(Me, e)

            Else
                MessageBox.Show("There are problems with the data. Please fix then try again", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub

        Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
            Me.Close()

        End Sub

        Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comt21005DataSet.customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.KWSalesDBDataSet.Customers)
        'TODO: This line of code loads data into the 'KWSalesDBDataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.KWSalesDBDataSet.Orders)

        ' If GlobalUL = "User" Then
        'Me.BackColor = Color.CornflowerBlue
        'Me.LblUser.Visible = True
        'DeleteItem.Enabled = False
        'BtnSave.Enabled = False
        'BtnEnter.Enabled = False
        'End If
    End Sub

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs) Handles CustomersBindingNavigator.RefreshItems

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Try
                Me.Validate()     'system generic validate code
                BtnEnter.PerformClick() 'run the validation code we created before
            Me.CustomersBindingSource.EndEdit()
            Me.CustomersTableAdapter.Update(Me.KWSalesDBDataSet.Customers)
            Me.CustomersBindingSource.ResumeBinding()
            MessageBox.Show("Data Saved", "customer data")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Cannot save")
            End Try

        End Sub

        Private Sub AddNewItem_Click(sender As Object, e As EventArgs) Handles AddNewItem.Click

        End Sub

        Private Sub DeleteItem_Click(sender As Object, e As EventArgs) Handles DeleteItem.Click


        End Sub
    End Class
'            
