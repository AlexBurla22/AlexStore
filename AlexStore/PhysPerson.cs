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
    class PhysPerson : Person
    {
        private string _cnp;
        private string _firstName;
        private string _lastName;

        #region Props
        public string Cnp
        {
            get
            {
                return _cnp;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && !String.Equals(value, _cnp))
                {
                    _cnp = value;
                }
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && !String.Equals(value, _firstName))
                {
                    _firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && !String.Equals(value, _lastName))
                {
                    _lastName = value;
                }
            }
        }
        #endregion

        public override void GenerateSale(DataTable productList)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlConnection conn = new SqlConnection();
                    conn = ConnectSQL.OpenConnection();
                    DateTime dateTime = DateTime.Now;
                    cmd.Connection = conn;

                    cmd.CommandText = "insertBuyer";

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@saleDate", dateTime);
                    cmd.Parameters.AddWithValue("@buyer", LastName + " " + FirstName);
                    cmd.Parameters.AddWithValue("@contactPhone", Phone);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@code", Cnp);
                    cmd.Parameters.AddWithValue("@city", City);
                    cmd.Parameters.AddWithValue("deliveryAddress", Address);
                                      
                    SqlParameter saleID = new SqlParameter("@saleID", SqlDbType.Int);
                    saleID.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(saleID);

                    cmd.ExecuteNonQuery();

                    DataColumn dc = new DataColumn("SaleID", typeof(Int32));
                    dc.DefaultValue = (int)saleID.Value;
                    productList.Columns.Add(dc);

                    ConnectSQL.InsertProductList(productList);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            
        }

    }
}
