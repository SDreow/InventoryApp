using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainClass;
using Settings;

namespace authentication
{
    public class Auth
    {
        public static string employeeName { get; set; }
        public static string employeeRole { get; set; }
        public static int employeeID { get; set; }
        public static int roleID { get; set; }

        public static bool getLoginDetails(string username,string password)
        {
            settings.connection = File.ReadAllText(settings.path);
            bool flag = false;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getLoginDetails", mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                mainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while(dr.Read()) 
                    {
                        flag = true;
                        employeeID = Convert.ToInt32(dr[0].ToString());
                        employeeName = dr[1].ToString();
                        employeeRole = dr[3].ToString();
                        roleID = Convert.ToInt32(dr[2].ToString());
                    }
                }
                else
                {
                    flag = false;
                    mainClass.ShowMSG("Invalid username or password", "error");
                }
                mainClass.con.Close();
            }
            catch (Exception ex)
            {
                mainClass.ShowMSG(ex.Message, "error");
            }
            return flag;
        }
    }
}
