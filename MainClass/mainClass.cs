using Settings;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainClass
{
    public class mainClass
    {

        public static SqlConnection con = new SqlConnection(File.ReadAllText(settings.path));
        public static void ResetAll(Panel p) //reset
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                }
                else if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.SelectedIndex = -1;
                }
                else if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = false;
                }
                else if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                }
                else if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Value = DateTime.Today;
                }
            }
        }
        public static void enable(Panel p) //enable
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = true;
                }
                else if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                }
                else if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                }
                else if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                }
                else if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Enabled = true;
                }
            }
        }
        public static void reset_enable(Panel p) //reset enable
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                    tb.Enabled = true;
                    tb.BackColor = Color.White;
                }
                else if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.SelectedIndex = -1;
                    cb.Enabled = true;
                    cb.BackColor = Color.White;
                }
                else if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = false;
                    rb.Enabled = true;
                }
                else if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                    cb.Enabled = true;
                }
                else if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Value = DateTime.Today;
                    dt.Enabled = true;
                }
            }
        }
        public static void reset_disable(Panel p) //reset disable
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                    tb.Enabled = false;
                    tb.BackColor = Color.White;
                }
                else if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.SelectedIndex = -1;
                    cb.Enabled = false;
                    cb.BackColor = Color.White;
                }
                else if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = false;
                    rb.Enabled = false;
                }
                else if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                    cb.Enabled = false;
                }
                else if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Value = DateTime.Today;
                    dt.Enabled = false;
                }
            }
        }
        public static void disable(Panel p) //disable
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = false;
                }
                else if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                }
                else if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                }
                else if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                }
                else if (c is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)c;
                    dt.Enabled = false;
                }
            }
        }
        public static void ShowMSG(string msg, string type) //Message
        {
            if (type == "success")
            {
                MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (type == "error")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public static void openWin(Form openWin,Form MDI,Form closeWin)//window
        {
            closeWin.Close();
            openWin.MdiParent = MDI;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
        public static int validate(Panel p) // validate desing
        {
            int count = 0;
            foreach (Control c in p.Controls)
            {                
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if (tb.Text == "")
                    {
                        count++;
                        tb.BackColor = Color.Firebrick;
                    }
                    else
                    {
                        tb.BackColor = Color.White;
                    }
                }
                if (c is CheckBox)
                {
                    CheckBox tb = (CheckBox)c;
                    if (!tb.Checked && tb.AllowDrop == false)
                    {
                        count++;
                        tb.BackColor = Color.Firebrick;
                    }
                    
                }
                if (c is RadioButton)
                {
                    RadioButton tb = (RadioButton)c;
                    if (!tb.Checked)
                    {
                        count++;
                        tb.BackColor = Color.Firebrick;
                    }
                    else
                    {
                        tb.BackColor = Color.White;
                    }
                }
                if (c is ComboBox)
                {
                    ComboBox tb = (ComboBox)c;
                    if (tb.SelectedIndex == -1)
                    {
                        count++;
                        tb.BackColor = Color.Firebrick;
                    }
                    else
                    {
                        tb.BackColor = Color.White;
                    }
                }
            }
            return count;
        }
        public static void openWin(Form openWin, Form MDI)//window
        {
            openWin.MdiParent = MDI;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
    }
}
