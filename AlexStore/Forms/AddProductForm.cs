using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectDB;

namespace AlexStore
{
    public partial class AddProductForm : Form
    {

        public AddProductForm()
        {
            InitializeComponent();
            MainForm.FillComboBox("Categories", "CategoryName", "CategoryID", categBox);
            MainForm.FillComboBox("Brands", "BrandName", "BrandID", brandBox);
        }

        private void sbmtBtn_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                //Product product = new Product();

                //product.Name = nameBox.Text;
                //product.Category = (int)categBox.SelectedValue;
                //product.Brand = (int)brandBox.SelectedValue;
                //product.Price = priceBox.Value;
                //product.Stock = (int)stockBox.Value;

                //Product.AddProduct(product);

                addedLabel.Text = "Product was added!";
            }
        }

        private bool ValidateControls()
        {
            bool IsValid = true;

            if (!Validation.ValidateControl(nameBox, Validation.ValidationType.Default))
            {
                IsValid = false;
            }

            if (!Validation.ValidateControl(categBox))
            {
                IsValid = false;
            }

            if(!Validation.ValidateControl(brandBox))
            {
                IsValid = false;
            }

            if(!Validation.ValidateControl(priceBox))
            {
                IsValid = false;
            }

            if (!Validation.ValidateControl(stockBox))
            {
                IsValid = false;
            }

            return IsValid;
        }
    }
}

