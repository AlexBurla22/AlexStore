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

                cmd.Parameters["@code"].Value = Cnp;

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

                cmd.Parameters.AddWithValue("@name", LastName + " " +FirstName);
                cmd.Parameters.AddWithValue("@phone", Phone);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@code", Cnp);
                cmd.Parameters.AddWithValue("@city", City);
                cmd.Parameters.AddWithValue("@address", Address);
                cmd.Parameters.AddWithValue("@type", PersonType.Physical);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
    }
}
