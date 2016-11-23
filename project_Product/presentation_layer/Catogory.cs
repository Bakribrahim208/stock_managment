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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
namespace project_Product.presentation_layer
{

    public partial class Catogory : Form
    {SqlConnection cn=new SqlConnection(@"Data Source=USERFILES\SQLEXPRESS;Initial Catalog=Product;Integrated Security=True");
        SqlDataAdapter da=new SqlDataAdapter();
        DataTable dt=new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        public Catogory()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select * from catagory", cn);
            da.Fill(dt);
            dataGridView1.DataSource=dt;
            id.DataBindings.Add("text", dt,"cat_id");
            desc.DataBindings.Add("text", dt, "Description");
            bmb = this.BindingContext[dt];
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            add.Enabled = true;
            new_cat.Enabled = false; 
            int ID = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]);
            id.Text = Convert.ToString(ID + 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);

            da.Update(dt);
            MessageBox.Show("catogory Added");
            add.Enabled = false;
            new_cat.Enabled = true;
        }

        private void Catogory_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        
        }

        private void lastcat_Click(object sender, EventArgs e)
        {
            bmb.Position = dt.Rows.Count - 1;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;

        }

        private void toword_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
        }

        private void frist_cat_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
        }

        private void delete_cat_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("catogory Deleted");
           
        }

        private void edite_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);

            da.Update(dt);
            MessageBox.Show("catogory updated");

        }

        private void print_all_Click(object sender, EventArgs e)
        {
            REPORT.Report frm = new REPORT.Report();
            REPORT.rpt_catogory rpt = new REPORT.rpt_catogory();
            rpt.Refresh();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
                 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            REPORT.Report frm = new REPORT.Report();
            REPORT.category_PROD rpt = new REPORT.category_PROD();
            rpt.SetParameterValue("@ID",Convert.ToInt32( id.Text));
            rpt.Refresh();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
                 
        }

        private void saveAs_pdf_Click(object sender, EventArgs e)
        {
          
            //ExportOptions export = new ExportOptions();
            //DiskFileDestinationOptions df=new DiskFileDestinationOptions();
            //PdfFormatOptions pdf=new PdfFormatOptions();
            //export.ExportFormatOptions=pdf;
            //df.DiskFileName="E:\\bakr.pdf";
            //export=report.ExportOptions;
            //export.ExportDestinationType=ExportDestinationType.DiskFile;
            //export.ExportFormatType = ExportFormatType.PortableDocFormat;
            //export.ExportFormatOptions = pdf;
            //export.ExportDestinationOptions = df;
            //MessageBox.Show("the file saved ");


            REPORT.rpt_catogory rpt = new REPORT.rpt_catogory();
            ExportOptions ex = new ExportOptions();
            DiskFileDestinationOptions ds = new DiskFileDestinationOptions();
            PdfFormatOptions file = new PdfFormatOptions();
            ds.DiskFileName = "E:\\category.pdf";
            ex = rpt.ExportOptions;
            ex.ExportDestinationType = ExportDestinationType.DiskFile;
            ex.ExportFormatType = ExportFormatType.PortableDocFormat;
            ex.ExportFormatOptions = file;
            ex.ExportDestinationOptions = ds;
            rpt.Export();
            MessageBox.Show("the file saved ");


        }

        private void save_cat_prod_Click(object sender, EventArgs e)
        {

            REPORT.category_PROD rpt = new REPORT.category_PROD();
            ExportOptions ex = new ExportOptions();
            DiskFileDestinationOptions ds = new DiskFileDestinationOptions();
            PdfFormatOptions file = new PdfFormatOptions();
            ds.DiskFileName = "E:\\product.pdf";
            ex = rpt.ExportOptions;
            ex.ExportDestinationType = ExportDestinationType.DiskFile;
            ex.ExportFormatType = ExportFormatType.PortableDocFormat;
            ex.ExportFormatOptions = file;
            ex.ExportDestinationOptions = ds;
            rpt.Export();
            MessageBox.Show("the file saved ");
        }
    }
}
