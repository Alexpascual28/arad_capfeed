using System;
using System.Linq;
using System.Collections.Generic;
using CrmDataContext;
using System.Configuration;
using System.Windows.Forms;

namespace LinqDemo.Queries {

  public partial class QueriesControl : BaseControl {

    public QueriesControl()
      : base("Queries") {

      InitializeComponent();
      InitializeCombobox();
    }

    private List<CrmLinqQuery> queries;

    private List<string> captions = new List<string>(new string[] { 
      "All companies",
      "Orders for German companies",
      "All orders and companies",
      "Orders count for company",
      "Companies with existing Orders",
      "Average discount for company",
      "Maximum discount for company",
      "Orders grouped by year"
    });

    internal override void OpenClick() {

      dataGridView.DataSource = null;
      tbQuery.Text = "";
      InitializeQueries();
      RefreshQuery();

      base.OpenClick();
    }

    internal override void CloseClick() {

      crmDataContext = null;
      dataGridView.DataSource = null;
      tbQuery.Text = "";

      base.CloseClick();
    }

    private void InitializeQueries() {

      queries = new List<CrmLinqQuery>()
      {
        new CrmLinqQuery(
          captions[0],
          "var q = from c in CrmDataContext.Companies \r\n" +
          "    select c;", 
          AllCompanies()),
        new CrmLinqQuery(
          captions[1], 
          "var q = from company in CrmDataContext.Companies\r\n" +
          "    join order in CrmDataContext.Orders\r\n" +
          "    on company.CompanyID equals order.CompanyID\r\n" +
          "    where company.Country == \"Germany\"\r\n" +
          "    select new { company.Country, company.CompanyName, order.OrderID, order.OrderDate };",
          OrdersForGermanCompanies()),
        new CrmLinqQuery(
          captions[2], 
          "var q = from order in CrmDataContext.Orders\r\n" +
          "    orderby order.Company.CompanyName\r\n" +
          "    select new { order.Company.CompanyName, order.OrderID, order.OrderDate, order.Discount};",
          AllOrdersAndCompanies()),
        new CrmLinqQuery(
          captions[3],
          "var q = from c in CrmDataContext.Companies\r\n" +
          "    orderby c.CompanyName\r\n" +
          "    select new { c.CompanyName, OrderCount = c.Company_Orders.Count };",
          OrdersCountForCompany()),
        new CrmLinqQuery(
          captions[4],
          "var q = from c in CrmDataContext.Companies\r\n" +
          "    join o in CrmDataContext.Orders on c.CompanyID equals o.Company.CompanyID into g\r\n" +
          "    where g.Count() > 0\r\n" +
          "    orderby c.CompanyName\r\n" +
          "    select new { c.CompanyName, OrderCount = g.Count() }",
          CompaniesWithOrders()),
        new CrmLinqQuery(
          captions[5],
          "var q = from c in CrmDataContext.Companies where c.Company_Orders.Count > 0\r\n" +
          "    orderby c.CompanyName\r\n" +
          "    select new { c.CompanyName,\r\n" +
          "      AverageDiscount = c.Orders.Average(o => o.Discount) };",
          AverageDiscountForCompany()),
        new CrmLinqQuery(
          captions[6],
          "var q = from c in CrmDataContext.Companies\r\n" +
          "    orderby c.CompanyName\r\n" +
          "    from o in CrmDataContext.Orders\r\n" +
          "    where c.CompanyID == o.Company.CompanyID\r\n" +
          "    group new { c, o } by c.CompanyName into g\r\n" +
          "    select new { g.Key, MaxDiscount = g.Max(gr => gr.o.Discount) };",
          MaxDiscountForCompany()),
        new CrmLinqQuery(
          captions[7],
          "var q = from o in CrmDataContext.Orders\r\n" +
          "    orderby o.OrderDate descending\r\n" +
          "    select new { o.OrderDate.Year, o.OrderID, o.OrderDate,\r\n" +
          "      o.Company.CompanyName };",
          OrdersGroupedByYear())
      };

    }

