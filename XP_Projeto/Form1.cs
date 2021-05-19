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
            ordensAbertasDataGridView.Columns[3].Name = "Preço"; // Preço de cada unidade
            ordensAbertasDataGridView.Columns[4].Name = "Operação"; // Tipo da operação efetuada (Compra/Venda)
            ordensAbertasDataGridView.Columns[5].Name = "Ativo"; // Identificador do ativo 
            ordensAbertasDataGridView.Columns[6].Name = "Quantidade"; // Quantidade de ativos movimentos
            DataGridViewCheckBoxColumn checkBoxColuna = new DataGridViewCheckBoxColumn();
            checkBoxColuna.HeaderText = "Selecionar";
            checkBoxColuna.Width = 100;
            checkBoxColuna.Name = "checkBoxColuna";
            ordensAbertasDataGridView.Columns.Insert(7, checkBoxColuna);

            ordensFechadasDataGridView.ColumnCount = 7;
            ordensFechadasDataGridView.Columns[0].Name = "Nome"; // Nome do cliente
            ordensFechadasDataGridView.Columns[1].Name = "Telefone"; // Telefone do cliente
            ordensFechadasDataGridView.Columns[2].Name = "CPF"; // CPF do cliente
            ordensFechadasDataGridView.Columns[3].Name = "Preço"; // Preço de cada unidade
            ordensFechadasDataGridView.Columns[4].Name = "Operação"; // Tipo da operação efetuada (Compra/Venda)
            ordensFechadasDataGridView.Columns[5].Name = "Ativo"; // Identificador do ativo 
            ordensFechadasDataGridView.Columns[6].Name = "Quantidade"; // Quantidade de ativos movimentos
        }

        private bool validaCampos()
        {
            return !string.IsNullOrWhiteSpace(nomeTextBox.Text) && !string.IsNullOrWhiteSpace(telefoneTextBox.Text) &&
                !string.IsNullOrWhiteSpace(cpfTextBox.Text) && !string.IsNullOrWhiteSpace(precoTextBox.Text) &&
                !string.IsNullOrWhiteSpace(operacaoComboBox.Text) && !string.IsNullOrWhiteSpace(ativoTextBox.Text)
                && !string.IsNullOrWhiteSpace(quantidadeTextBox.Text);
        }

        private void cadastroButton_Click(object sender, EventArgs e)
        {
            // Validação de preenchimento dos campos mediante clique no botão:

            if (validaCampos())
            {
                controleLabel.Text = "Cadastro efetuado!";
                // Extrair método: 
                Ordem ordem = new Ordem();
                ordem.Nome = nomeTextBox.Text;
                ordem.Telefone = telefoneTextBox.Text;
                ordem.CPF = cpfTextBox.Text;
                ordem.Preco = precoTextBox.Text;
                ordem.Operacao = operacaoComboBox.Text;
                ordem.Ativo = ativoTextBox.Text;
                ordem.Quantidade = quantidadeTextBox.Text;

                ordensAbertasDataGridView.Rows.Add(nomeTextBox.Text, telefoneTextBox.Text, cpfTextBox.Text, 
                    precoTextBox.Text, operacaoComboBox.Text, ativoTextBox.Text, quantidadeTextBox.Text);
            }
            else
            {
                controleLabel.Text = "Por favor preencha todos os campos!";
            }

            // Limpeza dos campos de preenchimento após clique do botão:

            foreach (Control preenchimento in Controls)
            {
                if (preenchimento is TextBox || preenchimento is ComboBox)
                {
                    preenchimento.Text = "";
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
            int indiceLinha = ordensAbertasDataGridView.CurrentCell.RowIndex;
            ordensAbertasDataGridView.Rows.RemoveAt(indiceLinha);
        }

        private void finOrdemButton_Click(object sender, EventArgs e)
        {
            int transferido = 0;
            foreach (DataGridViewRow row in ordensAbertasDataGridView.Rows)
            {
                bool selecionado = Convert.ToBoolean(row.Cells["checkBoxColuna"].Value);
                if (selecionado)
                {
                    ordensFechadasDataGridView.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, 
                        row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value, row.Cells[6].Value);
                    transferido = 1;
                }
            }

            if(transferido == 1)
            {
                int indiceLinha = ordensAbertasDataGridView.CurrentCell.RowIndex;
                ordensAbertasDataGridView.Rows.RemoveAt(indiceLinha);
            }
        }
    }
}
