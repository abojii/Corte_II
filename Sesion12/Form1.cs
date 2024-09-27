using Sesion12.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion12
{
    public partial class Form1 : Form
    {
        List<Product> products;
        public Form1()
        {
            InitializeComponent();
            products = new List<Product>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Id = int.Parse(tbcode.Text);
            product.Name = tbname.Text;
            product.Description = tbdescription.Text;
            product.Price = double.Parse(tbprice.Text);
            products.Add(product);
            showData();
            clearText();

           
        }
        private void showData()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;
        }
        private void clearText()
        {
            tbcode.Clear();
            tbname.Clear();
            tbdescription.Clear();
            tbprice.Clear();
            tbcode.Focus();
        }

    }
}
