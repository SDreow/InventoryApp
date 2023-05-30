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
    public partial class SuppliersWindow : Sample2
    {
        public SuppliersWindow()
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
        private void showData()
        {
            try
            {
                Hashtable ht = new Hashtable();
                ListBox lb = new ListBox();
                lb.Items.Add(supplierIDGV);
                lb.Items.Add(nameGV);
                lb.Items.Add(phoneGV);
                lb.Items.Add(adressGV);
                lb.Items.Add(emailGV);
                lb.Items.Add(statusGV);
                crud.loadData("st_getSuppliers",ht,lb,supplierGV);
            }
            catch (Exception ex)
            {
                mainClass.ShowMSG(ex.Message, "error");
            }
        }
        private void showData(string data) // SEARCH
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("@data", data);
                ListBox lb = new ListBox();
                lb.Items.Add(supplierIDGV);
                lb.Items.Add(nameGV);
                lb.Items.Add(phoneGV);
                lb.Items.Add(adressGV);
                lb.Items.Add(emailGV);
                lb.Items.Add(statusGV);
                crud.loadData("st_searchSupplier", ht, lb, supplierGV);
            }
            catch (Exception ex)
            {
                mainClass.ShowMSG(ex.Message, "error");
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
        private void adressTxt_TextChanged(object sender, EventArgs e)
        {
            if (adressTxt.Text == "")
            {
                adressTxt.BackColor = Color.Red;
            }
            else
            {
                adressTxt.BackColor = Color.White;
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
        int supplierID = 0;
        public override void saveBtb_Click(object sender, EventArgs e)
        {
            if (mainClass.validate(leftPanel) > 0)
            {
                mainClass.ShowMSG("Fields with RED are mandatory", "error");
            }
            else
            {
                try
                {

                    if (edit == 0) //SAVE
                    {
                        Hashtable ht = new Hashtable();
                        ht.Add("@name", nameTxt.Text);
                        ht.Add("@phone", phoneTxt.Text);
                        ht.Add("@adress", adressTxt.Text);
                        ht.Add("@email", emailTxt.Text);
                        if (statusDD.SelectedItem.ToString() == "Active")
                        {
                            ht.Add("@status", 1);
                        }
                        else if (statusDD.SelectedItem.ToString() == "Inactive")
                        {
                            ht.Add("@status", 0);
                        }
                        int x = crud.insert_update_delete("st_insertSuppliers", ht);
                        if (x > 0)
                        {
                            mainClass.ShowMSG(nameTxt.Text + " added sucessfully into the system.","success");
                        }
                        else
                        {
                            mainClass.ShowMSG(nameTxt.Text + "Unable to add "+ nameTxt.Text,"error");
                        }
                        showData();
                        mainClass.reset_disable(leftPanel);
                    }
                    else if (edit == 1) //UPDATE
                    {
                        Hashtable ht = new Hashtable();
                        ht.Add("@name", nameTxt.Text);
                        ht.Add("@phone", phoneTxt.Text);
                        ht.Add("@adress", adressTxt.Text);
                        ht.Add("@email", emailTxt.Text);
                        if (statusDD.SelectedItem.ToString() == "Active")
                        {
                            ht.Add("@status", 1);
                        }
                        else if (statusDD.SelectedItem.ToString() == "Inactive")
                        {
                            ht.Add("@status", 0);
                        }
                        ht.Add("@id",supplierID);
                        int x = crud.insert_update_delete("st_updateSuppliers", ht);
                        if (x > 0)
                        {
                            mainClass.ShowMSG(nameTxt.Text + "Updated sucessfully into the system.", "success");
                        }
                        else
                        {
                            mainClass.ShowMSG(nameTxt.Text + "Unable to update " + nameTxt.Text, "error");
                        }
                        showData();
                        mainClass.reset_disable(leftPanel);
                    }
                }
                catch (Exception ex)
                {
                    mainClass.ShowMSG(ex.Message, "error");
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1) //DELETE
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete " + nameTxt.Text+"?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("@id", supplierID);
                    int x = crud.insert_update_delete("st_deleteSuppliers",ht);
                    if (x > 0)
                    {
                        mainClass.ShowMSG(nameTxt.Text + "Deleted sucessfully into the system.", "success");
                    }
                    else
                    {
                        mainClass.ShowMSG(nameTxt.Text + "Unable to delete " + nameTxt.Text, "error");
                    }
                    showData();
                    mainClass.reset_disable(leftPanel);
                }
            }
            else
            {
                mainClass.ShowMSG("Please select any record from the list in orde to delete.", "error");
                showData();
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text == "")
            {
                showData();
            }
            else
            {
                showData(searchTxt.Text);
            }
        }

        private void supplierGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = supplierGV.Rows[e.RowIndex];
                supplierID = Convert.ToInt32(row.Cells["supplierIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["nameGV"].Value.ToString();
                phoneTxt.Text = row.Cells["phoneGV"].Value.ToString();
                emailTxt.Text = row.Cells["emailGV"].Value.ToString();
                adressTxt.Text = row.Cells["adressGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
                mainClass.disable(leftPanel);
            }
        }

        private void SuppliersWindow_Load(object sender, EventArgs e)
        {
            showData();
        }
    }
}
