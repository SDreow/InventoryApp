using CRUD;
using MainClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryAPP
{
    public partial class UsersWindow : Sample2
    {
        public UsersWindow()
        {
            InitializeComponent();
        }
        int userID = 0;
        private void showData()
        {
            Hashtable ht = new Hashtable();
            ListBox lb = new ListBox();
            lb.Items.Add(userIDGV);
            lb.Items.Add(NameGV);
            lb.Items.Add(usernameGV);
            lb.Items.Add(passwordGV);
            lb.Items.Add(phoneGV);
            lb.Items.Add(EmailGV);
            lb.Items.Add(statusGV);
            lb.Items.Add(roleIDGV);
            lb.Items.Add(RoleGV);

            crud.loadData("st_getUsers", ht, lb, usersGV);
        }
        public override void saveBtb_Click(object sender, EventArgs e)
        {
            if (mainClass.validate(leftPanel) > 0)
            {
                mainClass.ShowMSG("Fields with RED are mandatory","error");
            }
            else
            {
                if (edit == 0) //SAVE
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", nameTxt.Text);
                    ht.Add("@username", usernameTxt.Text);
                    ht.Add("@password", passwordTxt.Text);
                    ht.Add("@phone", phoneTxt.Text);
                    ht.Add("@email", emailTxt.Text);
                    if (statusDD.SelectedIndex == 0)
                    {
                        ht.Add("@status", 1);
                    }
                    else if (statusDD.SelectedIndex == 1)
                    {
                        ht.Add("@status", 0);
                    }


                    ht.Add("@roleID", Convert.ToInt32(roleDD.SelectedValue.ToString()));

                    int x = crud.insert_update_delete("st_insertUser", ht);
                    showData();
                    if (x > 0)
                    {
                        mainClass.ShowMSG(nameTxt.Text + " added successfully", "success");
                    }
                    else
                    {
                        mainClass.ShowMSG("Unable to add " + nameTxt.Text, "success");
                    }
                }
                else if (edit == 1)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", nameTxt.Text);
                    ht.Add("@username", usernameTxt.Text);
                    ht.Add("@password", passwordTxt.Text);
                    ht.Add("@phone", phoneTxt.Text);
                    ht.Add("@email", emailTxt.Text);
                    if (statusDD.SelectedIndex == 0)
                    {
                        ht.Add("@status", 1);
                    }
                    else if (statusDD.SelectedIndex == 1)
                    {
                        ht.Add("@status", 0);
                    }


                    ht.Add("@roleID", Convert.ToInt32(roleDD.SelectedValue.ToString()));
                    ht.Add("@ID", userID);

                    int x = crud.insert_update_delete("st_updateUser", ht);
                    if (x > 0)
                    {
                        mainClass.ShowMSG(nameTxt.Text + " updated successfully", "success");
                        showData();
                    }
                    else
                    {
                        mainClass.ShowMSG("Unable to update " + nameTxt.Text, "success");
                    }
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@ID", userID);
                    int x = crud.insert_update_delete("st_deleteUser", ht);
                    if (x > 0)
                    {
                        mainClass.ShowMSG(nameTxt.Text + " deleted successfully from the system", "success");
                        showData();
                    }
                    else
                    {
                        mainClass.ShowMSG("Unable to delete " + nameTxt.Text + " from the system", "success");
                    }
                    mainClass.reset_disable(leftPanel);
                }
                
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameTxt.Text == "")
            {
                nameTxt.BackColor = Color.Red;
            }
            else
            {
                nameTxt.BackColor = Color.White;
            }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "")
            {
                usernameTxt.BackColor = Color.Red;
            }
            else
            {
                usernameTxt.BackColor = Color.White;
            }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "")
            {
                passwordTxt.BackColor = Color.Red;
            }
            else
            {
                passwordTxt.BackColor = Color.White;
            }
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "")
            {
                phoneTxt.BackColor = Color.Red;
            }
            else
            {
                phoneTxt.BackColor = Color.White;
            }
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            if (emailTxt.Text == "")
            {
                emailTxt.BackColor = Color.Red;
            }
            else
            {
                emailTxt.BackColor = Color.White;
            }
        }

        private void roleDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleDD.SelectedIndex == -1)
            {
                roleDD.BackColor = Color.Red;
            }
            else
            {
                roleDD.BackColor = Color.White;
            }
        }

        private void statusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusDD.SelectedIndex == -1)
            {
                statusDD.BackColor = Color.Red;
            }
            else
            {
                statusDD.BackColor = Color.White;
            }
        }

        private void rolesGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = usersGV.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["NameGV"].Value.ToString();
                usernameTxt.Text = row.Cells["usernameGV"].Value.ToString();
                passwordTxt.Text = row.Cells["passwordGV"].Value.ToString();
                phoneTxt.Text = row.Cells["phoneGV"].Value.ToString();
                emailTxt.Text = row.Cells["EmailGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
                roleDD.SelectedValue = Convert.ToInt32(row.Cells["roleIDGV"].Value.ToString());
            }
        }

        private void UsersWindow_Load(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            crud.loadList("st_getRoles", ht, roleDD);
            showData();
        }
    }
}
