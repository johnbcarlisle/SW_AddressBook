using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SW_AddressBook.controls
{
    public partial class control_AddAddress : UserControl
    {
        public control_AddAddress()
        {
            InitializeComponent();
        }

        private void buttonSaveAddress_Click(object sender, EventArgs e)
        {
            //reset all textbox backcolors to white
            foreach (TextBox tb in groupBoxAddressInfo.Controls.OfType<TextBox>())
            {
                tb.BackColor = Color.White;
            }

            // check if any box is empty, or spaces
            int errors = 0;

            // check each required textbox for data
            foreach (TextBox tb in groupBoxAddressInfo.Controls.OfType<TextBox>())
            {

                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.BackColor = Color.Yellow;
                    errors += 1;

                    // these are not required
                    if (tb.Name == "textBoxCustCompany" && string.IsNullOrWhiteSpace(tb.Text))
                    {
                        tb.BackColor = Color.White;
                        errors -= 1;
                    }
                    if (tb.Name == "textBoxCustMiddleName" && string.IsNullOrWhiteSpace(tb.Text))
                    {
                        tb.BackColor = Color.White;
                        errors -= 1;
                    }
                    if (tb.Name == "textBoxCustSuite" && string.IsNullOrWhiteSpace(tb.Text))
                    {
                        tb.BackColor = Color.White;
                        errors -= 1;
                    }
                    if (tb.Name == "textBoxCustEmail" && string.IsNullOrWhiteSpace(tb.Text))
                    {
                        tb.BackColor = Color.White;
                        errors -= 1;
                    }
                }
            }

            if (textBoxCustEmail.ToString().Trim() == "")
            {
                string custEmail = textBoxCustEmail.Text.Trim();
                if (!custEmail.Contains("@") && !Globals.emailExt.Contains(custEmail))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }
            }

            if (errors != 0)
            {
                MessageBox.Show("Please enter all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Address newAddress = new Address()
            {
                custCompany = textBoxCustCompany.Text,
                custFN = textBoxCustFirstName.Text,
                custMN = textBoxCustMiddleName.Text,
                custLN = textBoxCustLastName.Text,
                custAdd = textBoxCustAddress.Text,
                custSuite = textBoxCustSuite.Text,
                custCity = textBoxCustCity.Text,
                custState = textBoxCustState.Text,
                custZIP = textBoxCustZIP.Text,
                custPhone = textBoxCustPhone.Text,
                custEmail = textBoxCustEmail.Text,
            };

            SW_Address_BL bl = new SW_Address_BL();

            if (bl.AddNewAddress(newAddress))
            {
                foreach (TextBox tb in groupBoxAddressInfo.Controls.OfType<TextBox>())
                {
                    // clear textboxes after successful insert
                    tb.Clear();
                }
                    MessageBox.Show("Saved.");
            }
            else
            {
                MessageBox.Show("Not Saved.");
            }
        }

        private void textBoxCustState_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCustState.Text))
            {
                if (!Globals.states.Contains(textBoxCustState.Text.ToUpper()))
                {
                    MessageBox.Show("Please enter a valid state.");
                    textBoxCustState.Clear();
                    this.ActiveControl = textBoxCustState;
                    return;
                }
            }
        }

        private void textBoxCustZIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            // this only allows numbers to be entered
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\D+"))
            {
                e.Handled = true;
                SystemSounds.Hand.Play();
            }
        }

        private void textBoxCustPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // this only allows numbers to be entered
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\D+"))
            {
                e.Handled = true;
                SystemSounds.Hand.Play();
            }
        }
    }
}
