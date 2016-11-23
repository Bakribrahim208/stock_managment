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
    public partial class Mange_Useres : Form
    {
        businiss_layer.LOG_in useres = new businiss_layer.LOG_in();
        public Mange_Useres()
        {
            InitializeComponent();
            dataGridView2.DataSource = useres.search_useres("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            USERS user = new USERS();
            user.Text = "حفظ المستخدم";
            user.ShowDialog();
            dataGridView2.DataSource = useres.search_useres("");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = useres.search_useres(search_text.Text);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            USERS user = new USERS();
            user.Text = "تعديل المستخدم ";
            user.savebtn.Text = "تعديل مستخدم";
            user.fullname.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            user.password.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            user.confirmpass.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            user.username.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            user.comboBox1.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
           
            user.ShowDialog();
            dataGridView2.DataSource = useres.search_useres("");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المستخد المحدد ", "حذف مستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                useres.Delete_user(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تم مسح المستخدم ", "حذف مستخدم");
                dataGridView2.DataSource = useres.search_useres("");

            }
        }
    }
}
