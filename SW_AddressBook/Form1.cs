using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_AddressBook
{

    public partial class Form1 : Form
    {
        public static DataTable dt = new DataTable();
        public static DataTable results = new DataTable();
        public char[] delim = { '|' };

        public Form1()
        {
            //set headers on dt datatable
            dt.Columns.Add("Company");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Middle Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Address");
            dt.Columns.Add("Suite");
            dt.Columns.Add("City");
            dt.Columns.Add("State");
            dt.Columns.Add("ZIP");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            dt.Columns.Add("Guid");

            //set headers on results datatable
            results.Columns.Add("Company");
            results.Columns.Add("First Name");
            results.Columns.Add("Middle Name");
            results.Columns.Add("Last Name");
            results.Columns.Add("Address");
            results.Columns.Add("Suite");
            results.Columns.Add("City");
            results.Columns.Add("State");
            results.Columns.Add("ZIP");
            results.Columns.Add("Phone");
            results.Columns.Add("Email");
            results.Columns.Add("Guid");

            InitializeComponent();
            LoadAddresses();
        }

        public void LoadAddresses()
        {
            try
            {
                if (File.Exists(Globals.fullPath))
                {
                    string[] lines = File.ReadAllLines(Globals.fullPath);
                    foreach (string line in lines)
                    {
                        string[] addrArray = line.Split(delim);

                        DataRow row = dt.NewRow();

                        row["Company"] = addrArray[1];
                        row["First Name"] = addrArray[2];
                        row["Middle Name"] = addrArray[3];
                        row["Last Name"] = addrArray[4];
                        row["Address"] = addrArray[5];
                        row["Suite"] = addrArray[6];
                        row["City"] = addrArray[7];
                        row["State"] = addrArray[8];
                        row["ZIP"] = addrArray[9];
                        row["Phone"] = addrArray[10];
                        row["Email"] = addrArray[11];
                        row["Guid"] = addrArray[0];

                        dt.Rows.Add(row);

                        
                    }

                    // load datagridview
                    dgvAddresses.DataSource = dt;
                    //foreach (DataColumn col in dgvAddresses.Columns)
                    //{

                    //}
                    dgvAddresses.Columns["Guid"].Visible = false;
                }
            }
            catch
            {

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim();
            string column = string.Empty;
            if (!string.IsNullOrEmpty(searchTerm))
            {
                foreach (RadioButton rdb in groupBoxSearch.Controls.OfType<RadioButton>())
                {
                    // search by column
                    if (rdb.Checked == true)
                    {
                        switch (rdb.Text)
                        {
                            case ("First Name"):
                                column = "First Name";
                                break;
                            case ("Last Name"):
                                column = "Last Name";
                                break;
                            case ("Address"):
                                column = "Address";
                                break;
                            case ("City"):
                                column = "City";
                                break;
                            case ("State"):
                                column = "State";
                                break;
                        }
                    }
                }

                AddressBook_DA da = new AddressBook_DA();
                da.SearchBy(column, searchTerm);

                dgvAddresses.DataSource = results;
            }
            else
            {
                MessageBox.Show("Please enter a search term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            dgvAddresses.DataSource = dt;
        }
    }
}

