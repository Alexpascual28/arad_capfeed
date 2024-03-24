namespace LinqDemo {
  partial class MainForm {
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Queries", 0);
      System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("MasterDetail", 0);
      System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("SubmitChanges", 0);
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.pnDirect = new System.Windows.Forms.Panel();
      this.lbDirect = new System.Windows.Forms.Label();
      this.lvFrames = new System.Windows.Forms.ListView();
      this.images = new System.Windows.Forms.ImageList(this.components);
      this.tsbOpen = new System.Windows.Forms.ToolStripButton();
      this.pnContent = new System.Windows.Forms.Panel();
      this.tsOpenClose = new System.Windows.Forms.ToolStrip();
      this.tsbClose = new System.Windows.Forms.ToolStripButton();
      this.splitterLeft = new System.Windows.Forms.Splitter();
      this.stripContainer = new System.Windows.Forms.ToolStripContainer();
      this.stripStatus = new System.Windows.Forms.StatusStrip();
      this.stripLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.pnLeft = new System.Windows.Forms.Panel();
      this.pnDirect.SuspendLayout();
      this.tsOpenClose.SuspendLayout();
      this.stripContainer.BottomToolStripPanel.SuspendLayout();
      this.stripContainer.ContentPanel.SuspendLayout();
      this.stripContainer.SuspendLayout();
      this.stripStatus.SuspendLayout();
      this.pnLeft.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnDirect
      // 
      this.pnDirect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
      this.pnDirect.Controls.Add(this.lbDirect);
      this.pnDirect.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnDirect.Location = new System.Drawing.Point(0, 0);
      this.pnDirect.Name = "pnDirect";
      this.pnDirect.Size = new System.Drawing.Size(823, 48);
      this.pnDirect.TabIndex = 12;
      // 
      // lbDirect
      // 
      this.lbDirect.AutoSize = true;
      this.lbDirect.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbDirect.ForeColor = System.Drawing.Color.White;
      this.lbDirect.Location = new System.Drawing.Point(3, 6);
      this.lbDirect.Name = "lbDirect";
      this.lbDirect.Size = new System.Drawing.Size(409, 32);
      this.lbDirect.TabIndex = 0;
      this.lbDirect.Text = "Devart LinqConnect Demo";
      // 
      // lvFrames
      // 
      this.lvFrames.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.lvFrames.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lvFrames.HideSelection = false;
      listViewItem1.Checked = true;
      listViewItem1.StateImageIndex = 1;
      listViewItem2.StateImageIndex = 0;
      this.lvFrames.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
      this.lvFrames.LargeImageList = this.images;
      this.lvFrames.Location = new System.Drawing.Point(0, 25);
      this.lvFrames.MultiSelect = false;
      this.lvFrames.Name = "lvFrames";
      this.lvFrames.Scrollable = false;
      this.lvFrames.Size = new System.Drawing.Size(120, 358);
      this.lvFrames.SmallImageList = this.images;
      this.lvFrames.TabIndex = 16;
      this.lvFrames.TileSize = new System.Drawing.Size(168, 24);
      this.lvFrames.UseCompatibleStateImageBehavior = false;
      this.lvFrames.View = System.Windows.Forms.View.Tile;
      this.lvFrames.SelectedIndexChanged += new System.EventHandler(this.lvFrames_SelectedIndexChanged);
      // 
      // images
      // 
      this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
      this.images.TransparentColor = System.Drawing.Color.Magenta;
      this.images.Images.SetKeyName(0, "Demo.bmp");
      // 
      // tsbOpen
      // 
      this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
      this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbOpen.Name = "tsbOpen";
      this.tsbOpen.Size = new System.Drawing.Size(37, 22);
      this.tsbOpen.Text = "Open";
      this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
      // 
      // pnContent
      // 
      this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnContent.Location = new System.Drawing.Point(123, 0);
      this.pnContent.Name = "pnContent";
      this.pnContent.Size = new System.Drawing.Size(700, 383);
      this.pnContent.TabIndex = 17;
      // 
      // tsOpenClose
      // 
      this.tsOpenClose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbClose});
      this.tsOpenClose.Location = new System.Drawing.Point(0, 0);
      this.tsOpenClose.Name = "tsOpenClose";
      this.tsOpenClose.Size = new System.Drawing.Size(120, 25);
      this.tsOpenClose.TabIndex = 5;
      // 
      // tsbClose
      // 
      this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tsbClose.Enabled = false;
      this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
      this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbClose.Name = "tsbClose";
      this.tsbClose.Size = new System.Drawing.Size(37, 22);
      this.tsbClose.Text = "Close";
      this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
      // 
      // splitterLeft
      // 
      this.splitterLeft.Location = new System.Drawing.Point(120, 0);
      this.splitterLeft.MinExtra = 100;
      this.splitterLeft.MinSize = 100;
      this.splitterLeft.Name = "splitterLeft";
      this.splitterLeft.Size = new System.Drawing.Size(3, 383);
      this.splitterLeft.TabIndex = 16;
      this.splitterLeft.TabStop = false;
      // 
      // stripContainer
      // 
      // 
      // stripContainer.BottomToolStripPanel
      // 
      this.stripContainer.BottomToolStripPanel.Controls.Add(this.stripStatus);
      // 
      // stripContainer.ContentPanel
      // 
      this.stripContainer.ContentPanel.Controls.Add(this.pnContent);
      this.stripContainer.ContentPanel.Controls.Add(this.splitterLeft);
      this.stripContainer.ContentPanel.Controls.Add(this.pnLeft);
      this.stripContainer.ContentPanel.Size = new System.Drawing.Size(823, 383);
      this.stripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.stripContainer.Location = new System.Drawing.Point(0, 48);
      this.stripContainer.Name = "stripContainer";
      this.stripContainer.Size = new System.Drawing.Size(823, 430);
      this.stripContainer.TabIndex = 13;
      this.stripContainer.Text = "toolStripContainer1";
      // 
      // stripStatus
      // 
      this.stripStatus.Dock = System.Windows.Forms.DockStyle.None;
      this.stripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabel});
      this.stripStatus.Location = new System.Drawing.Point(0, 0);
      this.stripStatus.Name = "stripStatus";
      this.stripStatus.Size = new System.Drawing.Size(823, 22);
      this.stripStatus.TabIndex = 5;
      this.stripStatus.Text = "statusStrip1";
      // 
      // stripLabel
      // 
      this.stripLabel.Name = "stripLabel";
      this.stripLabel.Size = new System.Drawing.Size(0, 17);
      // 
      // pnLeft
      // 
      this.pnLeft.AutoScroll = true;
      this.pnLeft.Controls.Add(this.lvFrames);
      this.pnLeft.Controls.Add(this.tsOpenClose);
      this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnLeft.Location = new System.Drawing.Point(0, 0);
      this.pnLeft.Name = "pnLeft";
      this.pnLeft.Size = new System.Drawing.Size(120, 383);
      this.pnLeft.TabIndex = 14;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(823, 478);
      this.Controls.Add(this.stripContainer);
      this.Controls.Add(this.pnDirect);
      this.MinimumSize = new System.Drawing.Size(550, 407);
      this.Name = "MainForm";
      this.Text = "Devart LinqConnect Demo";
      this.pnDirect.ResumeLayout(false);
      this.pnDirect.PerformLayout();
      this.tsOpenClose.ResumeLayout(false);
      this.tsOpenClose.PerformLayout();
      this.stripContainer.BottomToolStripPanel.ResumeLayout(false);
      this.stripContainer.BottomToolStripPanel.PerformLayout();
      this.stripContainer.ContentPanel.ResumeLayout(false);
      this.stripContainer.ResumeLayout(false);
      this.stripContainer.PerformLayout();
      this.stripStatus.ResumeLayout(false);
      this.stripStatus.PerformLayout();
      this.pnLeft.ResumeLayout(false);
      this.pnLeft.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnDirect;
    protected System.Windows.Forms.Label lbDirect;
    private System.Windows.Forms.ListView lvFrames;
    private System.Windows.Forms.ImageList images;
    private System.Windows.Forms.ToolStripButton tsbOpen;
    private System.Windows.Forms.Panel pnContent;
    private System.Windows.Forms.ToolStrip tsOpenClose;
    private System.Windows.Forms.ToolStripButton tsbClose;
    private System.Windows.Forms.Splitter splitterLeft;
    private System.Windows.Forms.ToolStripContainer stripContainer;
    private System.Windows.Forms.StatusStrip stripStatus;
    private System.Windows.Forms.ToolStripStatusLabel stripLabel;
    private System.Windows.Forms.Panel pnLeft;

  }
}

