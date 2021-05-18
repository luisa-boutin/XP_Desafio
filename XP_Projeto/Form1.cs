using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XP_Projeto
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

        private void cadastroButton_Click(object sender, EventArgs e)
        {
            label1.Text = nomeTextBox.Text;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Nome";
            dataGridView1.Columns[1].Name = "Telefone";
            dataGridView1.Columns[2].Name = "CPF";
            dataGridView1.Rows.Add(nomeTextBox.Text, "12345678", "789456123");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.RemoveAt(e.RowIndex);
        }
    }
}
