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
    public partial class AccountsWindow : Sample2
    {
        public AccountsWindow()
        {
            InitializeComponent();
        }

        private void AccountsWindow_Load(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            crud.loadList("st_getAccountType",ht,accountTypeDD);
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

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            if (addressTxt.Text == "")
            {
                addressTxt.BackColor = Color.Red;
            }
            else
            {
                addressTxt.BackColor = Color.White;
            }
        }

        private void accountTypeDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accountTypeDD.SelectedIndex == -1)
            {
                accountTypeDD.BackColor = Color.Red;
            }
            else
            {
                accountTypeDD.BackColor = Color.White;
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
        int accountID = 0;
        public override void saveBtb_Click(object sender, EventArgs e)
        {
            if (mainClass.validate(leftPanel)>0)
            {
                if (edit == 0) //SAVE
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name",nameTxt.Text);
                    ht.Add("@phone",phoneTxt.Text);
                    ht.Add("@adress",addressTxt.Text);
                    ht.Add("@type",Convert.ToInt32(accountTypeDD.SelectedValue.ToString()));
                    if (statusDD.SelectedItem.ToString() == "Active")
                    {
                        ht.Add("@status",1);
                    }
                    else if (statusDD.SelectedItem.ToString() == "Inactive")
                    {
                        ht.Add("@status",0);
                    }
                    ht.Add("@id", 0);
                    ht.Add("@flag",1);
                    int x = crud.insert_update_delete("crud_accounts",ht);
                    if (x > 0)
                    {
                        mainClass.ShowMSG("nameTxt.Text" + " added successfully into the system", "success");
                    }
                    else
                    {
                        mainClass.ShowMSG("Unable to add " + nameTxt.Text, "error");
                    }
                }
                else if (edit == 1) //UPDATE
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", nameTxt.Text);
                    ht.Add("@phone", phoneTxt.Text);
                    ht.Add("@adress", addressTxt.Text);
                    ht.Add("@type", Convert.ToInt32(accountTypeDD.SelectedValue.ToString()));
                    if (statusDD.SelectedItem.ToString() == "Active")
                    {
                        ht.Add("@status", 1);
                    }
                    else if (statusDD.SelectedItem.ToString() == "Inactive")
                    {
                        ht.Add("@status", 0);
                    }
                    ht.Add("@id", accountID);
                    ht.Add("@flag", 1);
                    int x = crud.insert_update_delete("crud_accounts", ht);
                    if (x > 0)
                    {
                        mainClass.ShowMSG("nameTxt.Text" + " added successfully into the system", "success");
                    }
                    else
                    {
                        mainClass.ShowMSG("Unable to add " + nameTxt.Text, "error");
                    }
                }
            }
            else
            {
                mainClass.ShowMSG("Fields with RED are mandatory","error");
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you shure, you want to delete " + nameTxt.Text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", nameTxt.Text);
                    ht.Add("@phone", phoneTxt.Text);
                    ht.Add("@adress", addressTxt.Text);
                    ht.Add("@type", Convert.ToInt32(accountTypeDD.SelectedValue.ToString()));
                    if (statusDD.SelectedItem.ToString() == "Active")
                    {
                        ht.Add("@status", 1);
                    }
                    else if (statusDD.SelectedItem.ToString() == "Inactive")
                    {
                        ht.Add("@status", 0);
                    }
                    ht.Add("@id", accountID);
                    ht.Add("@flag", 1);
                    int x = crud.insert_update_delete("crud_accounts", ht);
                    if (x > 0)
                    {
                        mainClass.ShowMSG("nameTxt.Text" + " added successfully into the system", "success");
                    }
                    else
                    {
                        mainClass.ShowMSG("Unable to add " + nameTxt.Text, "error");
                    }
                }
            }
        }
        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
