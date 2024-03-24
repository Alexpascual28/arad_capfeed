using System.Linq;
using System.Windows.Forms;
using System;

namespace LinqDemo.SubmitChanges {

  public partial class SubmitChangesControl : BaseControl {

    public SubmitChangesControl() : base("SubmitChanges") {
      InitializeComponent();
    }

    internal override event EventHandler UpdateChanged;

    internal override void OpenClick() {

      var companies = from c in crmDataContext.Companies
                      select c;

      dgCompany.DataSource = companies;

      base.OpenClick();
    }

    internal override void CloseClick() {

      dgCompany.CommitEdit(DataGridViewDataErrorContexts.Commit);
      dgCompany.DataSource = typeof(CrmDataContext.Company);
      base.CloseClick();
    }

    internal override void ControlsEnabled(bool state) {

      tsbUpdate.Enabled = state;
    }

    private void tsbUpdate_Click(object sender, System.EventArgs e) {

      try {
        if (crmDataContext != null) {
          crmDataContext.SubmitChanges();
          if (UpdateChanged != null)
            UpdateChanged(this, null);
        }
      }
      catch (Exception ex) {
        MessageBox.Show(ex.Message, MainForm.SampleName, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void dgCompany_DataError(object sender, System.Windows.Forms.DataGridViewDataErrorEventArgs e) {

      if (e.Exception is ArgumentException)
        MessageBox.Show("The value is not valid.", MainForm.SampleName, MessageBoxButtons.OK, MessageBoxIcon.Error);
      else
        MessageBox.Show(e.Exception.Message, MainForm.SampleName, MessageBoxButtons.OK, MessageBoxIcon.Error);
      dgCompany.CancelEdit();
    }
  }
}
