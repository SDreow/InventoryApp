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

namespace InventoryAPP
{
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void rolesBtn_Click(object sender, EventArgs e)
        {
            RolesWindow rw = new RolesWindow();
            mainClass.openWin(rw, MDI.ActiveForm, this);
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            UsersWindow rw = new UsersWindow();
            mainClass.openWin(rw, MDI.ActiveForm, this);
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            SuppliersWindow rw = new SuppliersWindow();
            mainClass.openWin(rw, MDI.ActiveForm, this);
        }
    }
}
