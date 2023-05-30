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
    public partial class AccountsTypeWindow : Sample2
    {
        public AccountsTypeWindow()
        {
            InitializeComponent();
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

        int accountTypeID = 0;
        public override void saveBtb_Click(object sender, EventArgs e)
        {
            if (mainClass.validate(leftPanel) > 0)
            {
                if (edit == 0) //SAVE
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name",nameTxt.Text);
                    if (statusDD.SelectedItem.ToString() == "Active")
                    {
                        ht.Add("@status", 1);
                    }
                    else if (statusDD.SelectedItem.ToString() == "Inactive")
                    {
                        ht.Add("@status", 0);
                    }


                    ht.Add("@id",0);
                    ht.Add("@flag",1);
                    int x = crud.insert_update_delete("crud_accountType",ht);
                    if (x > 0) 
                    {
                        mainClass.ShowMSG("nameTxt.Text" + " added successfully into the system", "success");
                    }
                    else
                    {
                        mainClass.ShowMSG("Unable to add "+ nameTxt.Text, "error");
                    }
                    mainClass.reset_disable(leftPanel);

                }
                else if (edit == 1) //UPDATE
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", nameTxt.Text);
                    if (statusDD.SelectedItem.ToString() == "Active")
                    {
                        ht.Add("@status", 1);
                    }
                    else if (statusDD.SelectedItem.ToString() == "Inactive")
                    {
                        ht.Add("@status", 0);
                    }


                    ht.Add("@id", accountTypeID);
                    ht.Add("@flag", 2);
                    int x = crud.insert_update_delete("crud_accountType", ht);
                    if (x > 0)
                    {
                        mainClass.ShowMSG(nameTxt.Text + " updated successfully into the system", "success");
                    }
                    else
                    {
                        mainClass.ShowMSG("Unable to update " + nameTxt.Text, "error");
                    }
                    mainClass.reset_disable(leftPanel);
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you shure, you want to delete "+nameTxt.Text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes) 
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@name", nameTxt.Text);
                    if (statusDD.SelectedItem.ToString() == "Active")
                    {
                        ht.Add("@status", 1);
                    }
                    else if (statusDD.SelectedItem.ToString() == "Inactive")
                    {
                        ht.Add("@status", 0);
                    }


                    ht.Add("@id", accountTypeID);
                    ht.Add("@flag", 3);
                    int x = crud.insert_update_delete("crud_accountType", ht);
                    if (x > 0)
                    {
                        mainClass.ShowMSG(nameTxt.Text + " deleted successfully from the system", "success");
                    }
                    else
                    {
                        mainClass.ShowMSG("Unable to delete " + nameTxt.Text, "error");
                    }
                    mainClass.reset_disable(leftPanel);
                }
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
