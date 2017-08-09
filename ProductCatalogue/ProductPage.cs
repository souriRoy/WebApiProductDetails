using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductCatalogue
{
    public partial class ProductPage : Form
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            var MyViewProductForm = new All_Product_Details();
            MyViewProductForm.Show();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var AddProduct = new Add_A_Product();
            AddProduct.Show();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            var UpdateProdcuct = new Add_A_Product();
            UpdateProdcuct.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var DeleteProduct = new delete_A_Product();
            DeleteProduct.Show();
        }
    }
}
