<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterDetailControl
  Inherits LinqDemo.BaseControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterDetailControl))
        Me.dgOrders = New System.Windows.Forms.DataGridView
        Me.bsOrders = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.splitMiddle = New System.Windows.Forms.Splitter
        Me.tsUpdate = New System.Windows.Forms.ToolStrip
        Me.tsbUpdate = New System.Windows.Forms.ToolStripButton
        Me.dgCustomer = New System.Windows.Forms.DataGridView
        Me.CompanyIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CompanyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrimaryContact = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WebDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AddressTitle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RegionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PostalCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Primary_Contact = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.orderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.companyIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.contactIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.orderDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.freightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.shipDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShipCompanyID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.discountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsUpdate.SuspendLayout()
        CType(Me.dgCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgOrders
        '
        Me.dgOrders.AutoGenerateColumns = False
        Me.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.orderIDDataGridViewTextBoxColumn, Me.companyIDDataGridViewTextBoxColumn1, Me.contactIDDataGridViewTextBoxColumn, Me.orderDateDataGridViewTextBoxColumn, Me.freightDataGridViewTextBoxColumn, Me.shipDateDataGridViewTextBoxColumn, Me.ShipCompanyID, Me.discountDataGridViewTextBoxColumn})
        Me.dgOrders.DataSource = Me.bsOrders
        Me.dgOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOrders.Location = New System.Drawing.Point(0, 201)
        Me.dgOrders.MultiSelect = False
        Me.dgOrders.Name = "dgOrders"
        Me.dgOrders.RowHeadersWidth = 10
        Me.dgOrders.Size = New System.Drawing.Size(609, 121)
        Me.dgOrders.TabIndex = 15
        '
        'bsOrders
        '
        Me.bsOrders.DataMember = "Company_Orders"
        Me.bsOrders.DataSource = Me.bsCustomers
        '
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(LinqDemo.CrmDataContext.Company)
        '
        'splitMiddle
        '
        Me.splitMiddle.Dock = System.Windows.Forms.DockStyle.Top
        Me.splitMiddle.Location = New System.Drawing.Point(0, 198)
        Me.splitMiddle.Name = "splitMiddle"
        Me.splitMiddle.Size = New System.Drawing.Size(609, 3)
        Me.splitMiddle.TabIndex = 14
        Me.splitMiddle.TabStop = False
        '
        'tsUpdate
        '
        Me.tsUpdate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbUpdate})
        Me.tsUpdate.Location = New System.Drawing.Point(0, 0)
        Me.tsUpdate.Name = "tsUpdate"
        Me.tsUpdate.Size = New System.Drawing.Size(609, 25)
        Me.tsUpdate.TabIndex = 12
        '
        'tsbUpdate
        '
        Me.tsbUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbUpdate.Image = CType(resources.GetObject("tsbUpdate.Image"), System.Drawing.Image)
        Me.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbUpdate.Name = "tsbUpdate"
        Me.tsbUpdate.Size = New System.Drawing.Size(46, 22)
        Me.tsbUpdate.Text = "Update"
        '
        'dgCustomer
        '
        Me.dgCustomer.AllowUserToResizeRows = False
        Me.dgCustomer.AutoGenerateColumns = False
        Me.dgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CompanyIDDataGridViewTextBoxColumn, Me.CompanyNameDataGridViewTextBoxColumn, Me.PrimaryContact, Me.WebDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.AddressTitle, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.RegionDataGridViewTextBoxColumn, Me.PostalCode, Me.CountryDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.FaxDataGridViewTextBoxColumn, Me.Primary_Contact})
        Me.dgCustomer.DataSource = Me.bsCustomers
        Me.dgCustomer.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgCustomer.Location = New System.Drawing.Point(0, 25)
        Me.dgCustomer.MultiSelect = False
        Me.dgCustomer.Name = "dgCustomer"
        Me.dgCustomer.RowHeadersWidth = 10
        Me.dgCustomer.Size = New System.Drawing.Size(609, 173)
        Me.dgCustomer.TabIndex = 13
        '
        'CompanyIDDataGridViewTextBoxColumn
        '
        Me.CompanyIDDataGridViewTextBoxColumn.DataPropertyName = "CompanyID"
        Me.CompanyIDDataGridViewTextBoxColumn.HeaderText = "CompanyID"
        Me.CompanyIDDataGridViewTextBoxColumn.Name = "CompanyIDDataGridViewTextBoxColumn"
        '
        'CompanyNameDataGridViewTextBoxColumn
        '
        Me.CompanyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName"
        Me.CompanyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName"
        Me.CompanyNameDataGridViewTextBoxColumn.Name = "CompanyNameDataGridViewTextBoxColumn"
        '
        'PrimaryContact
        '
        Me.PrimaryContact.DataPropertyName = "PrimaryContact"
        Me.PrimaryContact.HeaderText = "PrimaryContact"
        Me.PrimaryContact.Name = "PrimaryContact"
        '
        'WebDataGridViewTextBoxColumn
        '
        Me.WebDataGridViewTextBoxColumn.DataPropertyName = "Web"
        Me.WebDataGridViewTextBoxColumn.HeaderText = "Web"
        Me.WebDataGridViewTextBoxColumn.Name = "WebDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'AddressTitle
        '
        Me.AddressTitle.DataPropertyName = "AddressTitle"
        Me.AddressTitle.HeaderText = "AddressTitle"
        Me.AddressTitle.Name = "AddressTitle"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'RegionDataGridViewTextBoxColumn
        '
        Me.RegionDataGridViewTextBoxColumn.DataPropertyName = "Region"
        Me.RegionDataGridViewTextBoxColumn.HeaderText = "Region"
        Me.RegionDataGridViewTextBoxColumn.Name = "RegionDataGridViewTextBoxColumn"
        '
        'PostalCode
        '
        Me.PostalCode.DataPropertyName = "PostalCode"
        Me.PostalCode.HeaderText = "PostalCode"
        Me.PostalCode.Name = "PostalCode"
        '
        'CountryDataGridViewTextBoxColumn
        '
        Me.CountryDataGridViewTextBoxColumn.DataPropertyName = "Country"
        Me.CountryDataGridViewTextBoxColumn.HeaderText = "Country"
        Me.CountryDataGridViewTextBoxColumn.Name = "CountryDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'FaxDataGridViewTextBoxColumn
        '
        Me.FaxDataGridViewTextBoxColumn.DataPropertyName = "Fax"
        Me.FaxDataGridViewTextBoxColumn.HeaderText = "Fax"
        Me.FaxDataGridViewTextBoxColumn.Name = "FaxDataGridViewTextBoxColumn"
        '
        'Primary_Contact
        '
        Me.Primary_Contact.DataPropertyName = "Primary_Contact"
        Me.Primary_Contact.HeaderText = "Primary_Contact"
        Me.Primary_Contact.Name = "Primary_Contact"
        Me.Primary_Contact.Visible = False
        '
        'orderIDDataGridViewTextBoxColumn
        '
        Me.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID"
        Me.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID"
        Me.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn"
        '
        'companyIDDataGridViewTextBoxColumn1
        '
        Me.companyIDDataGridViewTextBoxColumn1.DataPropertyName = "CompanyID"
        Me.companyIDDataGridViewTextBoxColumn1.HeaderText = "CompanyID"
        Me.companyIDDataGridViewTextBoxColumn1.Name = "companyIDDataGridViewTextBoxColumn1"
        '
        'contactIDDataGridViewTextBoxColumn
        '
        Me.contactIDDataGridViewTextBoxColumn.DataPropertyName = "ContactID"
        Me.contactIDDataGridViewTextBoxColumn.HeaderText = "ContactID"
        Me.contactIDDataGridViewTextBoxColumn.Name = "contactIDDataGridViewTextBoxColumn"
        '
        'orderDateDataGridViewTextBoxColumn
        '
        Me.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate"
        Me.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate"
        Me.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn"
        '
        'freightDataGridViewTextBoxColumn
        '
        Me.freightDataGridViewTextBoxColumn.DataPropertyName = "Freight"
        Me.freightDataGridViewTextBoxColumn.HeaderText = "Freight"
        Me.freightDataGridViewTextBoxColumn.Name = "freightDataGridViewTextBoxColumn"
        '
        'shipDateDataGridViewTextBoxColumn
        '
        Me.shipDateDataGridViewTextBoxColumn.DataPropertyName = "ShipDate"
        Me.shipDateDataGridViewTextBoxColumn.HeaderText = "ShipDate"
        Me.shipDateDataGridViewTextBoxColumn.Name = "shipDateDataGridViewTextBoxColumn"
        '
        'ShipCompanyID
        '
        Me.ShipCompanyID.DataPropertyName = "ShipCompanyID"
        Me.ShipCompanyID.HeaderText = "ShipCompanyID"
        Me.ShipCompanyID.Name = "ShipCompanyID"
        '
        'discountDataGridViewTextBoxColumn
        '
        Me.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount"
        Me.discountDataGridViewTextBoxColumn.HeaderText = "Discount"
        Me.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn"
        '
        'MasterDetailControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgOrders)
        Me.Controls.Add(Me.splitMiddle)
        Me.Controls.Add(Me.dgCustomer)
        Me.Controls.Add(Me.tsUpdate)
        Me.Name = "MasterDetailControl"
        Me.Size = New System.Drawing.Size(609, 322)
        CType(Me.dgOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsUpdate.ResumeLayout(False)
        Me.tsUpdate.PerformLayout()
        CType(Me.dgCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Private WithEvents dgOrders As System.Windows.Forms.DataGridView
    Private WithEvents bsOrders As System.Windows.Forms.BindingSource
  Private WithEvents bsCustomers As System.Windows.Forms.BindingSource
  Private WithEvents splitMiddle As System.Windows.Forms.Splitter
  Private WithEvents tsUpdate As System.Windows.Forms.ToolStrip
  Private WithEvents tsbUpdate As System.Windows.Forms.ToolStripButton
  Private WithEvents dgCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents PrimarycontactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddresstitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PostalcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents orderIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents companyIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contactIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents orderDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents freightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents shipDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipCompanyID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrimaryContact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WebDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PostalCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Primary_Contact As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
