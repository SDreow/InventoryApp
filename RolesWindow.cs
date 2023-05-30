using CRUD;
using MainClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryAPP
{
    public partial class RolesWindow : Sample2
    {
        public RolesWindow()
        {
            InitializeComponent();
        }
        public void showData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getRoles", mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                roleIdGV.DataPropertyName = dt.Columns[0].ToString();
                roleNameGV.DataPropertyName = dt.Columns[1].ToString();
                rolesGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                mainClass.ShowMSG(ex.Message, "error");
            }
        }
     
        public override void saveBtb_Click(object sender, EventArgs e)
        {
            if (mainClass.validate(leftPanel)>0)
            {
                mainClass.ShowMSG("Fields with RED are mandatory", "error");
            }
            else
            {
                if (edit == 0)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@role", roleTxt.Text);
                    int x = crud.insert_update_delete("st_insertRoles", ht);
                    if (x > 0)
                    {
                        mainClass.ShowMSG(roleTxt.Text + " added successfully into the system", "success");
                        Hashtable ht1 = new Hashtable();
                        ListBox lb = new ListBox();
                        lb.Items.Add(roleIdGV);
                        lb.Items.Add(roleNameGV);
                        crud.loadData("st_getRoles", ht1,lb,rolesGV);
                    }
                    else
                    {
                        mainClass.ShowMSG("Unable to add" + roleTxt.Text + "in the system", "success");
                    }
                    mainClass.reset_disable(leftPanel);
                }
                else if (edit == 1) { }
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@role", roleTxt.Text);
                    ht.Add("@roleID", roleID);
                    int x = crud.insert_update_delete("st_updateRoles", ht);
                    if (x > 0)
                    {
                        mainClass.ShowMSG(roleTxt.Text + " updated successfully into the system", "success");
                        showData();
                    }
                    else
                    {
                        mainClass.ShowMSG("Unable to update " + roleTxt.Text + " in the system", "success");
                    }
                    mainClass.reset_disable(leftPanel);
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                Hashtable ht = new Hashtable();
                ht.Add("@roleID", roleID);
                int x = crud.insert_update_delete("st_deleteRole", ht);
                if (x > 0)
                {
                    mainClass.ShowMSG(roleTxt.Text + " deleted successfully from the system", "success");
                    showData();
                }
                else
                {
                    mainClass.ShowMSG("Unable to delete " + roleTxt.Text + " from the system", "success");
                }
                mainClass.reset_disable(leftPanel);
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RolesWindow_Load(object sender, EventArgs e)
        {
            Hashtable ht1 = new Hashtable();
            ListBox lb = new ListBox();
            lb.Items.Add(roleIdGV);
            lb.Items.Add(roleNameGV);
            crud.loadData("st_getRoles", ht1, lb, rolesGV);
        }
        int roleID = 0;
        private void rolesGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = rolesGV.Rows[e.RowIndex];
                roleID = Convert.ToInt32(row.Cells["roleIdGV"].Value.ToString());
                roleTxt.Text = row.Cells[2].Value.ToString();
            }



        }
    }
}
