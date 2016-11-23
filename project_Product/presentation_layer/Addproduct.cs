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
namespace project_Product.presentation_layer
{
    public partial class Addproduct : Form
    {
        public string state = "add"; 
        businiss_layer.product_class prod =new businiss_layer.product_class();
 
        public Addproduct()
        {
            InitializeComponent();
            catagory.DataSource = prod.Get_all_catagory();
            catagory.DisplayMember = "Description";
            catagory.ValueMember = "cat_id";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "picture|*.jpg;*.png;*.JPG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(of.FileName);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Addproduct_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (state == "add") 
            { 
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] byteimage = ms.ToArray();

            prod.ADD_PRoduct((Convert.ToInt32(catagory.SelectedValue)), id_prod.Text, desc_prod.Text,(Convert.ToInt32(qte.Text)),price.Text,byteimage);
            MessageBox.Show("تم ضافه المنتج بنجاح ", "اضافه منتج ");
            id_prod.Clear();
            desc_prod.Clear();
            qte.Clear();
            price.Clear();}
            else
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] byteimage = ms.ToArray();

                prod.Update_proudect(Convert.ToInt32(catagory.SelectedValue), id_prod.Text, desc_prod.Text, (Convert.ToInt32(qte.Text)), price.Text, byteimage);
                MessageBox.Show("تم تعديل المنتج بنجاح ", "تعديل  منتج ");   
            }
            magange_product.getmaianmenu.dataGridView1.DataSource = prod.Get_all_Product();
        }

        private void id_prod_Validated(object sender, EventArgs e)
        {
            if (state == "add") {
            DataTable dt = new DataTable();
            dt = prod.vertify_productID(id_prod.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("idالمنتج موجود مسبقا ", " ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                id_prod.Focus();
                id_prod.SelectionStart = 0;
                id_prod.SelectionLength = id_prod.TextLength;
            }
        } }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
