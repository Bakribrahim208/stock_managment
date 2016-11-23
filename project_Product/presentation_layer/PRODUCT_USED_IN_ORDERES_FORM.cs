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
    public partial class PRODUCT_USED_IN_ORDERES_FORM : Form
    {
        businiss_layer.Orderes order = new businiss_layer.Orderes();
        public PRODUCT_USED_IN_ORDERES_FORM()
        {
            InitializeComponent();
            dataGridView1.DataSource = order.Get_all_Product();

        }

        private void PRODUCT_USED_IN_ORDERES_FORM_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
