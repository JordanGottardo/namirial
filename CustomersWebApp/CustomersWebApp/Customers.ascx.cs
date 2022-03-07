using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace CustomersWebApp
{
    public partial class Customers : System.Web.UI.UserControl
    {
        private static readonly HttpClient client = new HttpClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("pageload");
            if (IsPostBack)
            {
                return;
            }

            LoadCustomers(0);
        }

        protected void GridView1OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("GridView1OnPageIndexChanging");

            GridView1.PageIndex = e.NewPageIndex;
            LoadCustomers(0);
        }


        private void LoadCustomers(int page)
        {
            var response = client.GetAsync("http://localhost:5000/customers").Result;
            response.EnsureSuccessStatusCode();
            var responseBody = response.Content.ReadAsStringAsync().Result;
            var dataTable = JsonConvert.DeserializeObject<DataTable>(responseBody);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }
    }
}