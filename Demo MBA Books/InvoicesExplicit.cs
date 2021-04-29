using Demo_MBA_Books.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Demo_MBA_Books
{
    public partial class InvoicesExplicit : Form
    {
        MMABooksContext context;
        public InvoicesExplicit()
        {
            InitializeComponent();
        }

        private void invoicesDGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            context = new MMABooksContext();
            invoicesDGrid.AutoGenerateColumns = false;
            invoicesDGrid.DataSource = context.Invoices.ToList();
        }

        private void invoicesDGrid_SelectionChanged(object sender, EventArgs e)
        {
            //DataGridView dg = (System.Windows.Forms.DataGridView)sender;
            //if  (dg.SelectedRows.Count > 0)
        }
    }
}
