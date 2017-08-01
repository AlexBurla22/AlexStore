using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectDB;

namespace AlexStore.Forms
{
    public partial class ProductListForm : Form
    {
        DataTable dt;
        public ProductListForm(int saleID)
        {
            InitializeComponent();
            dt = getList(saleID);
            productListGridView.DataSource = dt;
        }

        private DataTable getList(int saleID)
        {
            SqlConnection conn = new SqlConnection();
            conn = ConnectSQL.OpenConnection();

            using (SqlCommand cmd = new SqlCommand("getSaleProductsBySaleID", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@saleID", saleID);
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    DataTable table = new DataTable();
                    da.Fill(table);

                    return table;
                }

            }
        }
    }
}
