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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDesktop dr = new frmDesktop();
            this.Hide();
            dr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLaptop us = new frmLaptop();
            this.Hide();
            us.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Printers pr = new Printers();
            this.Hide();
            pr.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Makers ms = new Makers();
            this.Hide();
            ms.ShowDialog();
        }
    }
}
