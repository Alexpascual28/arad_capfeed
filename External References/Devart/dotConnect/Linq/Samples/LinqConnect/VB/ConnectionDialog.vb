Imports System.Text
Imports System.Configuration
Imports System.Data.Common

Public Class ConnectionDialog

  Public parameters As Dictionary(Of String, String) = New Dictionary(Of String, String)
  Private Shared providerNames As String()
  Public providerPrefix As String
  Private Shared providerPrefixes As String()

  Shared Sub New()
        ConnectionDialog.providerNames = New String() {"Devart.Data.Oracle", "Devart.Data.MySql", "Devart.Data.PostgreSql", "Devart.Data.SQLite", "System.Data.SqlClient"}
        ConnectionDialog.providerPrefixes = New String() {"Oracle", "MySql", "PostgreSql", "SQLite", "SqlClient"}
  End Sub

  Private Sub ConnectDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Dim table As DataTable = DbProviderFactories.GetFactoryClasses
    If (Not table Is Nothing) Then
      Dim providerName As String
      For Each providerName In ConnectionDialog.providerNames
        Dim row As DataRow = table.Rows.Find(providerName)
        If (Not row Is Nothing) Then
          Me.cbProviders.Items.Add(row.Item(0))
        End If
      Next
      If (Me.cbProviders.Items.Count > 0) Then
        Me.cbProviders.SelectedItem = Me.cbProviders.Items.Item(0)
      Else
        Me.bbNoSupportedFound.Visible = True
      End If
      If (Me.cbProviders.Items.Count = 1) Then
        Me.cbProviders.Enabled = False
      End If
    End If
  End Sub

  Public Shared Function Show(ByRef providerConnectionString As String, ByRef providerPrefix As String) As Boolean
    Dim form As New ConnectionDialog
    If (form.ShowDialog <> DialogResult.OK) Then
      providerConnectionString = Nothing
      providerPrefix = Nothing
      Return False
    End If
    providerPrefix = form.providerPrefix
    Dim sb As New StringBuilder
    Dim index As Integer = 0
    Dim comp As Control
    For Each comp In form.panel1.Controls
      If (comp.Tag Is Nothing) Then
        Continue For
      End If
      Dim key As String = CStr(comp.Tag)
      Dim text As String = String.Empty
      If TypeOf comp Is TextBox Then
        [text] = TryCast(comp, TextBox).Text
      ElseIf TypeOf comp Is CheckBox Then
        [text] = IIf(TryCast(comp, CheckBox).Checked, "True", "False")
      ElseIf TypeOf comp Is NumericUpDown Then
        [text] = TryCast(comp, NumericUpDown).Value.ToString
      End If
      sb.AppendFormat("{0}={1};", key, [text])
      index += 1
    Next
    providerConnectionString = sb.ToString
    Return True
  End Function

  Private Sub cbProviders_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProviders.SelectedIndexChanged

    Dim providerIndex As Integer = -1
    Dim i As Integer
    For i = 0 To ConnectionDialog.providerNames.Length - 1
      If (CStr(Me.cbProviders.SelectedItem).IndexOf(ConnectionDialog.providerPrefixes(i), StringComparison.InvariantCultureIgnoreCase) >= 0) Then
        providerIndex = i
        Exit For
      End If
    Next i
    If (providerIndex >= 0) Then
      Me.providerPrefix = ConnectionDialog.providerPrefixes(providerIndex)
      Dim connectionString As String = ConfigurationManager.ConnectionStrings.Item(("ConnectionString" & Me.providerPrefix)).ToString
      Me.InitConnectionStringControls(connectionString)
    End If
  End Sub

  Private Sub InitConnectionStringControls(ByVal providerConnectionString As String)

    Me.panel1.Controls.Clear()
    Me.parameters.Clear()
    Dim parts As String() = providerConnectionString.Split(New Char() {"="c, ";"c})
    If ((parts.Length Mod 2) = 0) Then
      Dim keyCount As Integer = (parts.Length / 2)
      Dim i As Integer
      For i = 0 To keyCount - 1
        Me.parameters.Add(parts((i * 2)), parts(((i * 2) + 1)))
      Next i
      Dim shiftY As Integer = 10
      Dim index As Integer = 1
      Dim components As New List(Of Control)
      Dim key As String
      For Each key In Me.parameters.Keys
        Dim comp As Control
        Dim intValue As Long
        Dim label As New Label
        label.Location = New Point(12, shiftY)
        label.Size = New Size(&H4B, &H13)
        label.Text = key
        label.TextAlign = ContentAlignment.MiddleLeft
        Dim value As String = Me.parameters.Item(key)
        If Long.TryParse(value, intValue) Then
          Dim numeric As New NumericUpDown
          numeric.Maximum = 65535
          numeric.Value = intValue
          comp = numeric
        Else
          Dim boolValue As Boolean
          If Boolean.TryParse(value, boolValue) Then
            Dim checkbox As New CheckBox
            checkbox.Checked = boolValue
            comp = checkbox
          Else
            Dim textBox As New TextBox
            If key.ToLower.Contains("password") Then
              textBox.PasswordChar = "*"c
            End If
            textBox.Text = value
            comp = textBox
          End If
        End If
        comp.Location = New Point(90, shiftY)
        comp.Size = New Size(&HBB, 20)
        comp.TabIndex = (index + 1)
        comp.Tag = key
        Me.panel1.Controls.Add(comp)
        Me.panel1.Controls.Add(label)
        components.Add(comp)
        shiftY = (shiftY + &H19)
        index += 1
      Next
    End If
  End Sub

End Class