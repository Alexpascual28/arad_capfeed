<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueriesControl
  Inherits LinqDemo.BaseControl

  'UserControl overrides dispose to clean up the component list.
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
    Me.dataGridView = New System.Windows.Forms.DataGridView
    Me.splitter = New System.Windows.Forms.Splitter
    Me.tbQuery = New System.Windows.Forms.TextBox
    Me.toolStripQueries = New System.Windows.Forms.ToolStrip
    Me.cbQuery = New System.Windows.Forms.ToolStripComboBox
    CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.toolStripQueries.SuspendLayout()
    Me.SuspendLayout()
    '
    'dataGridView
    '
    Me.dataGridView.AllowUserToAddRows = False
    Me.dataGridView.AllowUserToDeleteRows = False
    Me.dataGridView.AllowUserToResizeRows = False
    Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dataGridView.Location = New System.Drawing.Point(0, 25)
    Me.dataGridView.Name = "dataGridView"
    Me.dataGridView.ReadOnly = True
    Me.dataGridView.RowHeadersWidth = 10
    Me.dataGridView.Size = New System.Drawing.Size(446, 150)
    Me.dataGridView.TabIndex = 27
    '
    'splitter
    '
    Me.splitter.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.splitter.Location = New System.Drawing.Point(0, 175)
    Me.splitter.MinExtra = 150
    Me.splitter.MinSize = 50
    Me.splitter.Name = "splitter"
    Me.splitter.Size = New System.Drawing.Size(446, 3)
    Me.splitter.TabIndex = 26
    Me.splitter.TabStop = False
    '
    'tbQuery
    '
    Me.tbQuery.BackColor = System.Drawing.SystemColors.Info
    Me.tbQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.tbQuery.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.tbQuery.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
    Me.tbQuery.Location = New System.Drawing.Point(0, 178)
    Me.tbQuery.Multiline = True
    Me.tbQuery.Name = "tbQuery"
    Me.tbQuery.ReadOnly = True
    Me.tbQuery.Size = New System.Drawing.Size(446, 78)
    Me.tbQuery.TabIndex = 25
    '
    'toolStripQueries
    '
    Me.toolStripQueries.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cbQuery})
    Me.toolStripQueries.Location = New System.Drawing.Point(0, 0)
    Me.toolStripQueries.Name = "toolStripQueries"
    Me.toolStripQueries.Size = New System.Drawing.Size(446, 25)
    Me.toolStripQueries.TabIndex = 24
    '
    'cbQuery
    '
    Me.cbQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbQuery.DropDownWidth = 400
    Me.cbQuery.Name = "cbQuery"
    Me.cbQuery.Size = New System.Drawing.Size(400, 25)
    '
    'QueriesControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.dataGridView)
    Me.Controls.Add(Me.splitter)
    Me.Controls.Add(Me.tbQuery)
    Me.Controls.Add(Me.toolStripQueries)
    Me.Name = "QueriesControl"
    Me.Size = New System.Drawing.Size(446, 256)
    CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
    Me.toolStripQueries.ResumeLayout(False)
    Me.toolStripQueries.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents dataGridView As System.Windows.Forms.DataGridView
  Private WithEvents splitter As System.Windows.Forms.Splitter
  Private WithEvents tbQuery As System.Windows.Forms.TextBox
  Private WithEvents toolStripQueries As System.Windows.Forms.ToolStrip
  Private WithEvents cbQuery As System.Windows.Forms.ToolStripComboBox

End Class
