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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.AliceBlue;
            MessageBox.Show("REGISTRATION SUCCESSFUL");
            string r = textBox1.Text;
            Form3 f3 = new Form3();
            f3.BackColor = Color.Pink;



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Form3BackColor = "Color.AliceBlue".;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5=new Form5();
            f5.Show();

        }
    }
}
