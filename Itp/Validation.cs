using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
namespace Itp
{
    class Validation
    {

        // Validate Digit Characters
        public void DigitCharacters(Char  ch,Label label)
        {
            if(Char.IsDigit(ch)  || (ch== 8))
            {
                label.Text="         ";
            }
            else
            {
                label.ForeColor = Color.Red;
                label.Text = "You trying to input wrong values  ";
            }

        }

        // Validate  Contact  Number
        public void ContactNumbers(string text,Label label)
        {
            try
            {
                Regex rx = new Regex(@"^(\+[0-9]{9})$");
                bool x = rx.IsMatch(text);

                if (x == true)
                {
                    label.Text = "        ";
                }
                else
                {

                    label.ForeColor = Color.Red;
                    label.Text = " Invalid Contact Number ";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OK");
            }

        }

        //Validate E- mail Address

        public void emailAddress(string text,Label label)
        {

            try
            {

                Regex rx = new Regex(@"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");

                bool x = rx.IsMatch(text);

                if (x == true)
                {
                    label.Text = "   ";
                }
                else
                {
                    label.Text = " Invalid email address";

                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void creditCardValidation(string text, Label label)
        {

            Regex rx = new Regex(@"^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\d{3})\d{11})$");
            bool x = rx.IsMatch(text);

            if (x == true)
            {
                label.Text = "     ";

            }
            else
            {
                label.ForeColor = Color.Red;
                label.Text = "Invalid Card Number";
            }
        }

        //check value is numeric
        public bool isNumeric(string txt)
        {
            return txt.All(Char.IsDigit);
        }

    }
}