    private IQueryable AllCompanies() {

      var q = from c in CrmDataContext.Companies
              select c;
      return q;
    }

    private IQueryable OrdersForGermanCompanies() {

      var q = from company in CrmDataContext.Companies
              join order in CrmDataContext.Orders on company.CompanyID equals order.CompanyID
              where company.Country == "Germany"
              select new { company.Country, company.CompanyName, order.OrderID, order.OrderDate };
      return q;
    }

    private IQueryable AllOrdersAndCompanies() {

      var q = from order in CrmDataContext.Orders
              orderby order.Company.CompanyName
              select new { order.Company.CompanyName, order.OrderID, order.OrderDate, order.Discount};
      return q;
    }

    private IQueryable OrdersCountForCompany() {

      var q = from c in CrmDataContext.Companies
              orderby c.CompanyName
              select new { c.CompanyName, OrderCount = c.Company_Orders.Count };
      return q;
    }

    private IQueryable CompaniesWithOrders() {

      var q = from c in CrmDataContext.Companies
              join o in CrmDataContext.Orders on c.CompanyID equals o.Company.CompanyID into g
              where g.Count() > 0
              orderby c.CompanyName
              select new { c.CompanyName, OrderCount = g.Count() };
      return q;
    }

    private IQueryable AverageDiscountForCompany() {

      var q = from c in CrmDataContext.Companies
              where c.Company_Orders.Count > 0
              orderby c.CompanyName
              select new
              {
                c.CompanyName,
                AverageDiscount = c.Company_Orders.Average(o => o.Discount)
              };
      return q;
    }

    private IQueryable MaxDiscountForCompany() {

      var q = from c in CrmDataContext.Companies
              from o in CrmDataContext.Orders
              where c.CompanyID == o.Company.CompanyID
              group new { c, o } by c.CompanyName into g
              orderby g.Key
              select new { g.Key, MaxDiscount = g.Max(gr => gr.o.Discount) };
      return q;
    }

    private IQueryable OrdersGroupedByYear() {

      var q = from o in CrmDataContext.Orders
              orderby o.OrderDate descending
              select new { o.OrderDate.Year, o.OrderID, o.OrderDate, o.Company.CompanyName };
      return q;
    }

    private void InitializeCombobox() {

      cbQuery.Items.Clear();
      foreach (string s in captions) {
        cbQuery.Items.Add(s);
      }
      cbQuery.SelectedIndex = 0;
    }

    private void RefreshQuery() {

      dataGridView.DataSource = null;
      tbQuery.Text = String.Empty;
      if (crmDataContext == null)
        return;

      string caption = cbQuery.SelectedItem as string;
      CrmLinqQuery query = null;
      foreach (CrmLinqQuery item in queries)
        if (item.Name == caption) {
          query = item;
          break;
        }

      if (query != null) {
        dataGridView.DataSource = query.Query;
        tbQuery.Text = query.Description;
      }
    }

    internal override void ControlsEnabled(bool state) {
     
      cbQuery.Enabled = state;
    }

    private void cbQuery_SelectedIndexChanged(object sender, EventArgs e) {

      try {
        RefreshQuery();
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message, MainForm.SampleName, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void dataGridView_DataError(object sender, System.Windows.Forms.DataGridViewDataErrorEventArgs e) {

      if (e.Exception is ArgumentException)
        MessageBox.Show("The value is not valid.", MainForm.SampleName, MessageBoxButtons.OK, MessageBoxIcon.Error);
      else
        MessageBox.Show(e.Exception.Message, MainForm.SampleName, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
  }

  internal class CrmLinqQuery {

    public CrmLinqQuery(string name, string description, IQueryable query) {

      Name = name;
      Description = description;
      Query = query;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public IQueryable Query { get; set; }

    public override string ToString() {

      return Name;
    }
  }
}
