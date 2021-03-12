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
    public partial class frmDesktop : Form
    {
        public frmDesktop()
        {
            InitializeComponent();
        }

        private void pCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.St02DataSet);

        }

        private void frmDesktop_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st02DataSet.PC". При необходимости она может быть перемещена или удалена.
            this.pCTableAdapter.Fill(St02DataSet.PC);

        }

        private void modelLabel_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            pCBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.St02DataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pCBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pCBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pCBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pCBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pCBindingSource.AddNew();
        }
    }
}
