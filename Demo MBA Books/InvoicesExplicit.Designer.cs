
namespace Demo_MBA_Books
{
    partial class InvoicesExplicit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.invoicesDGrid = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shipping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDetailsDGridc = new System.Windows.Forms.DataGridView();
            this.invoicesLbl = new System.Windows.Forms.Label();
            this.invoiceDetailsLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailsDGridc)).BeginInit();
            this.SuspendLayout();
            // 
            // invoicesDGrid
            // 
            this.invoicesDGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoicesDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicesDGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.InvoiceID,
            this.InvoiceDate,
            this.SalesTax,
            this.Shipping,
            this.ProductTotal,
            this.InvoiceTotal});
            this.invoicesDGrid.Location = new System.Drawing.Point(39, 60);
            this.invoicesDGrid.Name = "invoicesDGrid";
            this.invoicesDGrid.RowTemplate.Height = 25;
            this.invoicesDGrid.Size = new System.Drawing.Size(711, 246);
            this.invoicesDGrid.TabIndex = 0;
            this.invoicesDGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoicesDGrid_CellContentClick);
            this.invoicesDGrid.SelectionChanged += new System.EventHandler(this.invoicesDGrid_SelectionChanged);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // InvoiceID
            // 
            this.InvoiceID.DataPropertyName = "InvoiceID";
            this.InvoiceID.HeaderText = "Inv ID";
            this.InvoiceID.Name = "InvoiceID";
            this.InvoiceID.ReadOnly = true;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.DataPropertyName = "InvoiceDate";
            this.InvoiceDate.HeaderText = "Date";
            this.InvoiceDate.Name = "InvoiceDate";
            // 
            // SalesTax
            // 
            this.SalesTax.DataPropertyName = "SalesTax";
            this.SalesTax.HeaderText = "Tax";
            this.SalesTax.Name = "SalesTax";
            // 
            // Shipping
            // 
            this.Shipping.DataPropertyName = "Shipping";
            this.Shipping.HeaderText = "Shipping";
            this.Shipping.Name = "Shipping";
            // 
            // ProductTotal
            // 
            this.ProductTotal.DataPropertyName = "ProductTotal";
            this.ProductTotal.HeaderText = "Sub Total";
            this.ProductTotal.Name = "ProductTotal";
            // 
            // InvoiceTotal
            // 
            this.InvoiceTotal.DataPropertyName = "InvoiceTotal";
            this.InvoiceTotal.HeaderText = "Inv Total";
            this.InvoiceTotal.Name = "InvoiceTotal";
            // 
            // invoiceDetailsDGridc
            // 
            this.invoiceDetailsDGridc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDetailsDGridc.Location = new System.Drawing.Point(39, 350);
            this.invoiceDetailsDGridc.Name = "invoiceDetailsDGridc";
            this.invoiceDetailsDGridc.RowTemplate.Height = 25;
            this.invoiceDetailsDGridc.Size = new System.Drawing.Size(711, 150);
            this.invoiceDetailsDGridc.TabIndex = 1;
            // 
            // invoicesLbl
            // 
            this.invoicesLbl.AutoSize = true;
            this.invoicesLbl.Location = new System.Drawing.Point(39, 30);
            this.invoicesLbl.Name = "invoicesLbl";
            this.invoicesLbl.Size = new System.Drawing.Size(50, 15);
            this.invoicesLbl.TabIndex = 2;
            this.invoicesLbl.Text = "Invoices";
            // 
            // invoiceDetailsLbl
            // 
            this.invoiceDetailsLbl.AutoSize = true;
            this.invoiceDetailsLbl.Location = new System.Drawing.Point(39, 328);
            this.invoiceDetailsLbl.Name = "invoiceDetailsLbl";
            this.invoiceDetailsLbl.Size = new System.Drawing.Size(83, 15);
            this.invoiceDetailsLbl.TabIndex = 3;
            this.invoiceDetailsLbl.Text = "Invoice Details";
            // 
            // InvoicesExplicit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.invoiceDetailsLbl);
            this.Controls.Add(this.invoicesLbl);
            this.Controls.Add(this.invoiceDetailsDGridc);
            this.Controls.Add(this.invoicesDGrid);
            this.Name = "InvoicesExplicit";
            this.Text = "InvoicesExplicit";
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailsDGridc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView invoicesDGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceTotal;
        private System.Windows.Forms.DataGridView invoiceDetailsDGridc;
        private System.Windows.Forms.Label invoicesLbl;
        private System.Windows.Forms.Label invoiceDetailsLbl;
    }
}