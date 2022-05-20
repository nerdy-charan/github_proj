using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form4 : Form
    {
        DataTable dt = new DataTable();
        public DataGridView DataGridView1
        {
            get
            {
                return dataGridView1;
            }
        }
        private Form3 otherForm;
        public void GetOtherFormTextBox()
        {
            string prod_id = otherForm.TextBox1.Text;
            string prod_name = otherForm.TextBox2.Text;
            string prod_delivery = otherForm.ComboBox1.Text;

        }
        public void dispgrid()
        {
            dt.Columns.Add("Product-id");
            dt.Columns.Add("Product-name");
            dt.Columns.Add("Delivery Location");

            dataGridView1.DataSource = dt;
        }
        public void disprow()
        {
            dt.Rows.Add(Form3.prod_id, Form3.prod_name, Form3.prod_delivery);
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dispgrid();
            disprow();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dt.Columns.Add("Product-id");
            dt.Columns.Add("Product-name");
            dt.Columns.Add("Delivery Location");
            dt.Rows.Add(Form3.prod_id, Form3.prod_name, Form3.prod_delivery);
        }
    }
}
