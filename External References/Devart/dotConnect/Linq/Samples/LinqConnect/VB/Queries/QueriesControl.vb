Public Class QueriesControl
    Inherits BaseControl

    Public Sub New()
        MyBase.New("Queries")
        InitializeComponent()
        InitializeCombobox()
    End Sub

    Private queries As List(Of CrmLinqQuery)
    Private captions As List(Of String) = New List(Of String)(New String() _
                                                              {"All companies", _
                                                              "Orders for German companies", _
                                                              "All orders and companies", _
                                                              "Orders count for company", _
                                                              "Companies with existing Orders", _
                                                              "Average discount for company", _
                                                              "Maximum discount for company", _
                                                              "Orders grouped by year"})

    Friend Overrides Sub OpenClick()
        DataGridView.DataSource = Nothing
        tbQuery.Text = ""
        InitializeQueries()
        RefreshQuery()
        MyBase.OpenClick()
    End Sub

    Friend Overrides Sub CloseClick()
        DataGridView.DataSource = Nothing
        tbQuery.Text = ""
        MyBase.CloseClick()
    End Sub

    Private Sub InitializeQueries()
        queries = New List(Of CrmLinqQuery)

        queries.Add(New CrmLinqQuery(Me.captions(0), _
            "Dim q = From c In myCrmDataContext.Companies _" & ChrW(13) & ChrW(10) & _
            "    Select c", _
            Me.AllCompanies))

        queries.Add(New CrmLinqQuery(Me.captions(1), _
        "Dim q = From company In myCrmDataContext.Companies _" & ChrW(13) & ChrW(10) & _
        "    Join order In myCrmDataContext.Orders _" & ChrW(13) & ChrW(10) & _
        "    On company.CompanyID Equals order.CompanyID _" & ChrW(13) & ChrW(10) & _
        "    Where company.Country = ""Germany"" _" & ChrW(13) & ChrW(10) & _
        "    Select company.Country, company.CompanyName, order.OrderID, order.OrderDate", _
        Me.OrdersForGermanCompanies))

        queries.Add(New CrmLinqQuery(Me.captions(2), _
            "Dim q = From order In myCrmDataContext.Orders _" & ChrW(13) & ChrW(10) & _
            "    Order By order.Company.CompanyName _" & ChrW(13) & ChrW(10) & _
            "    Select order.OrderDate, order.Discount, order.Company.CompanyName", _
        Me.AllOrdersAndCompanies))

        queries.Add(New CrmLinqQuery(Me.captions(3), _
            "Dim q = From c In myCrmDataContext.Companies _" & ChrW(13) & ChrW(10) & _
            "    Order By c.CompanyName _" & ChrW(13) & ChrW(10) & _
            "    Select c.CompanyName, OrderCount = c.Company_Orders.Count", _
        Me.OrdersCountForCompany))

        queries.Add(New CrmLinqQuery(Me.captions(4), _
            "Dim q = From c In myCrmDataContext.Companies _" & ChrW(13) & ChrW(10) & _
            "    Group Join o In myCrmDataContext.Orders _" & ChrW(13) & ChrW(10) & _
            "    Where (g.Count() > 0) _" & ChrW(13) & ChrW(10) & _
            "    Order By c.CompanyName _" & ChrW(13) & ChrW(10) & _
            "    Select c.CompanyName, OrderCount = g.Count()", _
        Me.CompaniesWithOrders))

        queries.Add(New CrmLinqQuery(Me.captions(5), _
            "Dim q = From c In myCrmDataContext.Companies Where c.Company_Orders.Count() > 0 _" & ChrW(13) & ChrW(10) & _
            "    Order By c.CompanyName _" & ChrW(13) & ChrW(10) & _
            "    Select c.CompanyName, _" & ChrW(13) & ChrW(10) & _
            "    AverageDiscount = c.Company_Orders.Average(Function(o) o.Discount)", _
        Me.AverageDiscountForCompany))

        queries.Add(New CrmLinqQuery(Me.captions(6), _
            "Dim q = From c In myCrmDataContext.Companies _" & ChrW(13) & ChrW(10) & _
            "    From o In myCrmDataContext.Orders() _" & ChrW(13) & ChrW(10) & _
            "    Where c.CompanyID = o.Company.CompanyID _" & ChrW(13) & ChrW(10) & _
            "    Group c, o By key = c.CompanyName Into MaxDiscount = Max(o.Discount) _" & ChrW(13) & ChrW(10) & _
            "    Order By key _" & ChrW(13) & ChrW(10) & _
            "    Select key, MaxDiscount", _
        Me.MaxDiscountForCompany))

        queries.Add(New CrmLinqQuery(Me.captions(7), _
            "Dim q = From o In myCrmDataContext.Orders _" & ChrW(13) & ChrW(10) & _
            "    Order By o.OrderDate Descending _" & ChrW(13) & ChrW(10) & _
            "    Select o.OrderDate.Year, o.OrderID, o.OrderDate, o.Company.CompanyName", _
        Me.OrdersGroupedByYear))
    End Sub

    Private Function AllCompanies() As IQueryable
        Dim q = From c In myCrmDataContext.Companies _
              Select c
        Return q
    End Function

    Private Function OrdersForGermanCompanies() As IQueryable
        Dim q = From company In myCrmDataContext.Companies _
          Join order In myCrmDataContext.Orders _
          On company.CompanyID Equals order.CompanyID _
          Where company.Country = "Germany" _
          Select company.Country, company.CompanyName, order.OrderID, order.OrderDate
        Return q
    End Function

    Private Function AllOrdersAndCompanies() As IQueryable
        Dim q = From order In myCrmDataContext.Orders _
                Order By order.Company.CompanyName _
              Select order.Company.CompanyName, order.OrderID, order.OrderDate, order.Discount
        Return q
    End Function

    Private Function OrdersCountForCompany() As IQueryable
        Dim q = From c In myCrmDataContext.Companies _
                Order By c.CompanyName _
              Select c.CompanyName, OrderCount = c.Company_Orders.Count()
        Return q
    End Function

    Private Function CompaniesWithOrders() As IQueryable
        Dim q = From c In myCrmDataContext.Companies _
              Group Join o In myCrmDataContext.Orders _
              On c.CompanyID Equals o.Company.CompanyID Into g = Group _
              Where (g.Count() > 0) _
              Order By c.CompanyName _
          Select c.CompanyName, OrderCount = g.Count()
        Return q
    End Function

    Private Function AverageDiscountForCompany() As IQueryable
        Dim q = From c In myCrmDataContext.Companies Where c.Company_Orders.Count() > 0 _
                Order By c.CompanyName _
              Select c.CompanyName, _
        AverageDiscount = c.Company_Orders.Average(Function(o) o.Discount)
        Return q
    End Function

    Private Function MaxDiscountForCompany() As IQueryable
        Dim q = From c In myCrmDataContext.Companies _
              From o In myCrmDataContext.Orders() _
              Where c.CompanyID = o.Company.CompanyID _
              Group c, o By key = c.CompanyName Into MaxDiscount = Max(o.Discount) _
              Order By key _
          Select key, MaxDiscount
        Return q
    End Function

    Private Function OrdersGroupedByYear() As IQueryable
        Dim q = From o In myCrmDataContext.Orders _
              Order By o.OrderDate Descending _
              Select o.OrderDate.Year, o.OrderID, o.OrderDate, o.Company.CompanyName
        Return q
    End Function

    Private Sub InitializeCombobox()
        Me.cbQuery.Items.Clear()
        Dim text As String
        For Each text In Me.captions
            Me.cbQuery.Items.Add(text)
        Next
        Me.cbQuery.SelectedIndex = 0
    End Sub

    Private Sub RefreshQuery()
        dataGridView.DataSource = Nothing
        tbQuery.Text = String.Empty
        If Not (myCrmDataContext Is Nothing) Then
            Dim caption As String = TryCast(Me.cbQuery.SelectedItem, String)
            Dim query As CrmLinqQuery = Nothing
            Dim item As CrmLinqQuery
            For Each item In Me.queries
                If (item.Name = caption) Then
                    query = item
                    Exit For
                End If
            Next
            If (Not query Is Nothing) Then
                Me.dataGridView.DataSource = query.Query
                Me.tbQuery.Text = query.Description
            End If
        End If
    End Sub

    Friend Overrides Sub ControlsEnabled(ByVal state As Boolean)
        Me.cbQuery.Enabled = state
    End Sub

    Private Sub cbQuery_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbQuery.SelectedIndexChanged
        If Me.queries IsNot Nothing Then
            Try
                RefreshQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message, MainForm.SampleName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub dataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView.DataError

        If TryCast(e.Exception, ArgumentException) IsNot Nothing Then
            MessageBox.Show("The value is not valid.", MainForm.SampleName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show(e.Exception.Message, MainForm.SampleName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class

Friend Class CrmLinqQuery
    Public Sub New(ByVal name As String, ByVal description As String, ByVal query As IQueryable)
        Me.Name = name
        Me.Description = description
        Me.Query = query
    End Sub

    Private qName As String
    Private qDescription As String
    Private qQuery As IQueryable

    Public Property Name() As String
        Get
            Return qName
        End Get
        Set(ByVal value As String)
            qName = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return Me.qDescription
        End Get
        Set(ByVal value As String)
            Me.qDescription = value
        End Set
    End Property

    Public Property Query() As IQueryable
        Get
            Return qQuery
        End Get
        Set(ByVal value As IQueryable)
            qQuery = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.Name
    End Function
End Class
