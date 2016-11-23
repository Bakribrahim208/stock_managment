using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace project_Product.presentation_layer
{
    public partial class CUSTOMER : Form
    {
        businiss_layer.Custmor custmor = new businiss_layer.Custmor();
        DataTable dt = new DataTable();
        int ID; 
        public CUSTOMER()
        {
            InitializeComponent();
            dt = custmor.All_Custmor();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            
          
            try { 
            byte[] IAmage ;
            MemoryStream ms=new MemoryStream();
            pictureBox1.Image.Save(ms,pictureBox1.Image.RawFormat);
            IAmage=ms.ToArray();
          custmor.ADD_PRoduct(Firstname.Text,Lastname.Text,phone.Text,EMail.Text,IAmage);
          MessageBox.Show("the User is added", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);}
            catch
            {
                MessageBox.Show("their Exict Error accoured","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                new_custmor.Enabled = true;
                add.Enabled = false;
                dataGridView1.DataSource = dt;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op =new OpenFileDialog();
            op.Filter = "picture|*.jpg;*.png;*.JPG;*.PNG";
            if(op.ShowDialog()==DialogResult.OK)
            {

                pictureBox1.Image=Image.FromFile(op.FileName);
            }
        }

        private void new_cat_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Firstname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Lastname.Focus();
            }
        }

        private void Lastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                phone.Focus();
            }
        }

        private void phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EMail.Focus();
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void new_custmor_Click(object sender, EventArgs e)
        {
            Firstname.Clear();
            Lastname.Clear();
            phone.Clear();
            EMail.Clear();
            Firstname.Focus();
            add.Enabled = true;
            new_custmor.Enabled = false;
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            try
            {
                byte[] IAmage;
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                IAmage = ms.ToArray();
                custmor.ADD_PRoduct(Firstname.Text, Lastname.Text, phone.Text, EMail.Text, IAmage);
                MessageBox.Show("the User is added", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("their Exict Error accoured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                new_custmor.Enabled = true;
                add.Enabled = false;
                dt = custmor.All_Custmor();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[5].Visible = false;


            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try { 
            Firstname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Lastname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
             phone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
             EMail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
             byte[] IAmag = (byte[])dataGridView1.CurrentRow.Cells[5].Value ;
             MemoryStream ms = new MemoryStream(IAmag);
             pictureBox1.Image = Image.FromStream(ms);}
            catch
            {
                return;
            }

           

        }

        private void edite_Click(object sender, EventArgs e)
        { 
            
            try
            {
                ID= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                byte[] IAmage;
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                IAmage = ms.ToArray();
                custmor.EDITE_CUSTOMER(ID,Firstname.Text, Lastname.Text, phone.Text, EMail.Text, IAmage);
                MessageBox.Show("the User is EDITED", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("their Exict Error accoured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                new_custmor.Enabled = true;
                add.Enabled = false;
                dt = custmor.All_Custmor();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[5].Visible = false;


            }

        }

        private void delete_cat_Click(object sender, EventArgs e)
        {
         ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
         if (MessageBox.Show("هل تريد حذف هذا العميل ؟", "حذف ", MessageBoxButtons.YesNo) == DialogResult.Yes) { 
            custmor.Delete_User(ID);
            MessageBox.Show("User Deleted");
            dt = custmor.All_Custmor();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
         }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
