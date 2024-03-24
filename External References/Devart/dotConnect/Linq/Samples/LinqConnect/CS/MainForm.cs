using System;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;
using System.IO;

namespace LinqDemo {

  public partial class MainForm : Form {

    private BaseControl currentControl;
    internal const string SampleName = "Devart LinqConnect Demo";
    private bool activated = false;

    public MainForm() {

      InitializeComponent();

      //codeRewiew
      currentControl = new Queries.QueriesControl();
      lvFrames.Items[0].Tag = currentControl;
      currentControl.UpdateChanged += new EventHandler(currentControl_UpdateChanged);
      
      currentControl = new MasterDetail.MasterDetailControl();
      lvFrames.Items[1].Tag = currentControl;
      currentControl.UpdateChanged += new EventHandler(currentControl_UpdateChanged);
      
      currentControl = new SubmitChanges.SubmitChangesControl();
      lvFrames.Items[2].Tag = currentControl;
      currentControl.UpdateChanged += new EventHandler(currentControl_UpdateChanged);

      lvFrames.Items[0].Selected = true;
    }

    private void currentControl_UpdateChanged(object sender, EventArgs e) {

      stripLabel.Text = sender as string;
    }

    private void tsbOpen_Click(object sender, EventArgs e) {

      //Connect Dialog show
      string connectionString;
      string providerPrefix;
      if (!ConnectionDialog.Show(out connectionString, out providerPrefix)) {
        stripLabel.Text = "Incorrect connection string";
        return;
      }

      //Frame activating
      Stream contextStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(String.Format("LinqDemo.CrmDataMapping{0}.lqml", providerPrefix));
      Devart.Data.Linq.Mapping.MappingSource mappingSource = Devart.Data.Linq.Mapping.XmlMappingSource.FromStream(contextStream);
      BaseControl.CrmDataContext = new CrmDataContext.CrmDataContext(connectionString, mappingSource);

      BaseControl.CrmDataContext.Connection.StateChange += new System.Data.StateChangeEventHandler(Connection_StateChange);

      try {
        BaseControl.CrmDataContext.Connection.Open();
        foreach (ListViewItem lvItem in lvFrames.Items)
          ((BaseControl)lvItem.Tag).OpenClick();
      }
      catch (Exception ex) {
        stripLabel.Text = ex.Message;
        return;
      }

      ManageControlsIfOpen(true);
    }

    private void Connection_StateChange(object sender, System.Data.StateChangeEventArgs e) {

      currentControl.ControlsEnabled(e.CurrentState == System.Data.ConnectionState.Open);
    }

    private void tsbClose_Click(object sender, EventArgs e) {

      if (BaseControl.CrmDataContext != null) {
        BaseControl.CrmDataContext.Connection.Close();
        foreach (ListViewItem lvItem in lvFrames.Items)
          ((BaseControl)lvItem.Tag).CloseClick();
        BaseControl.CrmDataContext = null;
      }

      ManageControlsIfOpen(false);
    }

    private void lvFrames_SelectedIndexChanged(object sender, EventArgs e) {

      //Turn on frame selected from the list
      if (lvFrames.SelectedItems.Count == 1) {
        currentControl = (BaseControl)lvFrames.SelectedItems[0].Tag;

        currentControl.Parent = pnContent;
        currentControl.Dock = DockStyle.Fill;
        currentControl.BringToFront();

        if (BaseControl.CrmDataContext != null)
          currentControl.ControlsEnabled(BaseControl.CrmDataContext.Connection.State == System.Data.ConnectionState.Open);
        else
          currentControl.ControlsEnabled(false);

        //Analyze current state - opened or closed
        if (activated && !currentControl.Active)
          currentControl.OpenClick();
        else if (!activated && currentControl.Active)
          currentControl.CloseClick();

        this.Text = string.Format("{0} - {1}", SampleName, currentControl.FormName);
      }
    }

    private void ManageControlsIfOpen(bool opened) {

      stripLabel.Text = (opened ? "Open" : "Close");
      activated = opened;
      tsbOpen.Enabled = !opened;
      tsbClose.Enabled = opened;
    }
  }
}