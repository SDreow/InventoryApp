using MainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryAPP
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MDI_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ "\\inventory_connect";
            if (File.Exists(path))
            {
                Login lo = new Login();
                mainClass.openWin(lo, MDI.ActiveForm);
            }
            else
            {
                Settings se = new Settings();
                mainClass.openWin(se,MDI.ActiveForm);
            }
        }
    }
}
