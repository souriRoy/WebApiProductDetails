using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ProductCatalogue
{
    public partial class delete_A_Product : Form
    {
        public delete_A_Product()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Productid = Convert.ToInt32(txtdelete.Text);
            DeleteProduct(Productid);
            this.Close();
        }
         
        public async void DeleteProduct(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:49264/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
                HttpResponseMessage response = await client.DeleteAsync("api/Product/" + id);
                if (response.IsSuccessStatusCode)
                {
                    bool result = await response.Content.ReadAsAsync<bool>();
                    if (result)
                    {
                        MessageBox.Show(" Product Deleted ");
                    }
                    else
                        MessageBox.Show(" Error in deleting data ");

                }

            }
        }
    }
}
