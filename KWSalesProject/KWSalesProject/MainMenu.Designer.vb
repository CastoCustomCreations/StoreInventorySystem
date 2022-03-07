<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnCustomers = New System.Windows.Forms.Button()
        Me.BtnInventory = New System.Windows.Forms.Button()
        Me.BtnOrders = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCustomers
        '
        Me.BtnCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCustomers.Location = New System.Drawing.Point(69, 125)
        Me.BtnCustomers.Name = "BtnCustomers"
        Me.BtnCustomers.Size = New System.Drawing.Size(157, 53)
        Me.BtnCustomers.TabIndex = 0
        Me.BtnCustomers.Text = "Customers"
        Me.BtnCustomers.UseVisualStyleBackColor = True
        '
        'BtnInventory
        '
        Me.BtnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInventory.Location = New System.Drawing.Point(300, 125)
        Me.BtnInventory.Name = "BtnInventory"
        Me.BtnInventory.Size = New System.Drawing.Size(157, 53)
        Me.BtnInventory.TabIndex = 1
        Me.BtnInventory.Text = "Inventory"
        Me.BtnInventory.UseVisualStyleBackColor = True
        '
        'BtnOrders
        '
        Me.BtnOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOrders.Location = New System.Drawing.Point(69, 234)
        Me.BtnOrders.Name = "BtnOrders"
        Me.BtnOrders.Size = New System.Drawing.Size(157, 53)
        Me.BtnOrders.TabIndex = 2
        Me.BtnOrders.Text = "Orders"
        Me.BtnOrders.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 390)
        Me.Controls.Add(Me.BtnOrders)
        Me.Controls.Add(Me.BtnInventory)
        Me.Controls.Add(Me.BtnCustomers)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCustomers As Button
    Friend WithEvents BtnInventory As Button
    Friend WithEvents BtnOrders As Button
End Class
