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
 
namespace project_Product.presentation_layer
{
    public partial class Restore_DB : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=USERFILES\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd;
        public Restore_DB()
        {
            InitializeComponent();
        }

        private void browsbtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                showtxt.Text = openFileDialog1.FileName;
            }
        }

        private void restore_Click(object sender, EventArgs e)
        {
            string quary = "Alter Database   Product set offline with Rollback  immediate ; Restore Database Product from Disk='" + showtxt.Text + "'";
            cmd = new SqlCommand(quary, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("تم استعاده قاعده البيانات بنجاح", "استعاده نسخه احتياطيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
