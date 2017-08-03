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
using AlexStore.Forms;

namespace AlexStore
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            FillGridView("getProductsFullSP", productGridView);
            FillGridView("getFullSales", saleGridView);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addForm = new AddProductForm();
            addForm.FormClosed += new FormClosedEventHandler(addFormClosed);
            addForm.ShowDialog();
        }

        private void addFormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshGridView("getProductsFullSP", productGridView);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            AddStockForm updateForm = new AddStockForm();
            updateForm.FormClosed += new FormClosedEventHandler(updateFormClosed);
            updateForm.ShowDialog();
        }

        private void updateFormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshGridView("getProductsFullSP", productGridView);
        }

        private void saleBtn_Click(object sender, EventArgs e)
        {
            SaleForm saleForm = new SaleForm();
            saleForm.FormClosed += new FormClosedEventHandler(saleFormClosed);
            saleForm.ShowDialog();
        }

        private void saleFormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshGridView("getFullSales", saleGridView);
            RefreshGridView("getProductsFullSP", productGridView);
        }

        private void RefreshGridView(string spName, DataGridView gridView)
        {
            FillGridView(spName, gridView);
        }

        public static void FillGridView(string storedProcedure, DataGridView gridView)
        {
            DataTable table = ConnectSQL.ReturnDataTable(storedProcedure);
            gridView.DataSource = table;
        }

        public static void FillComboBox(string tableName, string member, string value, ComboBox box)
        {
            DataTable table = new DataTable();
            table = ConnectSQL.ReturnDataTable("SELECT * FROM " + tableName);

            DataRow row = table.NewRow();
            row[member] = "Please select...";
            table.Rows.InsertAt(row, 0);

            box.DataSource = table;
            box.DisplayMember = member;
            box.ValueMember = value;
        }

        private void saleGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = saleGridView.Rows[e.RowIndex];
            ProductListForm pLF = new ProductListForm((int)row.Cells["SaleID"].Value);
            pLF.Show();
        }
    }

}
