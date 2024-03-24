Public Class MasterDetailControl
  Inherits BaseControl

  Public Sub New()
    MyBase.New("MasterDetail")
    InitializeComponent()
  End Sub

  Friend Overrides Sub OpenClick()
    Dim companies = From c In CrmDataContext.Companies _
                      Select c

      bsCustomers.DataSource = companies
    MyBase.OpenClick()
  End Sub

  Friend Overrides Sub ControlsEnabled(ByVal state As Boolean)

    Me.tsbUpdate.Enabled = state
    If (state = True) Then
      If (dgCustomer.Columns.Count <> 0 Or dgOrders.Columns.Count <> 0) Then
          Return
      End If
      Me.dgCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CompanyIDDataGridViewTextBoxColumn, Me.CompanyNameDataGridViewTextBoxColumn, Me.PrimarycontactDataGridViewTextBoxColumn, Me.WebDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.AddresstitleDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.RegionDataGridViewTextBoxColumn, Me.PostalcodeDataGridViewTextBoxColumn, Me.CountryDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.FaxDataGridViewTextBoxColumn})
      Me.dgOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.orderIDDataGridViewTextBoxColumn, Me.companyIDDataGridViewTextBoxColumn1, Me.contactIDDataGridViewTextBoxColumn, Me.orderDateDataGridViewTextBoxColumn, Me.freightDataGridViewTextBoxColumn, Me.shipDateDataGridViewTextBoxColumn, Me.discountDataGridViewTextBoxColumn})
    Else
      dgCustomer.CancelEdit()
      dgOrders.CancelEdit()
      dgCustomer.Columns.Clear()
      dgOrders.Columns.Clear()
    End If
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

  Private Sub bsOrders_ListChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles bsOrders.ListChanged
    If (e.ListChangedType = System.ComponentModel.ListChangedType.ItemChanged AndAlso e.PropertyDescriptor.Name = "Company") Then
      Dim curentOrder As CrmDataContext.Order = TryCast(bsOrders.List(e.NewIndex), CrmDataContext.Order)
      If (curentOrder.Company Is Nothing) Then
        CrmDataContext.Orders.DeleteOnSubmit(curentOrder)
      End If
    End If
  End Sub

  Private Sub dgCustomer_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgCustomer.DataError, dgOrders.DataError

    If TryCast(e.Exception, ArgumentException) IsNot Nothing Then
      MessageBox.Show("The value is not valid.", MainForm.SampleName, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Else
      MessageBox.Show(e.Exception.Message, MainForm.SampleName, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub
End Class
