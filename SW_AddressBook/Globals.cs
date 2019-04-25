using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_AddressBook
{
    class Globals
    {
        public static List<string> emailExt = new List<string>()
        {

            ".com",
            ".net",
            ".org",
            ".gov",
            ".mil",
            ".edu"

        };

        public static List<string> states = new List<string>
                {
                "AL","AK","AZ","AR","CA","CO","CT","DE","FL","GA",
                "HI","ID","IL","IN","IA","KS","KY","LA","ME","MD",
                "MA","MI","MN","MS","MO","MT","NE","NV","NH","NJ",
                "NM","NY","NC","ND","OH","OK","OR","PA","RI","SC",
                "SD","TN","TX","UT","VT","VA","WA","WV","WI","WY", "DC"
                };

        public static string fullPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SW_AddressBook", "Addresses", "Addresses.txt");
        public static string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SW_AddressBook", "Addresses");
    }
}
