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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st02DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st02DataSet.makerProd". При необходимости она может быть перемещена или удалена.
            this.makerProdTableAdapter.Fill(this.st02DataSet.makerProd);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st02DataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.st02DataSet.Product);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private System.Windows.Forms.DataGridViewColumn COL;


        private void button1_Click(object sender, EventArgs e)
        {
            //создает переменную COL для хранения имени выбранного столбца таблицы
            COL = new System.Windows.Forms.DataGridViewColumn();

              switch (Сортировка.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn2;

                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn4;

                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn6;

                    break;

            }
           
            if (radioButton1.Checked)
                makerProdDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Ascending);
            else
                makerProdDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            makerProdBindingSource.Filter = "NAME='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            makerProdBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < makerProdDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < makerProdDataGridView.RowCount - 1; j++)
                {
                    makerProdDataGridView[i, j].Style.BackColor = Color.White;
                    makerProdDataGridView[i, j].Style.ForeColor = Color.Black;

                }
            }
          
            for (int i = 0; i < makerProdDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < makerProdDataGridView.RowCount - 1; j++)
                {
                    if (makerProdDataGridView[i,
                    j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        makerProdDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        makerProdDataGridView[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

