using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AlexStore
{
    class Matrice
    {
        private static int buyersNr;
        private static int productsNr;

        private static DataTable dt;

        private static int[,] mat;

        public static void Build()
        {
            buyersNr = getBuyersNr();
            productsNr = getProductsNr();

            mat = new int[buyersNr, productsNr];
            Array.Clear(mat, 0, buyersNr * productsNr);

            for (int buyerID = 0; buyerID < buyersNr; buyerID++)
            {
                dt = ReturnBuyerList(buyerID + 1);

                foreach (DataRow row in dt.Rows)
                {
                    mat[buyerID , (int)row["ProductID"] - 1] += (int)row["Quantity"];
                }
            }
        }

        private static DataTable ReturnBuyerList(int buyerID)
        {
            SqlConnection conn = new SqlConnection();
            conn = ConnectDB.ConnectSQL.OpenConnection();

            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    SqlCommand cmd = new SqlCommand("ProductsByBuyer", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@buyerID", buyerID);

                    da.SelectCommand = cmd;

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    conn.Close();

                    return dt;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        private static int getBuyersNr()
        {
            SqlConnection conn = new SqlConnection();
            conn = ConnectDB.ConnectSQL.OpenConnection();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT COUNT(BuyerID) FROM Buyers";

                return (int)cmd.ExecuteScalar();
            }
            
        }

        private static int getProductsNr()
        {
            SqlConnection conn = new SqlConnection();
            conn = ConnectDB.ConnectSQL.OpenConnection();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SELECT COUNT(ProductID) FROM Products";

                return (int)cmd.ExecuteScalar();
            }
        }


    }
}