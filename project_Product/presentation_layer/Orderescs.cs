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
    public partial class Orderescs : Form
    {
        businiss_layer.Orderes order = new businiss_layer.Orderes();
        DataTable dt = new DataTable();
        public Orderescs()
        {
            InitializeComponent();
            save_order.Enabled = false;
            print_order.Enabled = false;
            create_product_table();
            sales_person.Text = Program.fullname;
            //resize_datagridview();
        }
        void CLEAR_TEXTBOXES()
        {
            product_id.Clear();
            product_name.Clear();
            product_price.Clear();
            product_que.Clear();
            price.Clear();
            total_price.Clear();
            discount.Clear();

        }
        void clear_all_form()
        {
            order_id.Clear();
            order_desc.Clear();
            dateTimePicker1.ResetText();
            custmor_id.Clear();
            Firstname.Clear();
            Lastname.Clear();
            EMail.Clear();
            phone.Clear();
            pictureBox1.Image = null;
            totalprice.Clear();
            CLEAR_TEXTBOXES();
            dt.Reset();
            dataGridView1.DataSource = null; 
            new_order.Enabled = true;
            save_order.Enabled = false;
        }

        void calculatePrice()
        {
            double Price = Convert.ToDouble(product_price.Text) * (Convert.ToDouble(product_que.Text));
            if(product_price.Text!=string.Empty && product_que.Text!=string .Empty)
            price.Text = Convert.ToString(Price);
        }
        void calculateTOTAL()
        {
            if (discount.Text != string.Empty && product_que.Text != string.Empty) 
            {
            double Total=Convert.ToDouble(price.Text);
            double Discont=Convert.ToDouble(discount.Text);
            double total = Total - (Total * (Discont / 100));
            total_price.Text = total.ToString();
            }
        }
        void create_product_table()            
        {
            dt.Columns.Add("معرف المنتج");
            dt.Columns.Add("اسم المنتج");
            dt.Columns.Add("الثمن");
            dt.Columns.Add("الكميه");
            dt.Columns.Add("المبلغ");
            dt.Columns.Add("الخصم%");
            dt.Columns.Add(" الملغ الاجمالي");
            dataGridView1.DataSource = dt;
          

        }
        void resize_datagridview()
        {
            dataGridView1.RowHeadersVisible = false;
       this.dataGridView1.Columns[0].Width= 111 ;
        this.dataGridView1.Columns[1].Width = 150;
        this.dataGridView1.Columns[2].Width = 102;
        this.dataGridView1.Columns[3].Width = 95;
        this.dataGridView1.Columns[4].Width = 130;
             this.dataGridView1.Columns[5].Width = 130;
             this.dataGridView1.Columns[6].Width = 128;

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Orderescs_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            order_id.Text = Convert.ToString(order.GET_LAST_ORDER().Rows[0][0].ToString());
            save_order.Enabled = true;
            
        }

        private void print_order_Click(object sender, EventArgs e)
        {
            try {
                int lastorder=Convert.ToInt32(   order.GET_LAST_ORDER_for_Print().Rows[0][0]);
                REPORT.orderes_rpt rpt = new REPORT.orderes_rpt();
                REPORT.Report_FORM frmrpt = new REPORT.Report_FORM();
                rpt.SetParameterValue("@id_order", lastorder);
                frmrpt.crystalReportViewer1.ReportSource = rpt;
                frmrpt.ShowDialog();

                
            }
            catch  
            {
                MessageBox.Show( "error:");
            }
        }

        private void save_order_Click(object sender, EventArgs e)
        {
            print_order.Enabled = true;
            if (custmor_id.Text == string.Empty || order_id.Text == string.Empty || dataGridView1.Rows.Count < 1 || order_desc.Text == string.Empty)
            {
                MessageBox.Show("يجب تسيجل معلموات الفاتوره", "معلومات الفاتوره", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            order.Add_Order(Convert.ToInt32(order_id.Text), dateTimePicker1.Value, Convert.ToInt32(custmor_id.Text), order_desc.Text, sales_person.Text);
            for (int i = 0; i <dataGridView1.Rows.Count; i++)
            {
                order.ADD_ORDER_DETAILS(

                    dataGridView1.Rows[i].Cells[0].Value.ToString()
                    , Convert.ToInt32(order_id.Text)
                    , Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString())
                    , dataGridView1.Rows[i].Cells[2].Value.ToString()
                    , Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value)
                    , dataGridView1.Rows[i].Cells[4].Value.ToString()
                    , dataGridView1.Rows[i].Cells[6].Value.ToString()
                    );
                
            }
            MessageBox.Show("تم حفظ الفاتوره", "حفظ فاتوره", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear_all_form();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ALL_CUSTMOR custmor = new ALL_CUSTMOR();
            custmor.ShowDialog();
            custmor_id.Text = custmor.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Firstname.Text = custmor.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Lastname.Text = custmor.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            phone.Text = custmor.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            EMail.Text = custmor.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            byte[] IAmage = (byte[])custmor.dataGridView1.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(IAmage);
            pictureBox1.Image = Image.FromStream(ms);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void order_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CLEAR_TEXTBOXES();

            PRODUCT_USED_IN_ORDERES_FORM products = new PRODUCT_USED_IN_ORDERES_FORM();
            products.ShowDialog();
            product_id.Text = products.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            product_name.Text =products. dataGridView1.CurrentRow.Cells[1].Value.ToString();
            product_price.Text = products. dataGridView1.CurrentRow.Cells[3].Value.ToString();
         
        }

        private void product_que_KeyDown(object sender, KeyEventArgs e)
        {
            if (product_que.Text != string.Empty && e.KeyCode == Keys.Enter)
            {
                price.Focus();
            }
        }

        private void product_que_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void product_price_DoubleClick(object sender, EventArgs e)
        {

        }

        private void product_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char seperator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8  && e.KeyChar!=seperator)
            {
                e.Handled = true;
            }
        }

        private void product_price_KeyUp(object sender, KeyEventArgs e)
        {
            calculatePrice();
            calculateTOTAL();
        }

        private void product_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (product_que.Text != string.Empty && e.KeyCode == Keys.Enter)
            {
                price.Focus();
            }
        }

        private void price_KeyDown(object sender, KeyEventArgs e)
        {

            if (price.Text != string.Empty && e.KeyCode == Keys.Enter)
            {
                discount.Focus();
            }
        }

        private void product_que_KeyUp(object sender, KeyEventArgs e)
        {
            calculatePrice();
            calculateTOTAL();

        }

        private void discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void discount_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTOTAL();
        }

        private void discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (order.vertify_product(product_id.Text, Convert.ToInt32(product_que.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("هذا المنتج غير متاح ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                for (int i = 0; i <dt.Rows.Count; i++)
                {
                  if(dt.Rows[i][0].ToString()==product_id.Text)
                  {
                      MessageBox.Show("هذا المنتج موجود مسبقا ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                      return;
                         
                  }
                }
                DataRow row = dt.NewRow();
                row[0] = product_id.Text;
                row[1] =product_name .Text;
                row[2] = product_price.Text;
                row[3] = product_que.Text;
                row[4] = price.Text;
                row[5] = discount.Text;
                row[6] = total_price.Text;
                dt.Rows.Add(row);

                CLEAR_TEXTBOXES();
                totalprice.Text =
               (from DataGridViewRow rr in dataGridView1.Rows
                where rr.Cells[6].FormattedValue.ToString() != string.Empty
                select Convert.ToDouble(rr.Cells[6].FormattedValue)).Sum().ToString();

            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                product_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                product_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                product_price.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                product_que.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                price.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                discount.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                total_price.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);


            }
            catch
            {
                return;
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            totalprice.Text =
               (from DataGridViewRow rr in dataGridView1.Rows
                where rr.Cells[6].FormattedValue.ToString() != string.Empty
                select Convert.ToDouble(rr.Cells[6].FormattedValue)).Sum().ToString();
        }

        private void تعديلالمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1_DoubleClick(sender,e);
        }

        private void الحذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
           dataGridView1.Rows.RemoveAt (dataGridView1.CurrentRow.Index);
        }

        private void حذفكلالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dt.Clear();
            dataGridView1.Refresh();
            
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    dataGridView1.Rows.RemoveAt (dataGridView1.Rows[i].Index);

            //}
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
