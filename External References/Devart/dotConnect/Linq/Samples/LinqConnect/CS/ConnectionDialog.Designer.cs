namespace LinqDemo {
  partial class ConnectionDialog {
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.label1 = new System.Windows.Forms.Label();
      this.cbProviders = new System.Windows.Forms.ComboBox();
      this.btConnect = new System.Windows.Forms.Button();
      this.btCancel = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.GroupBox();
      this.bbNoSupportedFound = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(75, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Data Provider:";
      // 
      // cbProviders
      // 
      this.cbProviders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbProviders.FormattingEnabled = true;
      this.cbProviders.Location = new System.Drawing.Point(93, 9);
      this.cbProviders.Name = "cbProviders";
      this.cbProviders.Size = new System.Drawing.Size(187, 21);
      this.cbProviders.TabIndex = 1;
      this.cbProviders.SelectedIndexChanged += new System.EventHandler(this.cbProviders_SelectedIndexChanged);
      // 
      // btConnect
      // 
      this.btConnect.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btConnect.Location = new System.Drawing.Point(46, 237);
      this.btConnect.Name = "btConnect";
      this.btConnect.Size = new System.Drawing.Size(87, 28);
      this.btConnect.TabIndex = 0;
      this.btConnect.Text = "OK";
      this.btConnect.UseVisualStyleBackColor = true;
      // 
      // btCancel
      // 
      this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btCancel.Location = new System.Drawing.Point(157, 237);
      this.btCancel.Name = "btCancel";
      this.btCancel.Size = new System.Drawing.Size(87, 28);
      this.btCancel.TabIndex = 1;
      this.btCancel.Text = "Cancel";
      this.btCancel.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.Controls.Add(this.bbNoSupportedFound);
      this.panel1.Location = new System.Drawing.Point(3, 36);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(286, 195);
      this.panel1.TabIndex = 0;
      this.panel1.TabStop = false;
      // 
      // bbNoSupportedFound
      // 
      this.bbNoSupportedFound.AutoSize = true;
      this.bbNoSupportedFound.Location = new System.Drawing.Point(52, 90);
      this.bbNoSupportedFound.Name = "bbNoSupportedFound";
      this.bbNoSupportedFound.Size = new System.Drawing.Size(174, 13);
      this.bbNoSupportedFound.TabIndex = 2;
      this.bbNoSupportedFound.Text = "No supported Data Providers found";
      this.bbNoSupportedFound.Visible = false;
      // 
      // ConnectionDialog
      // 
      this.AcceptButton = this.btConnect;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btCancel;
      this.ClientSize = new System.Drawing.Size(292, 272);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.btConnect);
      this.Controls.Add(this.btCancel);
      this.Controls.Add(this.cbProviders);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ConnectionDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Connect";
      this.Load += new System.EventHandler(this.ConnectionDialog_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cbProviders;
    private System.Windows.Forms.Button btConnect;
    private System.Windows.Forms.Button btCancel;
    private System.Windows.Forms.GroupBox panel1;
    private System.Windows.Forms.Label bbNoSupportedFound;
  }
}