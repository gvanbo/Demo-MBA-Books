using Demo_MBA_Books.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Demo_MBA_Books
{
    public partial class InvoicesExplicit : Form
    {
        MMABooksContext context;
        Invoice currentInvoice;
        public InvoicesExplicit()
        {
            InitializeComponent();
        }

        private void InvoicesExplicit_Load(object sender, EventArgs e)
        {
            context = new MMABooksContext();
            invoicesDGrid.AutoGenerateColumns = true; //for testing
            invoicesDGrid.DataSource = context.Invoices.ToList();
        }

        private void invoicesDGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void invoicesDGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (invoicesDGrid.SelectedCells.Count > 0)
            {
                int index = invoicesDGrid.SelectedCells[0].RowIndex;
                int invoiceId = (int)invoicesDGrid.Rows[index].Cells[0].Value;

                currentInvoice = context.Invoices.Find(invoiceId);

                invoiceDetailsDGrid.DataSource = currentInvoice.InvoiceLineItems.ToList();
            }
        }

    }
}
