using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ConnectDB
{
    public class ConnectSQL
    {
        public static SqlConnection
            GetDBConnection(string datasource, string database, string user, string pswd)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database +
                ";Persist Security Info=true;User ID=" + user + ";Password=" + pswd;

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }

        public static SqlConnection OpenConnection()
        {
            try
            {
                SqlConnection conn = GetDBConnection("(local)", "AlexDB", "sa", "enter03IT");

                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static void CloseConnection(SqlConnection conn)
        {
            conn.Close();
        }

        public static DataTable ReturnDataTable(string storedProcedure)
        {
            SqlConnection conn = new SqlConnection();
            conn = OpenConnection();

            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(storedProcedure, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    CloseConnection(conn);
                    return dt;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

        public static void InsertProductList(DataTable productList)
        {
            SqlConnection conn = new SqlConnection();
            conn = OpenConnection();
            using (SqlBulkCopy bc = new SqlBulkCopy(conn))
            {
                bc.DestinationTableName = "SaleProducts";

                bc.ColumnMappings.Add("SaleID", "SaleID");
                bc.ColumnMappings.Add("ProductID", "ProductID");
                bc.ColumnMappings.Add("Quantity", "Quantity");
                bc.ColumnMappings.Add("Price", "Price");

                bc.WriteToServer(productList);
            }
        }
    }

}
