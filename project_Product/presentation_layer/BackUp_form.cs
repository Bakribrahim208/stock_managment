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
   
    public partial class BackUp_form : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=USERFILES\SQLEXPRESS;Initial Catalog=Product;Integrated Security=True");
        SqlCommand cmd;
            public BackUp_form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                showtxt.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string filename = showtxt.Text + "\\product" + DateTime.Now.ToShortDateString().Replace('/', '-')
                                         + "-" + DateTime.Now.ToLongTimeString().Replace(':', '-');
            string quary="Backup Database Product To Disk='"+filename+".bak'";
            cmd = new SqlCommand(quary,cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("تم حفظ قاعده البيانات بنجاح", "حفظ نسخه احتياطيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        
        }

        private void BackUp_form_Load(object sender, EventArgs e)
        {

        }
    }
}
