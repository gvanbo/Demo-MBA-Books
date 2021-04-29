using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Demo_MBA_Books.Models;
using System.Linq;

namespace Demo_MBA_Books
{
    public partial class Products : Form
    {
        MMABooksContext context;
        Products currentProduct;

        public Products()
        {
            InitializeComponent();
        }

        private void productsDBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            //loads data directly from database
            context = new MMABooksContext();
            productsDBox.AutoGenerateColumns = true; //if true, auto generates the columns
            productsDBox.DataSource = context.Products.ToList(); 

        }
    }
}
