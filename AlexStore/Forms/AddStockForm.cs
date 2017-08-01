using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexStore
{
    public partial class AddStockForm : Form
    {
        public AddStockForm()
        {
            InitializeComponent();
            MainForm.FillComboBox("Products", "ProductName", "ProductID", productBox);
            currentStock.Text = "None";
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                //int prodID = (int)productBox.SelectedValue;
                //int stockToAdd = (int)addedStock.Value;

                //Product.AddStock(prodID, stockToAdd);

                updateLabel.Text = "Added stock!";
            }
           
        }

        private void productBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productID;
            if (Int32.TryParse(productBox.SelectedValue.ToString(), out productID))
            {
                currentStock.Text = Product.GetProductStock(productID);
            }
        }

        private bool ValidateControls()
        {
            bool IsValid = true;

            if(!Validation.ValidateControl(productBox))
            {
                IsValid = false;
            }

            if(!Validation.ValidateControl(addedStock))
            {
                IsValid = false;
            }

            return IsValid;
        }
    }
}
