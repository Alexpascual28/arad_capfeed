namespace LinqDemo.Queries {
  partial class QueriesControl {
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
      this.toolStripQueries = new System.Windows.Forms.ToolStrip();
      this.cbQuery = new System.Windows.Forms.ToolStripComboBox();
      this.tbQuery = new System.Windows.Forms.TextBox();
      this.splitter = new System.Windows.Forms.Splitter();
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.toolStripQueries.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // toolStripQueries
      // 
      this.toolStripQueries.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbQuery});
      this.toolStripQueries.Location = new System.Drawing.Point(0, 0);
      this.toolStripQueries.Name = "toolStripQueries";
      this.toolStripQueries.Size = new System.Drawing.Size(446, 25);
      this.toolStripQueries.TabIndex = 20;
      // 
      // cbQuery
      // 
      this.cbQuery.Enabled = false;
      this.cbQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbQuery.DropDownWidth = 400;
      this.cbQuery.Name = "cbQuery";
      this.cbQuery.Size = new System.Drawing.Size(400, 25);
      this.cbQuery.SelectedIndexChanged += new System.EventHandler(this.cbQuery_SelectedIndexChanged);
      // 
      // tbQuery
      // 
      this.tbQuery.BackColor = System.Drawing.SystemColors.Info;
      this.tbQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbQuery.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.tbQuery.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.tbQuery.Location = new System.Drawing.Point(0, 178);
      this.tbQuery.Multiline = true;
      this.tbQuery.Name = "tbQuery";
      this.tbQuery.ReadOnly = true;
      this.tbQuery.Size = new System.Drawing.Size(446, 78);
      this.tbQuery.TabIndex = 21;
      // 
      // splitter
      // 
      this.splitter.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.splitter.Location = new System.Drawing.Point(0, 175);
      this.splitter.MinExtra = 150;
      this.splitter.MinSize = 50;
      this.splitter.Name = "splitter";
      this.splitter.Size = new System.Drawing.Size(446, 3);
      this.splitter.TabIndex = 22;
      this.splitter.TabStop = false;
      // 
      // dataGridView
      // 
      this.dataGridView.AllowUserToAddRows = false;
      this.dataGridView.AllowUserToDeleteRows = false;
      this.dataGridView.AllowUserToResizeRows = false;
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView.Location = new System.Drawing.Point(0, 25);
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.ReadOnly = true;
      this.dataGridView.RowHeadersWidth = 10;
      this.dataGridView.Size = new System.Drawing.Size(446, 150);
      this.dataGridView.TabIndex = 23;
      this.dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
      // 
      // QueriesControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dataGridView);
      this.Controls.Add(this.splitter);
      this.Controls.Add(this.tbQuery);
      this.Controls.Add(this.toolStripQueries);
      this.Name = "QueriesControl";
      this.Size = new System.Drawing.Size(446, 256);
      this.toolStripQueries.ResumeLayout(false);
      this.toolStripQueries.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStripQueries;
    private System.Windows.Forms.ToolStripComboBox cbQuery;
    private System.Windows.Forms.TextBox tbQuery;
    private System.Windows.Forms.Splitter splitter;
    private System.Windows.Forms.DataGridView dataGridView;

  }
}
