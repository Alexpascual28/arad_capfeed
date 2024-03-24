<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Queries", 0)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("MasterDetail", 0)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SubmitChanges", 0)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.pnDirect = New System.Windows.Forms.Panel
        Me.lbDirect = New System.Windows.Forms.Label
        Me.splitterLeft = New System.Windows.Forms.Splitter
        Me.stripContainer = New System.Windows.Forms.ToolStripContainer
        Me.stripStatus = New System.Windows.Forms.StatusStrip
        Me.stripLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.pnContent = New System.Windows.Forms.Panel
        Me.pnLeft = New System.Windows.Forms.Panel
        Me.lvFrames = New System.Windows.Forms.ListView
        Me.images = New System.Windows.Forms.ImageList(Me.components)
        Me.tsOpenClose = New System.Windows.Forms.ToolStrip
        Me.tsbOpen = New System.Windows.Forms.ToolStripButton
        Me.tsbClose = New System.Windows.Forms.ToolStripButton
        Me.pnDirect.SuspendLayout()
        Me.stripContainer.BottomToolStripPanel.SuspendLayout()
        Me.stripContainer.ContentPanel.SuspendLayout()
        Me.stripContainer.SuspendLayout()
        Me.stripStatus.SuspendLayout()
        Me.pnLeft.SuspendLayout()
        Me.tsOpenClose.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnDirect
        '
        Me.pnDirect.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnDirect.Controls.Add(Me.lbDirect)
        Me.pnDirect.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnDirect.Location = New System.Drawing.Point(0, 0)
        Me.pnDirect.Name = "pnDirect"
        Me.pnDirect.Size = New System.Drawing.Size(823, 48)
        Me.pnDirect.TabIndex = 14
        '
        'lbDirect
        '
        Me.lbDirect.AutoSize = True
        Me.lbDirect.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbDirect.ForeColor = System.Drawing.Color.White
        Me.lbDirect.Location = New System.Drawing.Point(3, 6)
        Me.lbDirect.Name = "lbDirect"
        Me.lbDirect.Size = New System.Drawing.Size(409, 32)
        Me.lbDirect.TabIndex = 0
        Me.lbDirect.Text = "Devart LinqConnect Demo"
        '
        'splitterLeft
        '
        Me.splitterLeft.Location = New System.Drawing.Point(120, 0)
        Me.splitterLeft.MinExtra = 100
        Me.splitterLeft.MinSize = 100
        Me.splitterLeft.Name = "splitterLeft"
        Me.splitterLeft.Size = New System.Drawing.Size(3, 383)
        Me.splitterLeft.TabIndex = 16
        Me.splitterLeft.TabStop = False
        '
        'stripContainer
        '
        '
        'stripContainer.BottomToolStripPanel
        '
        Me.stripContainer.BottomToolStripPanel.Controls.Add(Me.stripStatus)
        '
        'stripContainer.ContentPanel
        '
        Me.stripContainer.ContentPanel.Controls.Add(Me.pnContent)
        Me.stripContainer.ContentPanel.Controls.Add(Me.splitterLeft)
        Me.stripContainer.ContentPanel.Controls.Add(Me.pnLeft)
        Me.stripContainer.ContentPanel.Size = New System.Drawing.Size(823, 383)
        Me.stripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stripContainer.Location = New System.Drawing.Point(0, 48)
        Me.stripContainer.Name = "stripContainer"
        Me.stripContainer.Size = New System.Drawing.Size(823, 430)
        Me.stripContainer.TabIndex = 15
        Me.stripContainer.Text = "toolStripContainer1"
        '
        'stripStatus
        '
        Me.stripStatus.Dock = System.Windows.Forms.DockStyle.None
        Me.stripStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripLabel})
        Me.stripStatus.Location = New System.Drawing.Point(0, 0)
        Me.stripStatus.Name = "stripStatus"
        Me.stripStatus.Size = New System.Drawing.Size(823, 22)
        Me.stripStatus.TabIndex = 5
        Me.stripStatus.Text = "statusStrip1"
        '
        'stripLabel
        '
        Me.stripLabel.Name = "stripLabel"
        Me.stripLabel.Size = New System.Drawing.Size(0, 17)
        '
        'pnContent
        '
        Me.pnContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnContent.Location = New System.Drawing.Point(123, 0)
        Me.pnContent.Name = "pnContent"
        Me.pnContent.Size = New System.Drawing.Size(700, 383)
        Me.pnContent.TabIndex = 17
        '
        'pnLeft
        '
        Me.pnLeft.AutoScroll = True
        Me.pnLeft.Controls.Add(Me.lvFrames)
        Me.pnLeft.Controls.Add(Me.tsOpenClose)
        Me.pnLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnLeft.Name = "pnLeft"
        Me.pnLeft.Size = New System.Drawing.Size(120, 383)
        Me.pnLeft.TabIndex = 14
        '
        'lvFrames
        '
        Me.lvFrames.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvFrames.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvFrames.HideSelection = False
        ListViewItem1.Checked = True
        ListViewItem1.StateImageIndex = 1
        ListViewItem2.Checked = True
        ListViewItem2.StateImageIndex = 1
        ListViewItem3.StateImageIndex = 0
        Me.lvFrames.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.lvFrames.LargeImageList = Me.images
        Me.lvFrames.Location = New System.Drawing.Point(0, 25)
        Me.lvFrames.MultiSelect = False
        Me.lvFrames.Name = "lvFrames"
        Me.lvFrames.Scrollable = False
        Me.lvFrames.Size = New System.Drawing.Size(120, 358)
        Me.lvFrames.SmallImageList = Me.images
        Me.lvFrames.TabIndex = 16
        Me.lvFrames.TileSize = New System.Drawing.Size(168, 24)
        Me.lvFrames.UseCompatibleStateImageBehavior = False
        Me.lvFrames.View = System.Windows.Forms.View.Tile
        '
        'images
        '
        Me.images.ImageStream = CType(resources.GetObject("images.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.images.TransparentColor = System.Drawing.Color.Magenta
        Me.images.Images.SetKeyName(0, "Demo.bmp")
        '
        'tsOpenClose
        '
        Me.tsOpenClose.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbOpen, Me.tsbClose})
        Me.tsOpenClose.Location = New System.Drawing.Point(0, 0)
        Me.tsOpenClose.Name = "tsOpenClose"
        Me.tsOpenClose.Size = New System.Drawing.Size(120, 25)
        Me.tsOpenClose.TabIndex = 5
        '
        'tsbOpen
        '
        Me.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbOpen.Image = CType(resources.GetObject("tsbOpen.Image"), System.Drawing.Image)
        Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOpen.Name = "tsbOpen"
        Me.tsbOpen.Size = New System.Drawing.Size(37, 22)
        Me.tsbOpen.Text = "Open"
        '
        'tsbClose
        '
        Me.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbClose.Enabled = False
        Me.tsbClose.Image = CType(resources.GetObject("tsbClose.Image"), System.Drawing.Image)
        Me.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbClose.Name = "tsbClose"
        Me.tsbClose.Size = New System.Drawing.Size(37, 22)
        Me.tsbClose.Text = "Close"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 478)
        Me.Controls.Add(Me.stripContainer)
        Me.Controls.Add(Me.pnDirect)
        Me.MinimumSize = New System.Drawing.Size(550, 407)
        Me.Name = "MainForm"
        Me.Text = "Devart LinqConnect Demo"
        Me.pnDirect.ResumeLayout(False)
        Me.pnDirect.PerformLayout()
        Me.stripContainer.BottomToolStripPanel.ResumeLayout(False)
        Me.stripContainer.BottomToolStripPanel.PerformLayout()
        Me.stripContainer.ContentPanel.ResumeLayout(False)
        Me.stripContainer.ResumeLayout(False)
        Me.stripContainer.PerformLayout()
        Me.stripStatus.ResumeLayout(False)
        Me.stripStatus.PerformLayout()
        Me.pnLeft.ResumeLayout(False)
        Me.pnLeft.PerformLayout()
        Me.tsOpenClose.ResumeLayout(False)
        Me.tsOpenClose.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
  Private WithEvents pnDirect As System.Windows.Forms.Panel
  Protected WithEvents lbDirect As System.Windows.Forms.Label
  Private WithEvents splitterLeft As System.Windows.Forms.Splitter
  Private WithEvents stripContainer As System.Windows.Forms.ToolStripContainer
  Private WithEvents stripStatus As System.Windows.Forms.StatusStrip
  Private WithEvents stripLabel As System.Windows.Forms.ToolStripStatusLabel
  Private WithEvents pnContent As System.Windows.Forms.Panel
  Private WithEvents pnLeft As System.Windows.Forms.Panel
  Private WithEvents lvFrames As System.Windows.Forms.ListView
  Private WithEvents images As System.Windows.Forms.ImageList
  Private WithEvents tsOpenClose As System.Windows.Forms.ToolStrip
  Private WithEvents tsbOpen As System.Windows.Forms.ToolStripButton
  Private WithEvents tsbClose As System.Windows.Forms.ToolStripButton

End Class
