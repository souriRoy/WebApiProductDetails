using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using ProductDataAccess;

namespace ProductCatalogue
{
    public partial class All_Product_Details : Form
    {
        public async  void GetAllProducts()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:49264/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
            HttpResponseMessage response = client.GetAsync("api/Product").Result;

            Product[] Products = await response.Content.ReadAsAsync<Product[]>();
            dataGridView1.DataSource = Products;
            

        }
        public All_Product_Details()
        {
            InitializeComponent();
            GetAllProducts();
        }

        private void All_Product_Details_Load(object sender, EventArgs e)
        {
           
        }
    }
}
