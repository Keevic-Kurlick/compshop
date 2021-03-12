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
    public partial class MakerPr : Form
    {
        public MakerPr()
        {
            InitializeComponent();
        }

        private void MakerPr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st02DataSet.makerOfPrnt". При необходимости она может быть перемещена или удалена.
            this.makerOfPrntTableAdapter.Fill(this.st02DataSet.makerOfPrnt);

        }
    }
}
