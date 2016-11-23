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
    public partial class Main_menu : Form
    {
        private static Main_menu frm;
        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Main_menu getmaianmenu
        {
            get
            {
                if(frm==null)
                {
                    frm = new Main_menu();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }
        }
        public Main_menu()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            custmormenu.Enabled = false;
            usermenu.Enabled = false;
            productmenu.Enabled = false;
            flemenu.Enabled = true;
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {

        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.ShowDialog();
        }

        private void backup_Click(object sender, EventArgs e)
        {

        }

        private void اضافهمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addproduct frm = new Addproduct();
            frm.ShowDialog();
        }

        private void ادارهمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            magange_product magprduct = new magange_product();
            magprduct.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ادارهصنفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catogory catogory = new Catogory();
            catogory.ShowDialog ();
        }

        private void اضافهعميلجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ادارهالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
