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
        // Criação de listas de objetos da classe Ordem:
        List<Ordem> ordensAbertasLista = new List<Ordem>();
        List<Ordem> ordensFechadasLista = new List<Ordem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Definições de propriedades dos grids:
            // Grid de ordens abertas:
            ordensAbertasDataGridView.ColumnCount = 7;
            ordensAbertasDataGridView.Columns[0].Name = "Nome"; // Nome do cliente
            ordensAbertasDataGridView.Columns[0].Width = 150;
            ordensAbertasDataGridView.Columns[1].Name = "Telefone"; // Telefone do cliente
            ordensAbertasDataGridView.Columns[1].Width = 150;
            ordensAbertasDataGridView.Columns[2].Name = "CPF"; // CPF do cliente
            ordensAbertasDataGridView.Columns[2].Width = 150;
            ordensAbertasDataGridView.Columns[3].Name = "Preço"; // Preço de cada unidade
            ordensAbertasDataGridView.Columns[3].Width = 150;
            ordensAbertasDataGridView.Columns[4].Name = "Operação"; // Tipo da operação efetuada (Compra/Venda)
            ordensAbertasDataGridView.Columns[4].Width = 150;
            ordensAbertasDataGridView.Columns[5].Name = "Ativo"; // Identificador do ativo 
            ordensAbertasDataGridView.Columns[5].Width = 150;
            ordensAbertasDataGridView.Columns[6].Name = "Quantidade"; // Quantidade de ativos movimentos
            ordensAbertasDataGridView.Columns[6].Width = 150;
            DataGridViewCheckBoxColumn checkBoxColuna = new DataGridViewCheckBoxColumn();
            checkBoxColuna.HeaderText = "Selecionar";
            checkBoxColuna.Width = 100;
            checkBoxColuna.Name = "checkBoxColuna";
            ordensAbertasDataGridView.Columns.Insert(7, checkBoxColuna);

            // Grid de ordens fechadas:
            ordensFechadasDataGridView.ColumnCount = 7;
            ordensFechadasDataGridView.Columns[0].Name = "Nome"; // Nome do cliente
            ordensFechadasDataGridView.Columns[0].Width = 150;
            ordensFechadasDataGridView.Columns[1].Name = "Telefone"; // Telefone do cliente
            ordensFechadasDataGridView.Columns[1].Width = 150;
            ordensFechadasDataGridView.Columns[2].Name = "CPF"; // CPF do cliente
            ordensFechadasDataGridView.Columns[2].Width = 150;
            ordensFechadasDataGridView.Columns[3].Name = "Preço"; // Preço de cada unidade
            ordensFechadasDataGridView.Columns[3].Width = 150;
            ordensFechadasDataGridView.Columns[4].Name = "Operação"; // Tipo da operação efetuada (Compra/Venda)
            ordensFechadasDataGridView.Columns[4].Width = 150;
            ordensFechadasDataGridView.Columns[5].Name = "Ativo"; // Identificador do ativo
            ordensFechadasDataGridView.Columns[5].Width = 150;
            ordensFechadasDataGridView.Columns[6].Name = "Quantidade"; // Quantidade de ativos movimentos
            ordensFechadasDataGridView.Columns[6].Width = 150;
        }

        private bool validaCampos()
        {
            // Verificação se os campos estão preenchidos com caracteres ou números
            return !string.IsNullOrWhiteSpace(nomeTextBox.Text) && !string.IsNullOrWhiteSpace(telefoneTextBox.Text) &&
                !string.IsNullOrWhiteSpace(cpfTextBox.Text) && !string.IsNullOrWhiteSpace(precoTextBox.Text) &&
                !string.IsNullOrWhiteSpace(operacaoComboBox.Text) && !string.IsNullOrWhiteSpace(ativoTextBox.Text)
                && !string.IsNullOrWhiteSpace(quantidadeTextBox.Text);
        }

        private void cadastroButton_Click(object sender, EventArgs e)
        {
            // Apenas permite um cadastro se todos os campos estão preenchidos:
            if (validaCampos())
            {
                controleLabel.Text = "Cadastro efetuado!";

                // Adição de novo objeto ordem tanto em uma lista como na tabela exibida em tela
                ordensAbertasLista.Add(new Ordem(nomeTextBox.Text, telefoneTextBox.Text, cpfTextBox.Text,
                    precoTextBox.Text, operacaoComboBox.Text, ativoTextBox.Text, quantidadeTextBox.Text));

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

        // Função para exclusão de uma ordem
        private void excluirButton_Click(object sender, EventArgs e)
        {
            int indiceLinha = ordensAbertasDataGridView.CurrentCell.RowIndex;
            ordensAbertasDataGridView.Rows.RemoveAt(indiceLinha);
        }

        // Função para finalização de uma ordem. Move o conteúdo de uma linha do grid de
        // ordens abertas para o grid de ordens fechadas.
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
                    ordensFechadasLista.Add(new Ordem(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), 
                        row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString()));
                    transferido = 1;
                }
            }

            if(transferido == 1)
            {
                int indiceLinha = ordensAbertasDataGridView.CurrentCell.RowIndex;
                ordensAbertasDataGridView.Rows.RemoveAt(indiceLinha);
            }
        }

        // Edição do conteúdo de uma ordem em aberto
        private void editarButton_Click(object sender, EventArgs e)
        {
            int selecionado = 0;
            if (ordensAbertasDataGridView.SelectedRows.Count > -1)
            {
                nomeTextBox.Text = ordensAbertasDataGridView.SelectedRows[0].Cells["Nome"].Value.ToString();
                telefoneTextBox.Text = ordensAbertasDataGridView.SelectedRows[0].Cells["Telefone"].Value.ToString();
                cpfTextBox.Text = ordensAbertasDataGridView.SelectedRows[0].Cells["CPF"].Value.ToString();
                precoTextBox.Text = ordensAbertasDataGridView.SelectedRows[0].Cells["Preço"].Value.ToString();
                operacaoComboBox.Text = ordensAbertasDataGridView.SelectedRows[0].Cells["Operação"].Value.ToString();
                ativoTextBox.Text = ordensAbertasDataGridView.SelectedRows[0].Cells["Ativo"].Value.ToString();
                quantidadeTextBox.Text = ordensAbertasDataGridView.SelectedRows[0].Cells["Quantidade"].Value.ToString();
                selecionado = 1;
            }
            if(selecionado == 1)
            {
                int indiceLinha = ordensAbertasDataGridView.CurrentCell.RowIndex;
                ordensAbertasDataGridView.Rows.RemoveAt(indiceLinha);
            }
        }
    }
}
