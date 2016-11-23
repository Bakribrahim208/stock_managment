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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports;
namespace project_Product.presentation_layer
{
    public partial class magange_product : Form
    {
        businiss_layer.product_class managePRoduct = new businiss_layer.product_class();
        private static magange_product frm;
        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static magange_product getmaianmenu
        {
            get
            {
                if (frm == null)
                {
                    frm = new magange_product();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }
        }
        public magange_product()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = managePRoduct.Get_all_Product();
            if (frm == null)
                frm = this;
        }

        

        private void magange_product_Load(object sender, EventArgs e)
        {

        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = managePRoduct.Search_Product(searchtxt.Text);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addproduct Add_frm = new Addproduct();
            Add_frm.ShowDialog();
            dataGridView1.DataSource = managePRoduct.Get_all_Product();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل تريد حف المنتج المحدد ","حذف منتج ",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation)==DialogResult.OK)
            {
                
                managePRoduct.Delete_product(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تم مسح المنتج المحدد ", "مسح منتج ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridView1.DataSource = managePRoduct.Get_all_Product();
            }
            else
            {
                MessageBox.Show("تم الغاء مسح المنتج", "مسح منتج ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Addproduct frmupdate = new Addproduct();
            frmupdate.id_prod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmupdate.qte.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmupdate.desc_prod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmupdate.price.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
            frmupdate.catagory.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmupdate.Text = "تحديث المنتج ";
            frmupdate.button3.Text = "update";
            frmupdate.id_prod.ReadOnly = true;
            frmupdate.state = "update";
            byte[] image = (byte[])managePRoduct.Get_pic(dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream readimage = new MemoryStream(image);
            frmupdate.pictureBox1.Image = Image.FromStream(readimage);

            frmupdate.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            playPicture pic = new playPicture(); 
            byte[] image = (byte[])managePRoduct.Get_pic(dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream readimage = new MemoryStream(image);
            pic.pictureBox1.Image = Image.FromStream(readimage);
            pic.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            REPORT.Product_Report rpt = new REPORT.Product_Report();
            rpt.SetParameterValue("@ID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            REPORT.Report rpt_form = new REPORT.Report();
            rpt_form.crystalReportViewer1.ReportSource = rpt;
            rpt_form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            REPORT.RPT_ALL_PRODUCT rpt = new REPORT.RPT_ALL_PRODUCT();
            REPORT.Report rpt_form = new REPORT.Report();
            rpt_form.crystalReportViewer1.ReportSource = rpt;
            rpt_form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

           

            REPORT.RPT_ALL_PRODUCT rpt = new REPORT.RPT_ALL_PRODUCT();
            ExportOptions ex = new ExportOptions();
            DiskFileDestinationOptions ds = new DiskFileDestinationOptions();
            ExcelFormatOptions file = new ExcelFormatOptions();
            ds.DiskFileName = "E:\\product.xls";
            ex = rpt.ExportOptions;
            ex.ExportDestinationType = ExportDestinationType.DiskFile;
            ex.ExportFormatType = ExportFormatType.Excel;
            ex.ExportFormatOptions = file;
            ex.ExportDestinationOptions = ds;
            rpt.Export();
            MessageBox.Show("add ");
        }
    }
}
