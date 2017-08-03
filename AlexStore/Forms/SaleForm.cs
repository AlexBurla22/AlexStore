using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ConnectDB;

namespace AlexStore
{
    public partial class SaleForm : Form
    {
        public DataTable dataTable;
        int pos = 0;
        int quantity;
        decimal total = 0;
        List<Int32> productIDs = new List<Int32>();

        public SaleForm()
        {
            InitializeComponent();
            dataTable = CreateTable();
            productsGrid.DataSource = dataTable;
            priceLabel.Text = "Total: " + total;
            MainForm.FillComboBox("Products WHERE StatusID = 1;", "ProductName", "ProductID", prodsBox);
            MainForm.FillComboBox("Buyers", "Name", "BuyerID", buyerCB);
        }

        private void physRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (physRadio.Checked == true)
            {
                physicalPanel.Visible = true;
            }
            else
            {
                physicalPanel.Visible = false;
            }
        }

        private void jurRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (jurRadio.Checked == true)
            {
                juridPanel.Visible = true;
            }
            else
            {
                juridPanel.Visible = false;
            }
        }

        private void sbmitBtn_Click(object sender, EventArgs e)
        {
            if (!Validation.ValidateControl(buyerCB))
            {
                errorSale.SetError(buyerCB, "Please select a buyer.");
            }
            else if(ValidateProductList(productIDs))
            {
                errorSale.SetError(buyerCB, "");
                //GenerateSale();
            }
            else
            {
                errorSale.SetError(buyerCB, "");
            }
        }

        private bool ValidateJuridPanel()
        {
            bool IsValid = true;

            if(!Validation.ValidateControl(compNameBox, Validation.ValidationType.Default))
            {
                IsValid = false;
                errorSale.SetError(compNameBox, "Please enter company name.");
            }
            else
            {
                errorSale.SetError(compNameBox, "");
            }

            if (!Validation.ValidateControl(emailJuridBox, Validation.ValidationType.Email))
            {
                IsValid = false;
                errorSale.SetError(emailJuridBox, "Please enter email address.");
            }
            else
            {
                errorSale.SetError(emailJuridBox, "");
            }

            if (!Validation.ValidateControl(juridPhoneBox, Validation.ValidationType.Phone))
            {
                IsValid = false;
                errorSale.SetError(juridPhoneBox, "Please enter a phone number.");
            }
            else
            {
                errorSale.SetError(juridPhoneBox, "");
            }

            if (!Validation.ValidateControl(city2Box, Validation.ValidationType.City))
            {
                IsValid = false;
                errorSale.SetError(city2Box, "Please enter city.");
            }
            else
            {
                errorSale.SetError(city2Box, "");
            }

            if (!Validation.ValidateControl(address2Box, Validation.ValidationType.Default))
            {
                IsValid = false;
                errorSale.SetError(address2Box, "Please enter address.");
            }
            else
            {
                errorSale.SetError(address2Box, "");
            }

            if (!Validation.ValidateControl(cuiBox, Validation.ValidationType.Default))
            {
                IsValid = false;
                errorSale.SetError(cuiBox, "Please enter CUI.");
            }
            else
            {
                errorSale.SetError(cuiBox, "");
            }

            return IsValid;
        }

        private bool ValidatePhysicalPanel()
        {
            bool IsValid = true;

            if (!Validation.ValidateControl(firstNameBox, Validation.ValidationType.Default))
            {
                IsValid = false;
                errorSale.SetError(firstNameBox, "Please enter first name.");
            }
            else
            {
                errorSale.SetError(firstNameBox, "");
            }

            if (!Validation.ValidateControl(lastNameBox, Validation.ValidationType.Default))
            {
                IsValid = false;
                errorSale.SetError(lastNameBox, "Please enter last name.");
            }
            else
            {
                errorSale.SetError(lastNameBox, "");
            }

            if (!Validation.ValidateControl(emailBox, Validation.ValidationType.Email))
            {
                IsValid = false;
                errorSale.SetError(emailBox, "Please enter a valid email.");
            }
            else
            {
                errorSale.SetError(emailBox, "");
            }

            if (!Validation.ValidateControl(phoneBox, Validation.ValidationType.Phone))
            {
                IsValid = false;
                errorSale.SetError(phoneBox, "Please enter a phone number.");
            }
            else
            {
                errorSale.SetError(phoneBox, "");
            }

            if (!Validation.ValidateControl(cityBox, Validation.ValidationType.City))
            {
                IsValid = false;
                errorSale.SetError(cityBox, "Please enter city.");
            }
            else
            {
                errorSale.SetError(cityBox, "");
            }

            if (!Validation.ValidateControl(addresBox, Validation.ValidationType.Default))
            {
                IsValid = false;
                errorSale.SetError(addresBox, "Please enter address.");
            }
            else
            {
                errorSale.SetError(addresBox, "");
            }

            if (!Validation.ValidateControl(cnpBox, Validation.ValidationType.CNP))
            {
                IsValid = false;
                errorSale.SetError(cnpBox, "Please enter CNP.");
            }
            else
            {
                errorSale.SetError(cnpBox, "");
            }

            return IsValid;
        }

        private bool ValidateProductList(List<Int32> list)
        {
            if(!list.Any())
            {
                MessageBox.Show("Please add a product.");
                return false;
            }
            return true;
        }

        private void RemoveQuantityFromStock()
        {
            foreach (DataRow row in dataTable.Rows)
            {
                SqlConnection conn = new SqlConnection();
                conn = ConnectSQL.OpenConnection();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE Products SET Products.Stock = Products.Stock - @quantity WHERE Products.ProductID = @productID;";

                    cmd.Parameters.AddWithValue("@quantity", row["Quantity"]);
                    cmd.Parameters.AddWithValue("@productID", row["ProductID"]);

                    cmd.ExecuteNonQuery();
                }

                ConnectSQL.CloseConnection(conn);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Int32 prodID;
            bool Added = false;

            if (Int32.TryParse(prodsBox.SelectedValue.ToString(), out prodID))
            {
                foreach (Int32 prdID in productIDs)
                {
                    if (prodID == prdID)
                    {
                        Added = true;
                    }
                }

                Product product = new Product();
                quantity = (Int32)quantityUp.Value;
                product = Product.GetProdByID(prodID);

                if (product.Stock >= quantity && !Added)
                {
                    ProductToTable(prodID, product, dataTable);

                    total += quantity * product.Price;

                    pos++;
                    productIDs.Add(prodID);
                    productsGrid.DataSource = dataTable;
                    priceLabel.Text = "Total: " + total.ToString();
                }
                else if (Added)
                {
                    MessageBox.Show("Product already added. Change the quantity.");
                }
                else
                {
                    MessageBox.Show("Quantity bigger than stock!");
                }

            }

        }

        private DataTable CreateTable()
        {
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn();

            dc = new DataColumn("ProductID", typeof(Int32));
            dc.ReadOnly = true;
            dt.Columns.Add(dc);

            dc = new DataColumn("ProductName", typeof(String));
            dc.ReadOnly = true;
            dt.Columns.Add(dc);

            dc = new DataColumn("Quantity", typeof(Int32));
            dt.Columns.Add(dc);

            dc = new DataColumn("Price", typeof(Decimal));
            dc.ReadOnly = true;
            dt.Columns.Add(dc);

            return dt;
        }

        public void ProductToTable(Int32 productID, Product product, DataTable dt)
        {
            DataRow dr = dt.NewRow();

            dr["ProductID"] = productID;
            dr["ProductName"] = product.Name;
            dr["Quantity"] = quantity;
            dr["Price"] = product.Price;

            dt.Rows.InsertAt(dr, pos);
        }

        private void addBuyerBTN_Click(object sender, EventArgs e)
        {
            if (jurRadio.Checked == true)
            {
                if (ValidateJuridPanel())
                {
                    JuridPerson jPerson = new JuridPerson();

                    jPerson.CompanyName = compNameBox.Text;
                    jPerson.Email = emailJuridBox.Text;
                    jPerson.Phone = juridPhoneBox.Text;
                    jPerson.City = city2Box.Text;
                    jPerson.Address = address2Box.Text;
                    jPerson.Cui = cuiBox.Text;

                    if (!jPerson.Exists())
                    {
                        jPerson.InsertBuyer();
                        addedLabel.Visible = true;
                        MainForm.FillComboBox("Buyers", "Name", "BuyerID", buyerCB);
                    }
                    else
                    {
                        MessageBox.Show("Company already exists. Please select it from the buyers list.");
                    }
                }
            }
            else if (physRadio.Checked == true)
            {
                if (ValidatePhysicalPanel())
                {
                    PhysPerson pPerson = new PhysPerson();

                    pPerson.FirstName = firstNameBox.Text;
                    pPerson.LastName = lastNameBox.Text;
                    pPerson.Email = emailBox.Text;
                    pPerson.City = cityBox.Text;
                    pPerson.Address = addresBox.Text;
                    pPerson.Phone = phoneBox.Text;
                    pPerson.Cnp = cnpBox.Text;

                    if(!pPerson.Exists())
                    {
                        pPerson.InsertBuyer();
                        addedLabel.Visible = true;
                        MainForm.FillComboBox("Buyers", "Name", "BuyerID", buyerCB);
                    }
                    else
                    {
                        MessageBox.Show("Person already exists. Please select it from the buyers list.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a person type.");
            }
        }
    }
}
