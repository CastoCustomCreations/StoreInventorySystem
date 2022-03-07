<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
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
        Dim CustomerIDLabel1 As System.Windows.Forms.Label
        Dim FirstNameLabel1 As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customers))
        Me.KWSalesDBDataSet = New KWSalesProject.KWSalesDBDataSet()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New KWSalesProject.KWSalesDBDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New KWSalesProject.KWSalesDBDataSetTableAdapters.TableAdapterManager()
        Me.OrdersTableAdapter = New KWSalesProject.KWSalesDBDataSetTableAdapters.OrdersTableAdapter()
        Me.CustomersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.DeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomerIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersOrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnEnter = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.LblUser = New System.Windows.Forms.Label()
        CustomerIDLabel1 = New System.Windows.Forms.Label()
        FirstNameLabel1 = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipLabel = New System.Windows.Forms.Label()
        CType(Me.KWSalesDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomersBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersOrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerIDLabel1
        '
        CustomerIDLabel1.AutoSize = True
        CustomerIDLabel1.Location = New System.Drawing.Point(61, 73)
        CustomerIDLabel1.Name = "CustomerIDLabel1"
        CustomerIDLabel1.Size = New System.Drawing.Size(89, 17)
        CustomerIDLabel1.TabIndex = 5
        CustomerIDLabel1.Text = "Customer ID:"
        '
        'FirstNameLabel1
        '
        FirstNameLabel1.AutoSize = True
        FirstNameLabel1.Location = New System.Drawing.Point(61, 101)
        FirstNameLabel1.Name = "FirstNameLabel1"
        FirstNameLabel1.Size = New System.Drawing.Size(80, 17)
        FirstNameLabel1.TabIndex = 7
        FirstNameLabel1.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(61, 129)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(80, 17)
        LastNameLabel.TabIndex = 9
        LastNameLabel.Text = "Last Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(61, 157)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(64, 17)
        AddressLabel.TabIndex = 11
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(61, 185)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(35, 17)
        CityLabel.TabIndex = 13
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(61, 213)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(45, 17)
        StateLabel.TabIndex = 15
        StateLabel.Text = "State:"
        '
        'ZipLabel
        '
        ZipLabel.AutoSize = True
        ZipLabel.Location = New System.Drawing.Point(61, 241)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(32, 17)
        ZipLabel.TabIndex = 17
        ZipLabel.Text = "Zip:"
        '
        'KWSalesDBDataSet
        '
        Me.KWSalesDBDataSet.DataSetName = "KWSalesDBDataSet"
        Me.KWSalesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.KWSalesDBDataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.OrdersTableAdapter = Me.OrdersTableAdapter
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.PurchasesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KWSalesProject.KWSalesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'CustomersBindingNavigator
        '
        Me.CustomersBindingNavigator.AddNewItem = Me.AddNewItem
        Me.CustomersBindingNavigator.BindingSource = Me.CustomersBindingSource
        Me.CustomersBindingNavigator.CountItem = Nothing
        Me.CustomersBindingNavigator.DeleteItem = Me.DeleteItem
        Me.CustomersBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CustomersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator, Me.BindingNavigatorSeparator1, Me.BindingNavigatorSeparator2, Me.AddNewItem, Me.DeleteItem})
        Me.CustomersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomersBindingNavigator.MoveFirstItem = Nothing
        Me.CustomersBindingNavigator.MoveLastItem = Nothing
        Me.CustomersBindingNavigator.MoveNextItem = Nothing
        Me.CustomersBindingNavigator.MovePreviousItem = Nothing
        Me.CustomersBindingNavigator.Name = "CustomersBindingNavigator"
        Me.CustomersBindingNavigator.PositionItem = Nothing
        Me.CustomersBindingNavigator.Size = New System.Drawing.Size(920, 27)
        Me.CustomersBindingNavigator.TabIndex = 0
        Me.CustomersBindingNavigator.Text = "BindingNavigator1"
        '
        'AddNewItem
        '
        Me.AddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddNewItem.Image = CType(resources.GetObject("AddNewItem.Image"), System.Drawing.Image)
        Me.AddNewItem.Name = "AddNewItem"
        Me.AddNewItem.RightToLeftAutoMirrorImage = True
        Me.AddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.AddNewItem.Text = "Add new"
        '
        'DeleteItem
        '
        Me.DeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteItem.Image = CType(resources.GetObject("DeleteItem.Image"), System.Drawing.Image)
        Me.DeleteItem.Name = "DeleteItem"
        Me.DeleteItem.RightToLeftAutoMirrorImage = True
        Me.DeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.DeleteItem.Text = "Delete"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'CustomerIDTextBox1
        '
        Me.CustomerIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox1.Location = New System.Drawing.Point(156, 70)
        Me.CustomerIDTextBox1.Name = "CustomerIDTextBox1"
        Me.CustomerIDTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.CustomerIDTextBox1.TabIndex = 6
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(156, 98)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.FirstNameTextBox.TabIndex = 8
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(156, 126)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.LastNameTextBox.TabIndex = 10
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(156, 154)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AddressTextBox.TabIndex = 12
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(156, 182)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CityTextBox.TabIndex = 14
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(156, 210)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.StateTextBox.TabIndex = 16
        '
        'ZipTextBox
        '
        Me.ZipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Zip", True))
        Me.ZipTextBox.Location = New System.Drawing.Point(156, 238)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ZipTextBox.TabIndex = 18
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.ZipDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomersBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(294, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(575, 150)
        Me.DataGridView1.TabIndex = 19
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.Width = 125
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.Width = 125
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.Width = 125
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.Width = 125
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.Width = 125
        '
        'ZipDataGridViewTextBoxColumn
        '
        Me.ZipDataGridViewTextBoxColumn.DataPropertyName = "Zip"
        Me.ZipDataGridViewTextBoxColumn.HeaderText = "Zip"
        Me.ZipDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ZipDataGridViewTextBoxColumn.Name = "ZipDataGridViewTextBoxColumn"
        Me.ZipDataGridViewTextBoxColumn.Width = 125
        '
        'CustomersBindingSource1
        '
        Me.CustomersBindingSource1.DataMember = "Customers"
        Me.CustomersBindingSource1.DataSource = Me.KWSalesDBDataSet
        '
        'CustomersOrdersBindingSource
        '
        Me.CustomersOrdersBindingSource.DataMember = "CustomersOrders"
        Me.CustomersOrdersBindingSource.DataSource = Me.CustomersBindingSource
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(294, 288)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 33)
        Me.BtnClear.TabIndex = 20
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnEnter
        '
        Me.BtnEnter.Location = New System.Drawing.Point(395, 288)
        Me.BtnEnter.Name = "BtnEnter"
        Me.BtnEnter.Size = New System.Drawing.Size(75, 33)
        Me.BtnEnter.TabIndex = 21
        Me.BtnEnter.Text = "Enter"
        Me.BtnEnter.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(510, 288)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 33)
        Me.BtnExit.TabIndex = 22
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(621, 288)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 33)
        Me.BtnSave.TabIndex = 23
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.Location = New System.Drawing.Point(425, 9)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(74, 32)
        Me.LblUser.TabIndex = 24
        Me.LblUser.Text = "User"
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 402)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnEnter)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(CustomerIDLabel1)
        Me.Controls.Add(Me.CustomerIDTextBox1)
        Me.Controls.Add(FirstNameLabel1)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(ZipLabel)
        Me.Controls.Add(Me.ZipTextBox)
        Me.Controls.Add(Me.CustomersBindingNavigator)
        Me.Name = "Customers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customers"
        CType(Me.KWSalesDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomersBindingNavigator.ResumeLayout(False)
        Me.CustomersBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersOrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KWSalesDBDataSet As KWSalesDBDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As KWSalesDBDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As KWSalesDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomersBindingNavigator As BindingNavigator
    Friend WithEvents AddNewItem As ToolStripButton
    Friend WithEvents DeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents OrdersTableAdapter As KWSalesDBDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents CustomerIDTextBox1 As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CustomersOrdersBindingSource As BindingSource
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomersBindingSource1 As BindingSource
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnEnter As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents LblUser As Label
End Class
