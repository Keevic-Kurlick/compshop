using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class Makers : Form
    {
        public Makers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakerPr pr = new MakerPr();
            this.Hide();
            pr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MakerPC pc = new MakerPC();
            this.Hide();
            pc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MakerLP lp = new MakerLP();
            this.Hide();
            lp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Form2 prod = new Form2();
            this.Hide();
            prod.ShowDialog();
        }

        private void Makers_Load(object sender, EventArgs e)
        {

        }
    }
}
