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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static string prod_id="";
        public static string prod_name = "";
        public static string prod_delivery = "";
        public static string prod_check = "";

        DataTable dt = new DataTable();
        public TextBox TextBox1
        {
            get
            {
                return textBox1;
            }
        }
        public TextBox TextBox2
        {
            get
            {
                return textBox2;
            }
        }
        public ComboBox ComboBox1
        {
            get
            {
                return comboBox1;
            }
        }
        public CheckBox CheckBox1
        {
            get
            {
                return checkBox1;
            }
        }
        public void disptextbox1fromform2()
        {

        }
        public void dispgrid()
        {
            Form4 f4 = new Form4();
            dt.Columns.Add("Product-id");
            dt.Columns.Add("Product-name");
            dt.Columns.Add("Delivery Location");
            f4.DataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string r = textBox1.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.AliceBlue;
            prod_id = textBox1.Text;
            prod_name=textBox2.Text;
            prod_delivery = comboBox1.Text;
            MessageBox.Show ("YOUR DETAILS ARE SAVED");
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
