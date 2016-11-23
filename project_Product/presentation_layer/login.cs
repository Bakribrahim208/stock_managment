using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_Product.presentation_layer
{
    public partial class login : Form
    {
        businiss_layer.LOG_in log = new businiss_layer.LOG_in();
        public login()
        {
            InitializeComponent();
            
        }

        private void closebut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void logbut_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = log.login(usernamrtxt.Text, passtxt.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Log in success ^_^ ", "Login ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //passtxt.Clear();
                //usernamrtxt.Clear();
                Main_menu.getmaianmenu.flemenu.Enabled = true;
                Main_menu.getmaianmenu.productmenu.Enabled = true;
                Main_menu.getmaianmenu.custmormenu.Enabled = true;
                Main_menu.getmaianmenu.usermenu.Enabled = true;
                this.Close();

            }
            else
                MessageBox.Show("Log in failed ", "failed ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
