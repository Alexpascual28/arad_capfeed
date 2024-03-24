Imports System.Configuration
Imports Devart.Data.Linq.Mapping
Imports System.Reflection

Public Class MainForm

  'Fields
  Friend Const SampleName As String = "Devart LinqConnect Demo"
  Private active As Boolean = False
  Private currentControl As BaseControl

  'Methods
  Public Sub New()
    InitializeComponent()
    Me.active = False
    Me.lvFrames.Items.Item(0).Tag = New QueriesControl
    Me.lvFrames.Items.Item(1).Tag = New MasterDetailControl
    Me.lvFrames.Items.Item(2).Tag = New SubmitChangesControl
    Me.lvFrames.Items.Item(0).Selected = True
  End Sub

  Private Sub ManageControlsIfOpen(ByVal opened As Boolean)
    Me.stripLabel.Text = IIf(opened, "Opened", "Closed")
    Me.active = opened
    Me.tsbOpen.Enabled = Not opened
    Me.tsbClose.Enabled = opened
  End Sub

  'Event handlers
  Private Sub tsbOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbOpen.Click
    'Connect Dialog show
    Dim connectionString As String = Nothing
    Dim providerPrefix As String = Nothing
    If Not ConnectionDialog.Show(connectionString, providerPrefix) Then
      Me.stripLabel.Text = "Incorrect connection string"
    Else
            Dim mappingSource As MappingSource = XmlMappingSource.FromStream(Assembly.GetExecutingAssembly.GetManifestResourceStream(String.Format("LinqDemo.CrmDataMapping{0}.lqml", providerPrefix)))
      BaseControl.CrmDataContext = New CrmDataContext.CrmDataContext(connectionString, mappingSource)
      AddHandler BaseControl.CrmDataContext.Connection.StateChange, New StateChangeEventHandler(AddressOf Me.Connection_StateChange)
      Try
        BaseControl.CrmDataContext.Connection.Open()
        Dim lvItem As ListViewItem
        For Each lvItem In Me.lvFrames.Items
          DirectCast(lvItem.Tag, BaseControl).OpenClick()
        Next
      Catch ex As Exception
        Me.stripLabel.Text = ex.Message
        Return
      End Try
      Me.ManageControlsIfOpen(True)
    End If
  End Sub

  Private Sub Connection_StateChange(ByVal sender As System.Object, ByVal e As System.Data.StateChangeEventArgs)
    currentControl.ControlsEnabled(e.CurrentState = System.Data.ConnectionState.Open)
  End Sub

  Private Sub tsbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbClose.Click
    If (Not BaseControl.CrmDataContext Is Nothing) Then
      BaseControl.CrmDataContext.Connection.Close()
      BaseControl.CrmDataContext = Nothing
      Dim lvItem As ListViewItem
      For Each lvItem In Me.lvFrames.Items
        DirectCast(lvItem.Tag, BaseControl).CloseClick()
      Next
    End If
    Me.ManageControlsIfOpen(False)
  End Sub

  Private Sub lvFrames_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvFrames.SelectedIndexChanged
    'Turn on frame selected from the list
    If (Me.lvFrames.SelectedItems.Count = 1) Then
      Me.currentControl = DirectCast(Me.lvFrames.SelectedItems.Item(0).Tag, BaseControl)
      Me.currentControl.Parent = Me.pnContent
      Me.currentControl.Dock = DockStyle.Fill
      Me.currentControl.BringToFront()

      If (BaseControl.CrmDataContext IsNot Nothing) Then
        currentControl.ControlsEnabled(BaseControl.CrmDataContext.Connection.State = System.Data.ConnectionState.Open)
      Else
        currentControl.ControlsEnabled(False)
      End If

      'Analyze current state - opened or closed
      If (Me.active AndAlso Not Me.currentControl.Active) Then
        Me.currentControl.OpenClick()
      ElseIf (Not Me.active AndAlso Me.currentControl.Active) Then
        Me.currentControl.CloseClick()
      End If
      Me.Text = String.Format("{0} - {1}", SampleName, Me.currentControl.FormName)
    End If
  End Sub
End Class