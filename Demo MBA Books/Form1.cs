using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo_MBA_Books.Models;

namespace Demo_MBA_Books
{
    public partial class Form1 : Form
    {
        MMABooksContext context;
        Customer currentCustomer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new MMABooksContext();
            currentCustomer = context.Customers.First(); //Load the first Customer
        //Loading all states data in the combo-box
            stateComboBox.DataSource = context.States.ToList();
            stateComboBox.DisplayMember = "StateName";
            stateComboBox.ValueMember = "StateCode";
            //Load all customer IDs
            Object[] cIds = context.Customers.Select(c => (Object)c.CustomerId).ToArray();
            customerIdCBox.Items.AddRange(cIds);
            DisplayCustomer();

        }

        /// <summary>
        /// Display the current customer in the Form fields
        /// </summary>
        private void DisplayCustomer()
        {
            if (currentCustomer is null) return;
            //txtCustID.Text = currentCustomer.CustomerId.ToString();
            customerIdCBox.SelectedItem = currentCustomer.CustomerId;
            txtName.Text = currentCustomer.Name;
            txtAddress.Text = currentCustomer.Address;
            txtCity.Text = currentCustomer.City;
            txtState.Text = currentCustomer.State;
            txtZIP.Text = currentCustomer.ZipCode;
            stateComboBox.SelectedValue = currentCustomer.State;

            if (customerIdCBox.SelectedIndex > 0) btnBack.Enabled = true;
            else btnBack.Enabled = false;

            if (customerIdCBox.SelectedIndex == customerIdCBox.Items.Count -1) btnForward.Enabled = false;
            else btnForward.Enabled = true;


            //if (customerIdCBox.Items.Count <= index)
            //{
            //    btnForward.Enabled = false;
            //    return;
            //}

        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            int index = customerIdCBox.SelectedIndex +1; // Get the next Index of the current customer ID
            int id = Int32.Parse(customerIdCBox.Items[index].ToString()); //currentCustomer.CustomerId + 1;
            currentCustomer = context.Customers.Find(id);
            DisplayCustomer();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            int index = customerIdCBox.SelectedIndex - 1; // Get the previous Index of the current customer ID
            int id = Int32.Parse(customerIdCBox.Items[index].ToString()); //currentCustomer.CustomerId + -1;
            currentCustomer = context.Customers.Find(id);
            DisplayCustomer();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            currentCustomer.Name = txtName.Text;
            currentCustomer.Address = txtAddress.Text;
            currentCustomer.City = txtCity.Text;
            //currentCustomer.State = txtState.Text;
            currentCustomer.ZipCode = txtZIP.Text;
            context.SaveChanges();
            DisplayCustomer();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            context.Customers.Remove(currentCustomer);
            context.SaveChanges();
            currentCustomer = context.Customers.First();
            DisplayCustomer();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Customer addOne = new Customer()
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                City = txtCity.Text,
                //State = txtState.Text,
                ZipCode = txtZIP.Text,
                State = stateComboBox.SelectedValue.ToString(),
            };

            context.Customers.Add(addOne);
            context.SaveChanges();
            currentCustomer = addOne;
            DisplayCustomer();
        }

        private void stateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customerIdCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(customerIdCBox.SelectedItem);
            currentCustomer = context.Customers.Find(id);
            DisplayCustomer();
        }
    }
}
