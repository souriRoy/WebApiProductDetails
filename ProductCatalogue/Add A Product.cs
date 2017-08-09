using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using ProductDataAccess;
using System.IO;

namespace ProductCatalogue
{
    public partial class Add_A_Product : Form
    {
        public Add_A_Product()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Add_A_Product_Load(object sender, EventArgs e)
        {

        }

        public Product ProductDetails()
        {
            Product ProductDetail= new Product();
            ProductDetail.ProductId = Convert.ToInt32(txtProductId.Text);
            ProductDetail.ProductName = txtProductName.Text;
            ProductDetail.ProductPrice = Convert.ToInt32(txtProductPrice.Text);
            ProductDetail.ProductPhotoPath = pictureBox1.ImageLocation.ToString();
            string imagepath = pictureBox1.ImageLocation.ToString();
            imagepath = imagepath.Substring(imagepath.LastIndexOf("\\"));
            imagepath = imagepath.Remove(0, 1);
            ProductDetail.ProductPhotoName = imagepath;
            ProductDetail.ProductUpdatedDate = dttProductDate.Value = DateTime.Now;
            return ProductDetail;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Product Pro = ProductDetails();
            PostReq(Pro);
            this.Close();
            
        }

        public static async void PostReq(Product Products)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:49264/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
                HttpResponseMessage response = await client.PostAsJsonAsync("api/Product", Products);
                if (response.IsSuccessStatusCode)
                {
                     bool result = await response.Content.ReadAsAsync<bool>();
                    if (result)
                    {
                        MessageBox.Show(" Product successfully inserted ");
                    }
                    else
                        MessageBox.Show(" Error in inserting data ");
                     
                }
 
            }
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Product Pro = ProductDetails();
            PutReq(Pro.ProductId, Pro);
            this.Close();

        }
        public static async void PutReq(int id, Product Products)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:49264/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
                var response =  client.PostAsJsonAsync("api/Product" , Products).Result;
                if (response.IsSuccessStatusCode)
                {
                    bool result = await response.Content.ReadAsAsync<bool>();
                    if (result)
                    {
                        MessageBox.Show(" Product updated inserted ");
                    }
                    else
                        MessageBox.Show(" Error in updating data ");

                }

            }

        }



    }
}
