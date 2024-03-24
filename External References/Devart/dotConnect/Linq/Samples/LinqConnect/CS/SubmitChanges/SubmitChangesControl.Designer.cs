namespace LinqDemo.SubmitChanges {
  partial class SubmitChangesControl {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubmitChangesControl));
      this.tsUpdate = new System.Windows.Forms.ToolStrip();
      this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
      this.dgCompany = new System.Windows.Forms.DataGridView();
      this.tsUpdate.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgCompany)).BeginInit();
      this.SuspendLayout();
      // 
      // tsUpdate
      // 
      this.tsUpdate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUpdate});
      this.tsUpdate.Location = new System.Drawing.Point(0, 0);
      this.tsUpdate.Name = "tsUpdate";
      this.tsUpdate.Size = new System.Drawing.Size(150, 25);
      this.tsUpdate.TabIndex = 7;
      // 
      // tsbUpdate
      // 
      this.tsbUpdate.Enabled = false;
      this.tsbUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
      this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbUpdate.Name = "tsbUpdate";
      this.tsbUpdate.Size = new System.Drawing.Size(46, 22);
      this.tsbUpdate.Text = "Update";
      this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
      // 
      // dgCompany
      // 
      this.dgCompany.AllowUserToResizeRows = false;
      this.dgCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgCompany.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgCompany.Location = new System.Drawing.Point(0, 25);
      this.dgCompany.MultiSelect = false;
      this.dgCompany.Name = "dgCompany";
      this.dgCompany.RowHeadersWidth = 10;
      this.dgCompany.Size = new System.Drawing.Size(150, 125);
      this.dgCompany.TabIndex = 8;
      this.dgCompany.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgCompany_DataError);

      // 
      // SubmitChangesControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dgCompany);
      this.Controls.Add(this.tsUpdate);
      this.Name = "SubmitChangesControl";
      this.tsUpdate.ResumeLayout(false);
      this.tsUpdate.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgCompany)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip tsUpdate;
    private System.Windows.Forms.ToolStripButton tsbUpdate;
    private System.Windows.Forms.DataGridView dgCompany;

  }
}
