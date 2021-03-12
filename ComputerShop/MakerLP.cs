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
    public partial class MakerLP : Form
    {
        public MakerLP()
        {
            InitializeComponent();
        }

        private void MakerLP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st02DataSet.makerOfLaptop". При необходимости она может быть перемещена или удалена.
            this.makerOfLaptopTableAdapter.Fill(this.st02DataSet.makerOfLaptop);

        }
    }
}
