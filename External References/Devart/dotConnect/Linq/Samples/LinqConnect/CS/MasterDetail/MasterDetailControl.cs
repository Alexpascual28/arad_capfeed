using System.Linq;
using System;
using System.Windows.Forms;

namespace LinqDemo.MasterDetail {

  public partial class MasterDetailControl : BaseControl {

    public MasterDetailControl()
      : base("MasterDetail") {
      InitializeComponent();
    }

    internal override event EventHandler UpdateChanged;

    internal override void OpenClick() {

      var companies = from c in crmDataContext.Companies
                      select c;

      bsCustomers.DataSource = companies;
      base.OpenClick();
    }

    internal override void CloseClick() {

      bsCustomers.DataSource = typeof(CrmDataContext.Company);
      base.CloseClick();
    }

    internal override void ControlsEnabled(bool state) {

      tsbUpdate.Enabled = state;
      if (state) {
        if (dgCustomer.Columns.Count != 0 || dgOrders.Columns.Count != 0)
          return;
        dgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            companyIDDataGridViewTextBoxColumn,
            companyNameDataGridViewTextBoxColumn,
            webDataGridViewTextBoxColumn,
            emailDataGridViewTextBoxColumn,
            addressDataGridViewTextBoxColumn,
            cityDataGridViewTextBoxColumn,
            regionDataGridViewTextBoxColumn,
            countryDataGridViewTextBoxColumn,
            phoneDataGridViewTextBoxColumn,
            faxDataGridViewTextBoxColumn});

        dgOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            orderIDDataGridViewTextBoxColumn,
            companyIDDataGridViewTextBoxColumn1,
            contactIDDataGridViewTextBoxColumn,
            orderDateDataGridViewTextBoxColumn,
            freightDataGridViewTextBoxColumn,
            shipDateDataGridViewTextBoxColumn,
            discountDataGridViewTextBoxColumn});
      }
      else {
        dgCustomer.CancelEdit();
        dgOrders.CancelEdit();
        dgCustomer.Columns.Clear();
        dgOrders.Columns.Clear();
      }
    }

    private void tsbUpdate_Click(object sender, System.EventArgs e) {

      try {
        if (crmDataContext != null) {
          crmDataContext.SubmitChanges();
          if (UpdateChanged != null)
            UpdateChanged("Updated", null);
          }
      }
      catch (Exception ex) {
        MessageBox.Show(ex.Message, MainForm.SampleName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        UpdateChanged("Update failed", null);
      }
    }

    private void bsOrders_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e) {

      if (e.ListChangedType == System.ComponentModel.ListChangedType.ItemChanged && e.PropertyDescriptor.Name == "Company") {
        CrmDataContext.Order curentOrder = (CrmDataContext.Order)bsOrders.List[e.NewIndex];
        if (curentOrder.Company == null)
          crmDataContext.Orders.DeleteOnSubmit(curentOrder);
      }
    }

    private void dgOrders_DataError(object sender, System.Windows.Forms.DataGridViewDataErrorEventArgs e) {

      if (e.Exception is ArgumentException)
        MessageBox.Show("The value is not valid.", MainForm.SampleName, MessageBoxButtons.OK, MessageBoxIcon.Error);
      else
        MessageBox.Show(e.Exception.Message, MainForm.SampleName, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
  }
}
