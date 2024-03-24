Public Class SubmitChangesControl
  Inherits BaseControl

  Public Sub New()
    MyBase.New("SubmitChanges")
    InitializeComponent()
  End Sub

  Friend Overrides Sub OpenClick()
    Dim companies = From c In myCrmDataContext.Companies _
                      Select c

    dgCompany.DataSource = companies
    MyBase.OpenClick()
  End Sub

  Friend Overrides Sub CloseClick()
    dgCompany.CommitEdit(DataGridViewDataErrorContexts.Commit)
    dgCompany.DataSource = Nothing
    MyBase.CloseClick()
  End Sub

  Friend Overrides Sub ControlsEnabled(ByVal state As Boolean)
    Me.tsbUpdate.Enabled = state
  End Sub

  Private Sub tsbUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbUpdate.Click
    Try
      If Not (CrmDataContext Is Nothing) Then
        CrmDataContext.SubmitChanges()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, MainForm.SampleName, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub dgCompany_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgCompany.DataError

    If TryCast(e.Exception, ArgumentException) IsNot Nothing Then
      MessageBox.Show("The value is not valid.", MainForm.SampleName, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Else
      MessageBox.Show(e.Exception.Message, MainForm.SampleName, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
    dgCompany.CancelEdit()
  End Sub
End Class
