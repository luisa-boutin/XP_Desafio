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
            ordensAbertasDataGridView.ColumnCount = 7;
            ordensAbertasDataGridView.Columns[0].Name = "Nome"; // Nome do cliente
            ordensAbertasDataGridView.Columns[1].Name = "Telefone"; // Telefone do cliente
            ordensAbertasDataGridView.Columns[2].Name = "CPF"; // CPF do cliente
            ordensAbertasDataGridView.Columns[3].Name = "Código"; // Código do cliente
            ordensAbertasDataGridView.Columns[4].Name = "Operação"; // Tipo da operação efetuada (Compra/Venda)
            ordensAbertasDataGridView.Columns[5].Name = "Identificador"; // Identificador da transação 
            ordensAbertasDataGridView.Columns[6].Name = "Objeto"; // Objeto da movimentação financeira
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Selecionar";
            checkBoxColumn.Width = 50;
            checkBoxColumn.Name = "checkBoxColumn";
            ordensAbertasDataGridView.Columns.Insert(7, checkBoxColumn);

            ordensFechadasDataGridView.ColumnCount = 7;
            ordensFechadasDataGridView.Columns[0].Name = "Nome"; // Nome do cliente
            ordensFechadasDataGridView.Columns[1].Name = "Telefone"; // Telefone do cliente
            ordensFechadasDataGridView.Columns[2].Name = "CPF"; // CPF do cliente
            ordensFechadasDataGridView.Columns[3].Name = "Código"; // Código do cliente
            ordensFechadasDataGridView.Columns[4].Name = "Operação"; // Tipo da operação efetuada (Compra/Venda)
            ordensFechadasDataGridView.Columns[5].Name = "Identificador"; // Identificador da transação 
            ordensFechadasDataGridView.Columns[6].Name = "Objeto"; // Objeto da movimentação financeira
        }

        private void cadastroButton_Click(object sender, EventArgs e)
        {
            // Validação de preenchimento dos campos mediante clique no botão
            if (nomeTextBox.Text != null && telefoneTextBox.Text != null && cpfTextBox.Text != null && codigoTextBox.Text != null && operacaoTextBox.Text != null && identificadorTextBox.Text != null && objetoTextBox.Text != null)
            {
                if(!string.IsNullOrWhiteSpace(nomeTextBox.Text) && !string.IsNullOrWhiteSpace(telefoneTextBox.Text) && !string.IsNullOrWhiteSpace(cpfTextBox.Text) && !string.IsNullOrWhiteSpace(codigoTextBox.Text) && !string.IsNullOrWhiteSpace(operacaoTextBox.Text) && !string.IsNullOrWhiteSpace(identificadorTextBox.Text) && !string.IsNullOrWhiteSpace(objetoTextBox.Text))
                {
                    controleLabel.Text = "Cadastro efetuado!";
                    ordensAbertasDataGridView.Rows.Add(nomeTextBox.Text, telefoneTextBox.Text, cpfTextBox.Text, codigoTextBox.Text, operacaoTextBox.Text, identificadorTextBox.Text, objetoTextBox.Text);
                }
                else
                {
                    controleLabel.Text = "Por favor preencha todos os campos!";
                }
            }

            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   
            // Remove uma linha com um duplo clique
            if (e.RowIndex > -1)
            {
                ordensAbertasDataGridView.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            int rowIndex = ordensAbertasDataGridView.CurrentCell.RowIndex;
            ordensAbertasDataGridView.Rows.RemoveAt(rowIndex);
        }

        private void finOrdemButton_Click(object sender, EventArgs e)
        {
            int isTransfer = 0;
            foreach (DataGridViewRow row in ordensAbertasDataGridView.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    ordensFechadasDataGridView.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value, row.Cells[6].Value);
                    isTransfer = 1;
                }
            }

            if(isTransfer == 1)
            {
                int rowIndex = ordensAbertasDataGridView.CurrentCell.RowIndex;
                ordensAbertasDataGridView.Rows.RemoveAt(rowIndex);
            }
        }
    }
}
