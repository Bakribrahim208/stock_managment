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
    public partial class USERS : Form
    {
        businiss_layer.LOG_in user = new businiss_layer.LOG_in();
        public USERS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (username.Text == string.Empty || password.Text == string.Empty || confirmpass.Text == string.Empty || fullname.Text == string.Empty)
            {
                MessageBox.Show("اكمل الملعومات الناقصه ", "خطا ف المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password.Text != confirmpass.Text)
            {
                MessageBox.Show("كلمتي السر غير متطابقتين ", "خطأ ف كلمه السر ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (savebtn.Text == "حفظ المستخدم")
            { 
                user.ADD_USER(username.Text, password.Text, comboBox1.Text, fullname.Text);
                MessageBox.Show("تم اضافه المتسخدم", "اضافه مستخدم جديد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (savebtn.Text == "تعديل مستخدم")
            {
                user.Edit_USER(username.Text, password.Text, comboBox1.Text, fullname.Text);
                MessageBox.Show("تم تعديل المتسخدم", "تعديل مستخدم ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                password.Clear();
                fullname.Clear();
                confirmpass.Clear();
                username.Clear();
                savebtn.Text = "حفظ المستخدم";
        }

        private void confirmpass_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void confirmpass_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void confirmpass_Validated(object sender, EventArgs e)
        {
            if (password.Text != confirmpass.Text)
            {
                MessageBox.Show("كلمتي السر غير متطابقتين ", "خطأ ف كلمه السر ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void confirmpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
