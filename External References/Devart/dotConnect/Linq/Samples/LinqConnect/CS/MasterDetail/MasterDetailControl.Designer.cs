namespace LinqDemo.MasterDetail {
  partial class MasterDetailControl {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterDetailControl));
      this.tsUpdate = new System.Windows.Forms.ToolStrip();
      this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
      this.bsOrders = new System.Windows.Forms.BindingSource(this.components);
      this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
      this.dgCustomer = new System.Windows.Forms.DataGridView();
      this.companyIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.companyNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.primaryContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.webDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.addressTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.regionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.countryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.faxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.primaryContactDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.companyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.webDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.splitMiddle = new System.Windows.Forms.Splitter();
      this.dgOrders = new System.Windows.Forms.DataGridView();
      this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.companyIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.contactIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.freightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shipDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.companyIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.contactIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.orderDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.freightDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shipDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shipCompanyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.discountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shippingCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.personContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tsUpdate.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bsOrders)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
      this.SuspendLayout();
      // 
      // tsUpdate
      // 
      this.tsUpdate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUpdate});
      this.tsUpdate.Location = new System.Drawing.Point(0, 0);
      this.tsUpdate.Name = "tsUpdate";
      this.tsUpdate.Size = new System.Drawing.Size(609, 25);
      this.tsUpdate.TabIndex = 8;
      // 
      // tsbUpdate
      // 
      this.tsbUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsbUpdate.Enabled = false;
      this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
      this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbUpdate.Name = "tsbUpdate";
      this.tsbUpdate.Size = new System.Drawing.Size(46, 22);
      this.tsbUpdate.Text = "Update";
      this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
      // 
      // bsOrders
      // 
      this.bsOrders.DataMember = "Company_Orders";
      this.bsOrders.DataSource = this.bsCustomers;
      this.bsOrders.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsOrders_ListChanged);
      // 
      // bsCustomers
      // 
      this.bsCustomers.DataSource = typeof(CrmDataContext.Company);
      // 
      // dgCustomer
      // 
      this.dgCustomer.AllowUserToResizeRows = false;
      this.dgCustomer.AutoGenerateColumns = false;
      this.dgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyIDDataGridViewTextBoxColumn3,
            this.companyNameDataGridViewTextBoxColumn1,
            this.primaryContactDataGridViewTextBoxColumn,
            this.webDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1,
            this.addressTitleDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn1,
            this.cityDataGridViewTextBoxColumn1,
            this.regionDataGridViewTextBoxColumn1,
            this.postalCodeDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn1,
            this.faxDataGridViewTextBoxColumn1,
            this.primaryContactDataGridViewTextBoxColumn1});
      this.dgCustomer.DataSource = this.bsCustomers;
      this.dgCustomer.Dock = System.Windows.Forms.DockStyle.Top;
      this.dgCustomer.Location = new System.Drawing.Point(0, 25);
      this.dgCustomer.MultiSelect = false;
      this.dgCustomer.Name = "dgCustomer";
      this.dgCustomer.RowHeadersWidth = 10;
      this.dgCustomer.Size = new System.Drawing.Size(609, 173);
      this.dgCustomer.TabIndex = 9;
      this.dgCustomer.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgOrders_DataError);
      // 
      // companyIDDataGridViewTextBoxColumn3
      // 
      this.companyIDDataGridViewTextBoxColumn3.DataPropertyName = "CompanyID";
      this.companyIDDataGridViewTextBoxColumn3.HeaderText = "CompanyID";
      this.companyIDDataGridViewTextBoxColumn3.Name = "companyIDDataGridViewTextBoxColumn3";
      // 
      // companyNameDataGridViewTextBoxColumn1
      // 
      this.companyNameDataGridViewTextBoxColumn1.DataPropertyName = "CompanyName";
      this.companyNameDataGridViewTextBoxColumn1.HeaderText = "CompanyName";
      this.companyNameDataGridViewTextBoxColumn1.Name = "companyNameDataGridViewTextBoxColumn1";
      // 
      // primaryContactDataGridViewTextBoxColumn
      // 
      this.primaryContactDataGridViewTextBoxColumn.DataPropertyName = "PrimaryContact";
      this.primaryContactDataGridViewTextBoxColumn.HeaderText = "PrimaryContact";
      this.primaryContactDataGridViewTextBoxColumn.Name = "primaryContactDataGridViewTextBoxColumn";
      // 
      // webDataGridViewTextBoxColumn1
      // 
      this.webDataGridViewTextBoxColumn1.DataPropertyName = "Web";
      this.webDataGridViewTextBoxColumn1.HeaderText = "Web";
      this.webDataGridViewTextBoxColumn1.Name = "webDataGridViewTextBoxColumn1";
      // 
      // emailDataGridViewTextBoxColumn1
      // 
      this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
      this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
      this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
      // 
      // addressTitleDataGridViewTextBoxColumn
      // 
      this.addressTitleDataGridViewTextBoxColumn.DataPropertyName = "AddressTitle";
      this.addressTitleDataGridViewTextBoxColumn.HeaderText = "AddressTitle";
      this.addressTitleDataGridViewTextBoxColumn.Name = "addressTitleDataGridViewTextBoxColumn";
      // 
      // addressDataGridViewTextBoxColumn1
      // 
      this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
      this.addressDataGridViewTextBoxColumn1.HeaderText = "Address";
      this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
      // 
      // cityDataGridViewTextBoxColumn1
      // 
      this.cityDataGridViewTextBoxColumn1.DataPropertyName = "City";
      this.cityDataGridViewTextBoxColumn1.HeaderText = "City";
      this.cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
      // 
      // regionDataGridViewTextBoxColumn1
      // 
      this.regionDataGridViewTextBoxColumn1.DataPropertyName = "Region";
      this.regionDataGridViewTextBoxColumn1.HeaderText = "Region";
      this.regionDataGridViewTextBoxColumn1.Name = "regionDataGridViewTextBoxColumn1";
      // 
      // postalCodeDataGridViewTextBoxColumn
      // 
      this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
      this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
      this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
      // 
      // countryDataGridViewTextBoxColumn1
      // 
      this.countryDataGridViewTextBoxColumn1.DataPropertyName = "Country";
      this.countryDataGridViewTextBoxColumn1.HeaderText = "Country";
      this.countryDataGridViewTextBoxColumn1.Name = "countryDataGridViewTextBoxColumn1";
      // 
      // phoneDataGridViewTextBoxColumn1
      // 
      this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone";
      this.phoneDataGridViewTextBoxColumn1.HeaderText = "Phone";
      this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
      // 
      // faxDataGridViewTextBoxColumn1
      // 
      this.faxDataGridViewTextBoxColumn1.DataPropertyName = "Fax";
      this.faxDataGridViewTextBoxColumn1.HeaderText = "Fax";
      this.faxDataGridViewTextBoxColumn1.Name = "faxDataGridViewTextBoxColumn1";
      // 
      // primaryContactDataGridViewTextBoxColumn1
      // 
      this.primaryContactDataGridViewTextBoxColumn1.DataPropertyName = "Primary_Contact";
      this.primaryContactDataGridViewTextBoxColumn1.HeaderText = "Primary_Contact";
      this.primaryContactDataGridViewTextBoxColumn1.Name = "primaryContactDataGridViewTextBoxColumn1";
      this.primaryContactDataGridViewTextBoxColumn1.Visible = false;
      // 
      // companyIDDataGridViewTextBoxColumn
      // 
      this.companyIDDataGridViewTextBoxColumn.DataPropertyName = "CompanyID";
      this.companyIDDataGridViewTextBoxColumn.HeaderText = "CompanyID";
      this.companyIDDataGridViewTextBoxColumn.Name = "companyIDDataGridViewTextBoxColumn";
      // 
      // companyNameDataGridViewTextBoxColumn
      // 
      this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
      this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
      this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
      // 
      // webDataGridViewTextBoxColumn
      // 
      this.webDataGridViewTextBoxColumn.DataPropertyName = "Web";
      this.webDataGridViewTextBoxColumn.HeaderText = "Web";
      this.webDataGridViewTextBoxColumn.Name = "webDataGridViewTextBoxColumn";
      // 
      // emailDataGridViewTextBoxColumn
      // 
      this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
      this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
      this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
      // 
      // addressDataGridViewTextBoxColumn
      // 
      this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
      this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
      this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
      // 
      // cityDataGridViewTextBoxColumn
      // 
      this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
      this.cityDataGridViewTextBoxColumn.HeaderText = "City";
      this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
      // 
      // regionDataGridViewTextBoxColumn
      // 
      this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
      this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
      this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
      // 
      // countryDataGridViewTextBoxColumn
      // 
      this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
      this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
      this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
      // 
      // phoneDataGridViewTextBoxColumn
      // 
      this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
      this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
      this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
      // 
      // faxDataGridViewTextBoxColumn
      // 
      this.faxDataGridViewTextBoxColumn.DataPropertyName = "Fax";
      this.faxDataGridViewTextBoxColumn.HeaderText = "Fax";
      this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
      // 
      // splitMiddle
      // 
      this.splitMiddle.Dock = System.Windows.Forms.DockStyle.Top;
      this.splitMiddle.Location = new System.Drawing.Point(0, 198);
      this.splitMiddle.Name = "splitMiddle";
      this.splitMiddle.Size = new System.Drawing.Size(609, 3);
      this.splitMiddle.TabIndex = 10;
      this.splitMiddle.TabStop = false;
      // 
      // dgOrders
      // 
      this.dgOrders.AutoGenerateColumns = false;
      this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn1,
            this.companyIDDataGridViewTextBoxColumn2,
            this.contactIDDataGridViewTextBoxColumn1,
            this.orderDateDataGridViewTextBoxColumn1,
            this.freightDataGridViewTextBoxColumn1,
            this.shipDateDataGridViewTextBoxColumn1,
            this.shipCompanyIDDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn1,
            this.companyDataGridViewTextBoxColumn,
            this.shippingCompanyDataGridViewTextBoxColumn,
            this.personContactDataGridViewTextBoxColumn});
      this.dgOrders.DataSource = this.bsOrders;
      this.dgOrders.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgOrders.Location = new System.Drawing.Point(0, 201);
      this.dgOrders.MultiSelect = false;
      this.dgOrders.Name = "dgOrders";
      this.dgOrders.RowHeadersWidth = 10;
      this.dgOrders.Size = new System.Drawing.Size(609, 121);
      this.dgOrders.TabIndex = 11;
      this.dgOrders.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgOrders_DataError);
      // 
      // orderIDDataGridViewTextBoxColumn
      // 
      this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
      this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
      this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
      // 
      // companyIDDataGridViewTextBoxColumn1
      // 
      this.companyIDDataGridViewTextBoxColumn1.DataPropertyName = "CompanyID";
      this.companyIDDataGridViewTextBoxColumn1.HeaderText = "CompanyID";
      this.companyIDDataGridViewTextBoxColumn1.Name = "companyIDDataGridViewTextBoxColumn1";
      // 
      // contactIDDataGridViewTextBoxColumn
      // 
      this.contactIDDataGridViewTextBoxColumn.DataPropertyName = "ContactID";
      this.contactIDDataGridViewTextBoxColumn.HeaderText = "ContactID";
      this.contactIDDataGridViewTextBoxColumn.Name = "contactIDDataGridViewTextBoxColumn";
      // 
      // orderDateDataGridViewTextBoxColumn
      // 
      this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
      this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
      this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
      // 
      // freightDataGridViewTextBoxColumn
      // 
      this.freightDataGridViewTextBoxColumn.DataPropertyName = "Freight";
      this.freightDataGridViewTextBoxColumn.HeaderText = "Freight";
      this.freightDataGridViewTextBoxColumn.Name = "freightDataGridViewTextBoxColumn";
      // 
      // shipDateDataGridViewTextBoxColumn
      // 
      this.shipDateDataGridViewTextBoxColumn.DataPropertyName = "ShipDate";
      this.shipDateDataGridViewTextBoxColumn.HeaderText = "ShipDate";
      this.shipDateDataGridViewTextBoxColumn.Name = "shipDateDataGridViewTextBoxColumn";
      // 
      // discountDataGridViewTextBoxColumn
      // 
      this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
      this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
      this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
      // 
      // orderIDDataGridViewTextBoxColumn1
      // 
      this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
      this.orderIDDataGridViewTextBoxColumn1.HeaderText = "OrderID";
      this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
      // 
      // companyIDDataGridViewTextBoxColumn2
      // 
      this.companyIDDataGridViewTextBoxColumn2.DataPropertyName = "CompanyID";
      this.companyIDDataGridViewTextBoxColumn2.HeaderText = "CompanyID";
      this.companyIDDataGridViewTextBoxColumn2.Name = "companyIDDataGridViewTextBoxColumn2";
      this.companyIDDataGridViewTextBoxColumn2.Visible = false;
      // 
      // contactIDDataGridViewTextBoxColumn1
      // 
      this.contactIDDataGridViewTextBoxColumn1.DataPropertyName = "ContactID";
      this.contactIDDataGridViewTextBoxColumn1.HeaderText = "ContactID";
      this.contactIDDataGridViewTextBoxColumn1.Name = "contactIDDataGridViewTextBoxColumn1";
      // 
      // orderDateDataGridViewTextBoxColumn1
      // 
      this.orderDateDataGridViewTextBoxColumn1.DataPropertyName = "OrderDate";
      this.orderDateDataGridViewTextBoxColumn1.HeaderText = "OrderDate";
      this.orderDateDataGridViewTextBoxColumn1.Name = "orderDateDataGridViewTextBoxColumn1";
      // 
      // freightDataGridViewTextBoxColumn1
      // 
      this.freightDataGridViewTextBoxColumn1.DataPropertyName = "Freight";
      this.freightDataGridViewTextBoxColumn1.HeaderText = "Freight";
      this.freightDataGridViewTextBoxColumn1.Name = "freightDataGridViewTextBoxColumn1";
      // 
      // shipDateDataGridViewTextBoxColumn1
      // 
      this.shipDateDataGridViewTextBoxColumn1.DataPropertyName = "ShipDate";
      this.shipDateDataGridViewTextBoxColumn1.HeaderText = "ShipDate";
      this.shipDateDataGridViewTextBoxColumn1.Name = "shipDateDataGridViewTextBoxColumn1";
      // 
      // shipCompanyIDDataGridViewTextBoxColumn
      // 
      this.shipCompanyIDDataGridViewTextBoxColumn.DataPropertyName = "ShipCompanyID";
      this.shipCompanyIDDataGridViewTextBoxColumn.HeaderText = "ShipCompanyID";
      this.shipCompanyIDDataGridViewTextBoxColumn.Name = "shipCompanyIDDataGridViewTextBoxColumn";
      // 
      // discountDataGridViewTextBoxColumn1
      // 
      this.discountDataGridViewTextBoxColumn1.DataPropertyName = "Discount";
      this.discountDataGridViewTextBoxColumn1.HeaderText = "Discount";
      this.discountDataGridViewTextBoxColumn1.Name = "discountDataGridViewTextBoxColumn1";
      // 
      // companyDataGridViewTextBoxColumn
      // 
      this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
      this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
      this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
      this.companyDataGridViewTextBoxColumn.Visible = false;
      // 
      // shippingCompanyDataGridViewTextBoxColumn
      // 
      this.shippingCompanyDataGridViewTextBoxColumn.DataPropertyName = "ShippingCompany";
      this.shippingCompanyDataGridViewTextBoxColumn.HeaderText = "ShippingCompany";
      this.shippingCompanyDataGridViewTextBoxColumn.Name = "shippingCompanyDataGridViewTextBoxColumn";
      this.shippingCompanyDataGridViewTextBoxColumn.Visible = false;
      // 
      // personContactDataGridViewTextBoxColumn
      // 
      this.personContactDataGridViewTextBoxColumn.DataPropertyName = "Person_Contact";
      this.personContactDataGridViewTextBoxColumn.HeaderText = "Person_Contact";
      this.personContactDataGridViewTextBoxColumn.Name = "personContactDataGridViewTextBoxColumn";
      this.personContactDataGridViewTextBoxColumn.Visible = false;
      // 
      // MasterDetailControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dgOrders);
      this.Controls.Add(this.splitMiddle);
      this.Controls.Add(this.dgCustomer);
      this.Controls.Add(this.tsUpdate);
      this.Name = "MasterDetailControl";
      this.Size = new System.Drawing.Size(609, 322);
      this.tsUpdate.ResumeLayout(false);
      this.tsUpdate.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bsOrders)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip tsUpdate;
    private System.Windows.Forms.ToolStripButton tsbUpdate;
    private System.Windows.Forms.BindingSource bsOrders;
    private System.Windows.Forms.BindingSource bsCustomers;
    private System.Windows.Forms.DataGridView dgCustomer;
    private System.Windows.Forms.DataGridViewTextBoxColumn companyIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn webDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
    private System.Windows.Forms.Splitter splitMiddle;
    private System.Windows.Forms.DataGridView dgOrders;
    private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn companyIDDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn contactIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn freightDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn shipDateDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn companyIDDataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn primaryContactDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn webDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn addressTitleDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn primaryContactDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn companyIDDataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn contactIDDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn freightDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn shipDateDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn shipCompanyIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn shippingCompanyDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn personContactDataGridViewTextBoxColumn;

  }
}
