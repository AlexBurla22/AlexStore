using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AlexStore
{
    public abstract class Person
    {
        private string _city;
        private string _address;
        private string _phone;
        private string _email;

        #region Props
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && !String.Equals(value, _city))
                {
                    _city = value;
                }
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && !String.Equals(value, _address))
                {
                    _address = value;
                }
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && !String.Equals(value, _phone))
                {
                    _phone = value;
                }
            }

        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && !String.Equals(value, _email))
                {
                    _email = value;
                }
            }

        }
        #endregion

        public abstract void GenerateSale(DataTable productList);
    }
}
