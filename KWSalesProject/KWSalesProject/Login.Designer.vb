<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim UserTypeLabel As System.Windows.Forms.Label
        Me.KWSalesDBDataSet = New KWSalesProject.KWSalesDBDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New KWSalesProject.KWSalesDBDataSetTableAdapters.UsersTableAdapter()
        Me.TableAdapterManager = New KWSalesProject.KWSalesDBDataSetTableAdapters.TableAdapterManager()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UserTypeTextBox = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        UserNameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        UserTypeLabel = New System.Windows.Forms.Label()
        CType(Me.KWSalesDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(52, 48)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(83, 17)
        UserNameLabel.TabIndex = 1
        UserNameLabel.Text = "User Name:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(62, 101)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(73, 17)
        PasswordLabel.TabIndex = 3
        PasswordLabel.Text = "Password:"
        '
        'UserTypeLabel
        '
        UserTypeLabel.AutoSize = True
        UserTypeLabel.Location = New System.Drawing.Point(57, 154)
        UserTypeLabel.Name = "UserTypeLabel"
        UserTypeLabel.Size = New System.Drawing.Size(78, 17)
        UserTypeLabel.TabIndex = 5
        UserTypeLabel.Text = "User Type:"
        '
        'KWSalesDBDataSet
        '
        Me.KWSalesDBDataSet.DataSetName = "KWSalesDBDataSet"
        Me.KWSalesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.KWSalesDBDataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.OrdersTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.PurchasesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KWSalesProject.KWSalesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Me.UsersTableAdapter
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Location = New System.Drawing.Point(141, 45)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UserNameTextBox.TabIndex = 2
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(141, 98)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PasswordTextBox.TabIndex = 4
        '
        'UserTypeTextBox
        '
        Me.UserTypeTextBox.Location = New System.Drawing.Point(141, 151)
        Me.UserTypeTextBox.Name = "UserTypeTextBox"
        Me.UserTypeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.UserTypeTextBox.TabIndex = 6
        '
        'BtnLogin
        '
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Location = New System.Drawing.Point(237, 239)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 41)
        Me.BtnLogin.TabIndex = 7
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 326)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(UserTypeLabel)
        Me.Controls.Add(Me.UserTypeTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.KWSalesDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KWSalesDBDataSet As KWSalesDBDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As KWSalesDBDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents TableAdapterManager As KWSalesDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UserTypeTextBox As TextBox
    Friend WithEvents BtnLogin As Button
End Class
