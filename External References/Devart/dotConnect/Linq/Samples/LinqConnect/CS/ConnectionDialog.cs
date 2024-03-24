using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using System.Configuration;

namespace LinqDemo {

  public partial class ConnectionDialog : Form {

    private static string[] providerNames = new string[] { "Devart.Data.Oracle", "Devart.Data.MySql", "Devart.Data.PostgreSql", "Devart.Data.SQLite", "System.Data.SqlClient" };
    private static string[] providerPrefixes = new string[] { "Oracle", "MySql", "PostgreSql", "SQLite", "SqlClient" };

    public Dictionary<string, string> parameters = new Dictionary<string, string>();
    public string providerPrefix;

    public ConnectionDialog() {
      InitializeComponent();
    }

    private void ConnectionDialog_Load(object sender, EventArgs e) {

      DataTable table = DbProviderFactories.GetFactoryClasses();
      if (table != null) {
        foreach (string providerName in providerNames) {
          DataRow row = table.Rows.Find(providerName);
          if (row != null) {
            cbProviders.Items.Add(row[0]);
          }
        }
        if (cbProviders.Items.Count > 0)
          cbProviders.SelectedItem = cbProviders.Items[0];
        else
          bbNoSupportedFound.Visible = true;
        if (cbProviders.Items.Count == 1)
          cbProviders.Enabled = false;
      }
    }

    private void cbProviders_SelectedIndexChanged(object sender, EventArgs e) {
      
      int providerIndex = -1;
      for (int i = 0; i < providerNames.Length;i++) {
        if (((string)cbProviders.SelectedItem).IndexOf(providerPrefixes[i], StringComparison.InvariantCultureIgnoreCase) >= 0) {
          providerIndex = i;
          break;
        }
      }
      if (providerIndex >= 0) {
        providerPrefix = providerPrefixes[providerIndex];
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString" + providerPrefix].ToString();
        InitConnectionStringControls(connectionString);
      }
    }

    private void InitConnectionStringControls(string providerConnectionString) {

      panel1.Controls.Clear();
      parameters.Clear();

      string[] parts = providerConnectionString.Split('=', ';');
      if (parts.Length % 2 != 0)
        return;
      int keyCount = parts.Length / 2;
      for (int i = 0; i < keyCount; i++)
        parameters.Add(parts[i * 2], parts[i * 2 + 1]);

      // show Connection Dialog
      int shiftY = 10;
      int index = 1;
      List<Control> components = new List<Control>();
      foreach (string key in parameters.Keys) {

        // Key
        Label label = new Label();
        label.Location = new Point(12, shiftY);
        label.Size = new Size(75, 19);
        label.Text = key;
        label.TextAlign = ContentAlignment.MiddleLeft;

        // Value
        Control comp;
        string value = parameters[key];
        Int64 intValue;
        bool boolValue;
        if (Int64.TryParse(value, out intValue)) {
          NumericUpDown numeric = new NumericUpDown();
          numeric.Maximum = 65535;
          numeric.Value = intValue;
          comp = numeric;
        }
        else
          if (Boolean.TryParse(value, out boolValue)) {
            CheckBox checkbox = new CheckBox();
            checkbox.Checked = boolValue;
            comp = checkbox;
          }
          else {
            TextBox textBox = new TextBox();
            if (key.ToLower().Contains("password"))
              textBox.PasswordChar = '*';
            textBox.Text = value;
            comp = textBox;
          }
        comp.Location = new Point(90, shiftY);
        comp.Size = new Size(187, 20);
        comp.TabIndex = index + 1;
        comp.Tag = key;

        panel1.Controls.Add(comp);
        panel1.Controls.Add(label);
        components.Add(comp);
        shiftY += 25;
        index++;
      }
    }

    public static bool Show(out string providerConnectionString, out string providerPrefix) {
      
      ConnectionDialog form = new ConnectionDialog();
      if (form.ShowDialog() != DialogResult.OK) {
        providerConnectionString = null;
        providerPrefix = null;
        return false;
      }

      providerPrefix = form.providerPrefix;

      // new connection string
      StringBuilder sb = new StringBuilder();
      int index = 0;
      foreach (Control comp in form.panel1.Controls) {
        if (comp.Tag == null)
          continue;
        string key = (string)comp.Tag;
        string text = String.Empty;
        if (comp is TextBox)
          text = (comp as TextBox).Text;
        else
          if (comp is CheckBox)
            text = (comp as CheckBox).Checked ? "True" : "False";
          else
            if (comp is NumericUpDown)
              text = (comp as NumericUpDown).Value.ToString();
        sb.AppendFormat("{0}={1};", key, text);
        index++;
      }
      providerConnectionString = sb.ToString();
      return true;
    }

  }
}
