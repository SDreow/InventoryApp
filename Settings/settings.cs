using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Settings
{
    public class settings
    {
        public static string connection = "";
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ "\\inventory_connect";
        public static void saveFile(string server,string database,string username = null,string password = null)
        {
            if (username == null)
            {
                connection = "Data Source=" + server + ";Initial Catalog=" + database + ";Integrated Security=true";
            }
            else
            {
                connection = "Data Source=" + server + ";Initial Catalog=" + database + ";User ID=" + username + ";Password=" + password;
            }


            File.WriteAllText(path, connection);
        }
    }
}
