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
                Product product = new Product();

                product.Name = nameBox.Text;
                product.Category = (int)categBox.SelectedValue;
                product.Brand = (int)brandBox.SelectedValue;
                product.Price = priceBox.Value;
                product.Stock = (int)stockBox.Value;

                Product.AddProduct(product);

                addedLabel.Text = "Product was added!";
            }
        }

        private bool ValidateControls()
        {
            bool IsValid = true;

            if (!Validation.ValidateControl(nameBox, Validation.ValidationType.Default))
            {
                IsValid = false;
                errorAddProduct.SetError(nameBox, "Please enter product name.");
            }
            else
            {
                errorAddProduct.SetError(nameBox, "");
            }

            if (!Validation.ValidateControl(categBox))
            {
                IsValid = false;
                errorAddProduct.SetError(categBox, "Please select a category.");
            }
            else
            {
                errorAddProduct.SetError(categBox, "");
            }

            if(!Validation.ValidateControl(brandBox))
            {
                IsValid = false;
                errorAddProduct.SetError(brandBox, "Please selecet a brand.");
            }
            else
            {
                errorAddProduct.SetError(brandBox, "");
            }

            if(!Validation.ValidateControl(priceBox))
            {
                IsValid = false;
                errorAddProduct.SetError(priceBox, "Please enter product price.");
            }
            else
            {
                errorAddProduct.SetError(priceBox, "");
            }

            if (!Validation.ValidateControl(stockBox))
            {
                IsValid = false;
                errorAddProduct.SetError(stockBox, "Please enter product stock.");
            }
            else
            {
                errorAddProduct.SetError(stockBox, "");
            }

            return IsValid;
        }
    }
}

