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
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Nome"; // Nome do cliente
            dataGridView1.Columns[1].Name = "Telefone"; // Telefone do cliente
            dataGridView1.Columns[2].Name = "CPF"; // CPF do cliente
            dataGridView1.Columns[3].Name = "Código"; // Código do cliente
            dataGridView1.Columns[4].Name = "Operação"; // Tipo da operação efetuada (Compra/Venda)
            dataGridView1.Columns[5].Name = "Identificador"; // Identificador da transação 
            dataGridView1.Columns[6].Name = "Objeto"; // Objeto da movimentação financeira

            dataGridView2.ColumnCount = 7;
            dataGridView2.Columns[0].Name = "Nome"; // Nome do cliente
            dataGridView2.Columns[1].Name = "Telefone"; // Telefone do cliente
            dataGridView2.Columns[2].Name = "CPF"; // CPF do cliente
            dataGridView2.Columns[3].Name = "Código"; // Código do cliente
            dataGridView2.Columns[4].Name = "Operação"; // Tipo da operação efetuada (Compra/Venda)
            dataGridView2.Columns[5].Name = "Identificador"; // Identificador da transação 
            dataGridView2.Columns[6].Name = "Objeto"; // Objeto da movimentação financeira
        }

        private void cadastroButton_Click(object sender, EventArgs e)
        {
            // Validação de preenchimento dos campos mediante clique no botão
            if (nomeTextBox.Text != null && telefoneTextBox.Text != null && cpfTextBox.Text != null && codigoTextBox.Text != null && operacaoTextBox.Text != null && identificadorTextBox.Text != null && objetoTextBox.Text != null)
            {
                if(!string.IsNullOrWhiteSpace(nomeTextBox.Text) && !string.IsNullOrWhiteSpace(telefoneTextBox.Text) && !string.IsNullOrWhiteSpace(cpfTextBox.Text) && !string.IsNullOrWhiteSpace(codigoTextBox.Text) && !string.IsNullOrWhiteSpace(operacaoTextBox.Text) && !string.IsNullOrWhiteSpace(identificadorTextBox.Text) && !string.IsNullOrWhiteSpace(objetoTextBox.Text))
                {
                    controleLabel.Text = "Cadastro efetuado!";
                    dataGridView1.ColumnCount = 7;
                    dataGridView1.Columns[0].Name = "Nome"; // Nome do cliente
                    dataGridView1.Columns[1].Name = "Telefone"; // Telefone do cliente
                    dataGridView1.Columns[2].Name = "CPF"; // CPF do cliente
                    dataGridView1.Columns[3].Name = "Código"; // Código do cliente
                    dataGridView1.Columns[4].Name = "Operação"; // Tipo da operação efetuada (Compra/Venda)
                    dataGridView1.Columns[5].Name = "Identificador"; // Identificador da transação 
                    dataGridView1.Columns[6].Name = "Objeto"; // Objeto da movimentação financeira
                    dataGridView1.Rows.Add(nomeTextBox.Text, telefoneTextBox.Text, cpfTextBox.Text, codigoTextBox.Text, operacaoTextBox.Text, identificadorTextBox.Text, objetoTextBox.Text);
                }
                else
                {
                    controleLabel.Text = "Por favor preencha todos os campos!";
                }
            }
            
            
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   
            // Remove uma linha com um duplo clique
            if (e.RowIndex > -1)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Nome"; // Nome do cliente
            dataGridView1.Columns[1].Name = "Telefone"; // Telefone do cliente
            dataGridView1.Columns[2].Name = "CPF"; // CPF do cliente
            dataGridView1.Columns[3].Name = "Código"; // Código do cliente
            dataGridView1.Columns[4].Name = "Operação"; // Tipo da operação efetuada (Compra/Venda)
            dataGridView1.Columns[5].Name = "Identificador"; // Identificador da transação 
            dataGridView1.Columns[6].Name = "Objeto"; // Objeto da movimentação financeira */
        }
    }
}
