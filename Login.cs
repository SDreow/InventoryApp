using authentication;
using MainClass;
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
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mainClass.validate(leftPanel) > 0)
            {
                mainClass.ShowMSG("Field with RED are mandatory", "error");
            }
            else
            {
                if (Auth.getLoginDetails(userTxt.Text, passwordTxt.Text))
                {
                    HomeScreen hs = new HomeScreen();
                    mainClass.openWin(hs, MDI.ActiveForm, this);
                }
                else
                {
                   
                }
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
