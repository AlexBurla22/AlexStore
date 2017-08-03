using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConnectDB;
using System.Data;

namespace AlexStore
{
    public class Product
    {
        public enum StatusCodes
        {
            Active = 1,
            Inactive
        }

        private string _name;
        private int _brand;
        private int _category;
        private decimal _price;
        private int _stock;

        #region Props
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && !String.Equals(value, _name))
                {
                    _name = value;
                }
            }
        }

        public int Brand
        {
            get
            {
                return _brand;
            }
            set
            {   if ((_brand != value))
                {
                    _brand = value;
                }
            }
        }

        public int Category
        {
            get
            {
                return _category;
            }
            set
            {
                if (_category != value)
                {
                    _category = value;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (_price != value)
                {
                    _price = value;
                }
            }
        }

        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                if (_stock != value)
                {
                    _stock = value;
                }
            }
        }
        #endregion

        #region Methods
        public static void AddProduct(Product product)
        {
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlConnection conn = new SqlConnection();
                    conn = ConnectSQL.OpenConnection();

                    cmd.CommandText = "INSERT INTO Products(ProductName, CategoryID, BrandID, Price, Stock, StatusID)" +
                        "VALUES(@productName, @categoryID, @brandID, @price, @stock, @status);";
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@productName", product.Name);
                    cmd.Parameters.AddWithValue("@categoryID", product.Category);
                    cmd.Parameters.AddWithValue("@brandID", product.Brand);
                    cmd.Parameters.AddWithValue("@price", product.Price);
                    cmd.Parameters.AddWithValue("@stock", product.Stock);
                    cmd.Parameters.AddWithValue("@status", StatusCodes.Active);

                    cmd.ExecuteNonQuery();

                    ConnectSQL.CloseConnection(conn);
                }
            }
        }

        public static string GetProductStock(int productID)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                SqlConnection conn = new SqlConnection();
                conn = ConnectSQL.OpenConnection();

                cmd.CommandText = "getProductStockSP";
                cmd.Connection = conn;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@productID", productID);

                SqlParameter stock = new SqlParameter("@stock", SqlDbType.Int);
                stock.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(stock);

                cmd.ExecuteNonQuery();

                ConnectSQL.CloseConnection(conn);

                return stock.Value.ToString();
            }
        }

        public static void AddStock(int productID, int stockToAdd)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                SqlConnection conn = new SqlConnection();
                conn = ConnectSQL.OpenConnection();

                cmd.Connection = conn;
                cmd.CommandText = "UPDATE Products SET Stock = Stock + @stockToAdd WHERE ProductID = @productID;";

                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.Parameters.AddWithValue("@stockToAdd", stockToAdd);

                cmd.ExecuteNonQuery();

                ConnectSQL.CloseConnection(conn);
            }
        }

        public static Product GetProdByID(int productID)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                SqlConnection conn = new SqlConnection();
                conn = ConnectSQL.OpenConnection();

                cmd.Connection = conn;
                cmd.CommandText = "getProductByID";

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@productID", productID);

                SqlParameter prodName = new SqlParameter("@prodName", SqlDbType.NVarChar);
                prodName.Direction = ParameterDirection.Output;
                prodName.Size = 50;
                cmd.Parameters.Add(prodName);

                SqlParameter category = new SqlParameter("@category", SqlDbType.Int);
                category.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(category);

                SqlParameter price = new SqlParameter("@price", SqlDbType.SmallMoney);
                price.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(price);

                SqlParameter brand = new SqlParameter("@brand", SqlDbType.Int);
                brand.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(brand);

                SqlParameter stock = new SqlParameter("@stock", SqlDbType.Int);
                stock.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(stock);

                cmd.ExecuteNonQuery();

                Product product = new Product();

                product.Name = prodName.Value.ToString();
                product.Category = (int)category.Value;
                product.Brand = (int)brand.Value;
                product.Price = (decimal)price.Value;
                product.Stock = (int)stock.Value;

                return product;
            }
        }
        #endregion
    }

}
