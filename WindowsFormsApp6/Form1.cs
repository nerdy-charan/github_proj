using System;
using System.Collections;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEGISTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
           f2.MdiParent = this;
            f2.Show();
            f2.BackColor = Color.BlanchedAlmond;
        }

        private void pRODUCTENTRYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.BackColor = Color.LightBlue;
            f3.MdiParent = this;
            f3.Show();
        }

        private void rEPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pRODUCTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.MdiParent = this;
            f4.BackColor = Color.Aquamarine;
            f4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void wINDOWSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void titleHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void totleVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        

        private void qUITToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }
    }
}
