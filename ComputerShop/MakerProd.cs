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
    public partial class MakerProd : Form
    {
        public MakerProd()
        {
            InitializeComponent();
        }

        private void MakerProd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st02DataSet.makerProd". При необходимости она может быть перемещена или удалена.
            this.makerProdTableAdapter.Fill(this.st02DataSet.makerProd);

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
