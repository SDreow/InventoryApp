using MainClass;
using Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryAPP
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                userTxt.Enabled = false;
                passwordTxt.Enabled = false;
            }
            else
            {
                userTxt.Enabled = true;
                passwordTxt.Enabled = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (mainClass.validate(leftPanel) > 0)
            {
                mainClass.ShowMSG("Fields with RED are mandatory", "error");
            }
            else
            {
                Login lo = new Login();
                if (isCB.Checked)
                {
                    settings.saveFile(serverTxt.Text, databaseTxt.Text);
                    mainClass.ShowMSG("Settings saved successfully", "success");
                    mainClass.openWin(lo, this, MDI.ActiveForm);

                }
                else
                {
                    settings.saveFile(serverTxt.Text, databaseTxt.Text, userTxt.Text, passwordTxt.Text);
                    mainClass.ShowMSG("Settings saved successfully", "success");
                    mainClass.openWin(lo, this, MDI.ActiveForm);
                }


            }
        }

        private void serverTxt_TextChanged(object sender, EventArgs e)
        {
            if (serverTxt.Text == "") 
            {
                serverTxt.BackColor = Color.Firebrick;
            }

            else
            {
                serverTxt.BackColor = Color.White;
            }
        }

        private void databaseTxt_TextChanged(object sender, EventArgs e)
        {
            if (databaseTxt.Text == "")
            {
                databaseTxt.BackColor = Color.Firebrick;
            }

            else
            {
                databaseTxt.BackColor = Color.White;
            }
        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {
            if (userTxt.Text == "")
            {
                userTxt.BackColor = Color.Firebrick;
            }

            else
            {
                userTxt.BackColor = Color.White;
            }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "")
            {
                passwordTxt.BackColor = Color.Firebrick;
            }

            else
            {
                passwordTxt.BackColor = Color.White;
            }
        }
    }
}
