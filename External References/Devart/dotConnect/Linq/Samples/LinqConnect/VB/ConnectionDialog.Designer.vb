<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConnectionDialog
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
    Me.panel1 = New System.Windows.Forms.GroupBox
    Me.bbNoSupportedFound = New System.Windows.Forms.Label
    Me.btConnect = New System.Windows.Forms.Button
    Me.btCancel = New System.Windows.Forms.Button
    Me.cbProviders = New System.Windows.Forms.ComboBox
    Me.label1 = New System.Windows.Forms.Label
    Me.panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'panel1
    '
    Me.panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.panel1.Controls.Add(Me.bbNoSupportedFound)
    Me.panel1.Location = New System.Drawing.Point(3, 35)
    Me.panel1.Name = "panel1"
    Me.panel1.Size = New System.Drawing.Size(286, 195)
    Me.panel1.TabIndex = 4
    Me.panel1.TabStop = False
    '
    'bbNoSupportedFound
    '
    Me.bbNoSupportedFound.AutoSize = True
    Me.bbNoSupportedFound.Location = New System.Drawing.Point(52, 90)
    Me.bbNoSupportedFound.Name = "bbNoSupportedFound"
    Me.bbNoSupportedFound.Size = New System.Drawing.Size(174, 13)
    Me.bbNoSupportedFound.TabIndex = 2
    Me.bbNoSupportedFound.Text = "No supported Data Providers found"
    Me.bbNoSupportedFound.Visible = False
    '
    'btConnect
    '
    Me.btConnect.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btConnect.Location = New System.Drawing.Point(46, 236)
    Me.btConnect.Name = "btConnect"
    Me.btConnect.Size = New System.Drawing.Size(87, 28)
    Me.btConnect.TabIndex = 3
    Me.btConnect.Text = "OK"
    Me.btConnect.UseVisualStyleBackColor = True
    '
    'btCancel
    '
    Me.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btCancel.Location = New System.Drawing.Point(157, 236)
    Me.btCancel.Name = "btCancel"
    Me.btCancel.Size = New System.Drawing.Size(87, 28)
    Me.btCancel.TabIndex = 5
    Me.btCancel.Text = "Cancel"
    Me.btCancel.UseVisualStyleBackColor = True
    '
    'cbProviders
    '
    Me.cbProviders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbProviders.FormattingEnabled = True
    Me.cbProviders.Location = New System.Drawing.Point(93, 8)
    Me.cbProviders.Name = "cbProviders"
    Me.cbProviders.Size = New System.Drawing.Size(187, 21)
    Me.cbProviders.TabIndex = 6
    '
    'label1
    '
    Me.label1.AutoSize = True
    Me.label1.Location = New System.Drawing.Point(15, 11)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(75, 13)
    Me.label1.TabIndex = 2
    Me.label1.Text = "Data Provider:"
    '
    'ConnectionDialog
    '
    Me.AcceptButton = Me.btConnect
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btCancel
    Me.ClientSize = New System.Drawing.Size(292, 272)
    Me.Controls.Add(Me.panel1)
    Me.Controls.Add(Me.btConnect)
    Me.Controls.Add(Me.btCancel)
    Me.Controls.Add(Me.cbProviders)
    Me.Controls.Add(Me.label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "ConnectionDialog"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Connect"
    Me.panel1.ResumeLayout(False)
    Me.panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents panel1 As System.Windows.Forms.GroupBox
  Private WithEvents bbNoSupportedFound As System.Windows.Forms.Label
  Private WithEvents btConnect As System.Windows.Forms.Button
  Private WithEvents btCancel As System.Windows.Forms.Button
  Private WithEvents cbProviders As System.Windows.Forms.ComboBox
  Private WithEvents label1 As System.Windows.Forms.Label
End Class
