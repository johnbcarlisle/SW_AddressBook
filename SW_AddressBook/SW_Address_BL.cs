using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_AddressBook
{
    class SW_Address_BL
    {
        
        public bool AddNewAddress(Address address)
        {           
            bool added;

            AddressBook_DA da = new AddressBook_DA();
            if (da.AddAddress(address, Globals.directory))
            {
                added = true;
            }
            else
            {
                added = false;
            }

            return added;
        }

        public bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }        
    }
}
