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
    public partial class Orderes_List : Form
    {
        businiss_layer.Orderes order_list = new businiss_layer.Orderes();
        public Orderes_List()
        {
            InitializeComponent();
            dataGridView2.DataSource = order_list.search_Order("");
        }

        private void Orderes_List_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            { 
                dataGridView2.DataSource = order_list.search_Order(textBox1.Text);
            }
            catch
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            REPORT.orderes_rpt rpt = new REPORT.orderes_rpt();
            rpt.SetParameterValue("@id_order", Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
            REPORT.Report_FORM rpt_form = new REPORT.Report_FORM();
            rpt_form.crystalReportViewer1.ReportSource = rpt;
            rpt_form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
