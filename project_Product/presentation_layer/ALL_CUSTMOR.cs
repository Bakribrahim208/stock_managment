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
    public partial class ALL_CUSTMOR : Form
    {
        businiss_layer.Custmor custmor = new businiss_layer.Custmor();
        public ALL_CUSTMOR()
        {
            InitializeComponent();
             dataGridView1.DataSource = custmor.All_Custmor();
             dataGridView1.Columns[0].Visible = false;

             dataGridView1.Columns[5].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

         
    }
}
