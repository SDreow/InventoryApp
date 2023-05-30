using MainClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.Common;

namespace CRUD
{
    public class crud
    {
        public static int insert_update_delete(string proc,Hashtable ht)
        {
            int result = 0;
			try
			{
				SqlCommand cmd = new SqlCommand(proc,mainClass.con);
				cmd.CommandType = CommandType.StoredProcedure;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                mainClass.con.Open();
                result = cmd.ExecuteNonQuery();
                mainClass.con.Close();
            }
			catch (Exception ex)
			{
                mainClass.ShowMSG(ex.Message, "error");
			    
			}
            return result;
        }
        public static void loadData(string proc,Hashtable ht,ListBox lb,DataGridView gv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colname = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colname].DataPropertyName = dt.Columns[i].ToString();
                }
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                mainClass.ShowMSG(ex.Message, "error");
            }
        }
        public static void loadList(string proc, Hashtable ht,ComboBox cb)
        {
            try
            {
                cb.Items.Clear();
                SqlCommand cmd = new SqlCommand(proc, mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.ValueMember = dt.Columns[0].ToString();
                cb.DisplayMember = dt.Columns[1].ToString();
                cb.DataSource = dt;
                cb.SelectedIndex = -1;
                

            }
            catch (Exception ex)
            {
                mainClass.ShowMSG(ex.Message, "error");
            }
        }
    }
}
