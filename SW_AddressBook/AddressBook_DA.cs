using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_AddressBook
{
    class AddressBook_DA
    {
        DataTable _dt = Form1.dt;
        DataTable _results = Form1.results;

        public bool AddAddress(Address addr, String path)
        
        {
            string guid = Guid.NewGuid().ToString();

            string pds = string.Join("|", guid, addr.custCompany, addr.custFN, addr.custMN, addr.custLN, addr.custAdd, addr.custSuite,
                                            addr.custCity, addr.custState, addr.custZIP, addr.custPhone, addr.custEmail, addr.custCompany);
                        
            bool exists = System.IO.Directory.Exists(Globals.directory);

            // create the directory if it does not exist
            if (!exists)
            {
                try
                {
                    System.IO.Directory.CreateDirectory((Globals.directory));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            if (!File.Exists(Globals.fullPath))
            {
                File.Create(Globals.fullPath).Close();
            }

            try
            {
                int tryCount = 0;
            TryAgain:

                if (tryCount > 5)
                {
                    goto Failed;
                }

                SW_Address_BL bl = new SW_Address_BL();
                FileInfo fi = new FileInfo(Globals.fullPath);
                bool locked = bl.IsFileLocked(fi);

                if (!locked)
                {
                    StreamWriter sw = new StreamWriter(Globals.fullPath, true
);

                    sw.WriteLine(pds);
                    sw.Close();
                    sw.Dispose();
                                       
                    DataRow row = _dt.NewRow();

                    row["Company"] = addr.custCompany;
                    row["First Name"] = addr.custFN;
                    row["Middle Name"] = addr.custMN;
                    row["Last Name"] = addr.custLN;
                    row["Address"] = addr.custAdd;
                    row["City"] = addr.custCity;
                    row["State"] = addr.custState;
                    row["ZIP"] = addr.custZIP;
                    row["Phone"] = addr.custPhone;
                    row["Email"] = addr.custEmail;
                    row["Guid"] = guid;

                    _dt.Rows.Add(row);
                }
                else
                {
                    Thread.Sleep(1 * 1000);

                    tryCount++;
                    goto TryAgain;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;

        Failed:
            return false;
        }

        public void SearchBy(string column, string searchTerm)
        {
            // empty the results dt from last search
            _results.Clear();

            foreach (DataColumn dc in _dt.Columns)
            {
                if (dc.ColumnName == column)
                {
                    foreach (DataRow dr in _dt.Rows)
                    {
                        string columnValue = dr[column].ToString().Trim().ToLower();
                        if (columnValue.Contains(searchTerm.ToLower()))
                        //if (string.Equals(dr[column].ToString().Trim(), searchTerm, StringComparison.InvariantCultureIgnoreCase))
                        {
                            _results.Rows.Add(dr.ItemArray);
                        }
                    }
                }
            }
        }
    }
}