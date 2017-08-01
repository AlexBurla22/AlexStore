using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AlexStore
{
    class Validation
    {
        public enum ValidationType
        {
            Email = 0,
            Phone = 1,
            CNP = 2,
            City = 3,
            Default
        }

        public static bool ValidateControl(TextBox txtbox, ValidationType type)
        {
            switch (type)
            {
                case ValidationType.Email:
                    {
                        Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                        if(email.IsMatch(txtbox.Text))
                        {
                            return true;
                        }

                        return false;
                    }

                case ValidationType.Phone:
                    {
                        Regex phone = new Regex(@"\d{10}$");

                        if(phone.IsMatch(txtbox.Text))
                        {
                            return true;
                        }

                        return false;
                    }

                case ValidationType.CNP:
                    {
                        Regex cnp = new Regex(@"\d{13}$");

                        if(cnp.IsMatch(txtbox.Text))
                        {
                            return true;
                        }

                        return false;
                    }

                case ValidationType.City:
                    {
                        Regex city = new Regex(@"\p{L}+$");

                        if (city.IsMatch(txtbox.Text))
                        {
                            return true;
                        }

                        return false;
                    }
                    
                default:
                    {
                        if (String.IsNullOrWhiteSpace(txtbox.Text))
                        {
                            return false;
                        }

                        return true;
                    }

            }
        }

        public static bool ValidateControl(ComboBox box)
        {
            if (box.SelectedIndex == 0)
            {
                return false;
            }

            return true;
        }

        public static bool ValidateControl(NumericUpDown upDown)
        {
            if(upDown.Value == 0)
            {
                return false;
            }

            return true;
        }

        public void HighlightControl(Control control)
        {

        }
    }
}


