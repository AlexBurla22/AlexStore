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
        
        public override bool Exists()
        {
            SqlConnection conn = new SqlConnection();
            conn = ConnectSQL.OpenConnection();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "checkIfBuyerExists";

                cmd.Parameters.Add("@code", SqlDbType.NVarChar);
                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.Parameters["@code"].Value = Cui;

                cmd.ExecuteNonQuery();
                conn.Close();

                if (cmd.Parameters["@output"].Value == DBNull.Value)
                {
                    return false;
                }
                return true;
            }
        }

        public override void InsertBuyer()
        {
            SqlConnection conn = new SqlConnection();
            conn = ConnectSQL.OpenConnection();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insertBuyer";

                cmd.Parameters.AddWithValue("@name", CompanyName);
                cmd.Parameters.AddWithValue("@phone", Phone);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@code", Cui);
                cmd.Parameters.AddWithValue("@city", City);
                cmd.Parameters.AddWithValue("@address", Address);
                cmd.Parameters.AddWithValue("@type", PersonType.Juridical);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
    }
}
