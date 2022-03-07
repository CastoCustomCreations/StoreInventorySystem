Public Class MainMenu
    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        Dim admin As New Customers
        admin.Show()
        Me.Hide()
        Dim user As New Customers
        user.Show()
        Me.Hide()
    End Sub

    Private Sub BtnInventory_Click(sender As Object, e As EventArgs) Handles BtnInventory.Click
        Dim admin As New Inventory
        admin.Show()
        Me.Hide()
        Dim user As New Inventory
        user.Show()
        Me.Hide()
    End Sub

    Private Sub BtnOrders_Click(sender As Object, e As EventArgs) Handles BtnOrders.Click
        Dim admin As New OrderForm
        admin.Show()
        Me.Hide()
        Dim user As New OrderForm
        user.Show()
        Me.Hide()
    End Sub
End Class