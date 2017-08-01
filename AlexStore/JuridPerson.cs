using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConnectDB;

namespace AlexStore
{
    class JuridPerson : Person
    {
        private string _cui;
        private string _companyName;

        #region Props
        public string Cui
        {
            get
            {
                return _cui;
            }
            set
            {
                if (!String.IsNullOrEmpty(value) && !String.Equals(value, _cui))
                {
                    _cui = value;
                }
            }
        }

        public string CompanyName
        {
            get
            {
                return _companyName;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && !String.Equals(value, _companyName))
                {
                    _companyName = value;
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
                    cmd.Parameters.AddWithValue("@buyer", CompanyName);
                    cmd.Parameters.AddWithValue("@contactPhone", Phone);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@code", Cui);
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
