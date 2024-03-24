<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubmitChangesControl
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubmitChangesControl))
    Me.tsUpdate = New System.Windows.Forms.ToolStrip
    Me.tsbUpdate = New System.Windows.Forms.ToolStripButton
    Me.dgCompany = New System.Windows.Forms.DataGridView
    Me.tsUpdate.SuspendLayout()
    CType(Me.dgCompany, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'tsUpdate
    '
    Me.tsUpdate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbUpdate})
    Me.tsUpdate.Location = New System.Drawing.Point(0, 0)
    Me.tsUpdate.Name = "tsUpdate"
    Me.tsUpdate.Size = New System.Drawing.Size(150, 25)
    Me.tsUpdate.TabIndex = 9
    '
    'tsbUpdate
    '
    Me.tsbUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
    Me.tsbUpdate.Image = CType(resources.GetObject("tsbUpdate.Image"), System.Drawing.Image)
    Me.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tsbUpdate.Name = "tsbUpdate"
    Me.tsbUpdate.Size = New System.Drawing.Size(46, 22)
    Me.tsbUpdate.Text = "Update"
    '
    'dgCompany
    '
    Me.dgCompany.AllowUserToResizeRows = False
    Me.dgCompany.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgCompany.Location = New System.Drawing.Point(0, 29)
    Me.dgCompany.Margin = New System.Windows.Forms.Padding(4)
    Me.dgCompany.MultiSelect = False
    Me.dgCompany.Name = "dgCompany"
    Me.dgCompany.RowHeadersWidth = 10
    Me.dgCompany.RowTemplate.Height = 24
    Me.dgCompany.Size = New System.Drawing.Size(150, 121)
    Me.dgCompany.TabIndex = 10
    '
    'SubmitChangesControl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.dgCompany)
    Me.Controls.Add(Me.tsUpdate)
    Me.Name = "SubmitChangesControl"
    Me.tsUpdate.ResumeLayout(False)
    Me.tsUpdate.PerformLayout()
    CType(Me.dgCompany, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents tsUpdate As System.Windows.Forms.ToolStrip
  Private WithEvents tsbUpdate As System.Windows.Forms.ToolStripButton
  Private WithEvents dgCompany As System.Windows.Forms.DataGridView

End Class
