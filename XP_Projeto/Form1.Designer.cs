﻿
namespace XP_Projeto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.controleLabel = new System.Windows.Forms.Label();
            this.cadastroButton = new System.Windows.Forms.Button();
            this.ordensAbertasDataGridView = new System.Windows.Forms.DataGridView();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.ordensFinalizadasLabel = new System.Windows.Forms.Label();
            this.precoLabel = new System.Windows.Forms.Label();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.operacaoLabel = new System.Windows.Forms.Label();
            this.ativoTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.ativoLabel = new System.Windows.Forms.Label();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.ordensAbertasLabel = new System.Windows.Forms.Label();
            this.excluirButton = new System.Windows.Forms.Button();
            this.finOrdemButton = new System.Windows.Forms.Button();
            this.ordensFechadasDataGridView = new System.Windows.Forms.DataGridView();
            this.operacaoComboBox = new System.Windows.Forms.ComboBox();
            this.editarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordensAbertasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordensFechadasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(13, 13);
            this.nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(61, 21);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nomeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.nomeTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nomeTextBox.Location = new System.Drawing.Point(82, 11);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(446, 27);
            this.nomeTextBox.TabIndex = 1;
            // 
            // controleLabel
            // 
            this.controleLabel.AutoSize = true;
            this.controleLabel.Location = new System.Drawing.Point(19, 105);
            this.controleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.controleLabel.Name = "controleLabel";
            this.controleLabel.Size = new System.Drawing.Size(0, 21);
            this.controleLabel.TabIndex = 2;
            // 
            // cadastroButton
            // 
            this.cadastroButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cadastroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.cadastroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastroButton.ForeColor = System.Drawing.Color.White;
            this.cadastroButton.Location = new System.Drawing.Point(264, 138);
            this.cadastroButton.Margin = new System.Windows.Forms.Padding(4);
            this.cadastroButton.Name = "cadastroButton";
            this.cadastroButton.Size = new System.Drawing.Size(184, 32);
            this.cadastroButton.TabIndex = 3;
            this.cadastroButton.Text = "Cadastrar";
            this.cadastroButton.UseVisualStyleBackColor = false;
            this.cadastroButton.Click += new System.EventHandler(this.cadastroButton_Click);
            // 
            // ordensAbertasDataGridView
            // 
            this.ordensAbertasDataGridView.AllowUserToAddRows = false;
            this.ordensAbertasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ordensAbertasDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordensAbertasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ordensAbertasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordensAbertasDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ordensAbertasDataGridView.GridColor = System.Drawing.SystemColors.ControlText;
            this.ordensAbertasDataGridView.Location = new System.Drawing.Point(12, 178);
            this.ordensAbertasDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ordensAbertasDataGridView.MultiSelect = false;
            this.ordensAbertasDataGridView.Name = "ordensAbertasDataGridView";
            this.ordensAbertasDataGridView.RowTemplate.Height = 25;
            this.ordensAbertasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordensAbertasDataGridView.Size = new System.Drawing.Size(1007, 210);
            this.ordensAbertasDataGridView.TabIndex = 4;
            // 
            // cpfLabel
            // 
            this.cpfLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Location = new System.Drawing.Point(808, 13);
            this.cpfLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(44, 21);
            this.cpfLabel.TabIndex = 5;
            this.cpfLabel.Text = "CPF:";
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cpfTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cpfTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cpfTextBox.Location = new System.Drawing.Point(860, 11);
            this.cpfTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(156, 27);
            this.cpfTextBox.TabIndex = 6;
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(536, 13);
            this.telefoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(80, 21);
            this.telefoneLabel.TabIndex = 7;
            this.telefoneLabel.Text = "Telefone:";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telefoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.telefoneTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.telefoneTextBox.Location = new System.Drawing.Point(621, 10);
            this.telefoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(141, 27);
            this.telefoneTextBox.TabIndex = 8;
            // 
            // ordensFinalizadasLabel
            // 
            this.ordensFinalizadasLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ordensFinalizadasLabel.AutoSize = true;
            this.ordensFinalizadasLabel.Location = new System.Drawing.Point(13, 407);
            this.ordensFinalizadasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ordensFinalizadasLabel.Name = "ordensFinalizadasLabel";
            this.ordensFinalizadasLabel.Size = new System.Drawing.Size(158, 21);
            this.ordensFinalizadasLabel.TabIndex = 10;
            this.ordensFinalizadasLabel.Text = "Ordens Finalizadas:";
            // 
            // precoLabel
            // 
            this.precoLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.precoLabel.AutoSize = true;
            this.precoLabel.Location = new System.Drawing.Point(794, 60);
            this.precoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precoLabel.Name = "precoLabel";
            this.precoLabel.Size = new System.Drawing.Size(58, 21);
            this.precoLabel.TabIndex = 11;
            this.precoLabel.Text = "Preço:";
            // 
            // precoTextBox
            // 
            this.precoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.precoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.precoTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.precoTextBox.Location = new System.Drawing.Point(860, 57);
            this.precoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(156, 27);
            this.precoTextBox.TabIndex = 12;
            // 
            // operacaoLabel
            // 
            this.operacaoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.operacaoLabel.AutoSize = true;
            this.operacaoLabel.Location = new System.Drawing.Point(13, 59);
            this.operacaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.operacaoLabel.Name = "operacaoLabel";
            this.operacaoLabel.Size = new System.Drawing.Size(96, 21);
            this.operacaoLabel.TabIndex = 13;
            this.operacaoLabel.Text = "Operação:";
            // 
            // ativoTextBox
            // 
            this.ativoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ativoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ativoTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ativoTextBox.Location = new System.Drawing.Point(621, 57);
            this.ativoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ativoTextBox.Name = "ativoTextBox";
            this.ativoTextBox.Size = new System.Drawing.Size(141, 27);
            this.ativoTextBox.TabIndex = 15;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantidadeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.quantidadeTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quantidadeTextBox.Location = new System.Drawing.Point(387, 59);
            this.quantidadeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(141, 27);
            this.quantidadeTextBox.TabIndex = 16;
            // 
            // ativoLabel
            // 
            this.ativoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ativoLabel.AutoSize = true;
            this.ativoLabel.Location = new System.Drawing.Point(556, 60);
            this.ativoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ativoLabel.Name = "ativoLabel";
            this.ativoLabel.Size = new System.Drawing.Size(57, 21);
            this.ativoLabel.TabIndex = 17;
            this.ativoLabel.Text = "Ativo:";
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Location = new System.Drawing.Point(267, 62);
            this.quantidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(112, 21);
            this.quantidadeLabel.TabIndex = 18;
            this.quantidadeLabel.Text = "Quantidade:";
            // 
            // ordensAbertasLabel
            // 
            this.ordensAbertasLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ordensAbertasLabel.AutoSize = true;
            this.ordensAbertasLabel.Location = new System.Drawing.Point(13, 144);
            this.ordensAbertasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ordensAbertasLabel.Name = "ordensAbertasLabel";
            this.ordensAbertasLabel.Size = new System.Drawing.Size(159, 21);
            this.ordensAbertasLabel.TabIndex = 19;
            this.ordensAbertasLabel.Text = "Ordens em Aberto:";
            // 
            // excluirButton
            // 
            this.excluirButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.excluirButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.excluirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirButton.Location = new System.Drawing.Point(646, 138);
            this.excluirButton.Margin = new System.Windows.Forms.Padding(4);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(184, 32);
            this.excluirButton.TabIndex = 20;
            this.excluirButton.Text = "Cancelar Ordem";
            this.excluirButton.UseVisualStyleBackColor = false;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // finOrdemButton
            // 
            this.finOrdemButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.finOrdemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.finOrdemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finOrdemButton.Location = new System.Drawing.Point(837, 138);
            this.finOrdemButton.Name = "finOrdemButton";
            this.finOrdemButton.Size = new System.Drawing.Size(184, 32);
            this.finOrdemButton.TabIndex = 21;
            this.finOrdemButton.Text = "Finalizar Ordem";
            this.finOrdemButton.UseVisualStyleBackColor = false;
            this.finOrdemButton.Click += new System.EventHandler(this.finOrdemButton_Click);
            // 
            // ordensFechadasDataGridView
            // 
            this.ordensFechadasDataGridView.AllowUserToAddRows = false;
            this.ordensFechadasDataGridView.AllowUserToDeleteRows = false;
            this.ordensFechadasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ordensFechadasDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ordensFechadasDataGridView.CausesValidation = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordensFechadasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ordensFechadasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordensFechadasDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.ordensFechadasDataGridView.Location = new System.Drawing.Point(12, 449);
            this.ordensFechadasDataGridView.MultiSelect = false;
            this.ordensFechadasDataGridView.Name = "ordensFechadasDataGridView";
            this.ordensFechadasDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordensFechadasDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ordensFechadasDataGridView.RowTemplate.Height = 25;
            this.ordensFechadasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordensFechadasDataGridView.Size = new System.Drawing.Size(1009, 207);
            this.ordensFechadasDataGridView.TabIndex = 22;
            // 
            // operacaoComboBox
            // 
            this.operacaoComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.operacaoComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.operacaoComboBox.ForeColor = System.Drawing.Color.White;
            this.operacaoComboBox.FormattingEnabled = true;
            this.operacaoComboBox.Items.AddRange(new object[] {
            "Compra",
            "Venda"});
            this.operacaoComboBox.Location = new System.Drawing.Point(116, 57);
            this.operacaoComboBox.Name = "operacaoComboBox";
            this.operacaoComboBox.Size = new System.Drawing.Size(140, 29);
            this.operacaoComboBox.TabIndex = 23;
            // 
            // editarButton
            // 
            this.editarButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.editarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarButton.Location = new System.Drawing.Point(455, 138);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(184, 32);
            this.editarButton.TabIndex = 24;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = false;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(34)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1029, 684);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.operacaoComboBox);
            this.Controls.Add(this.ordensFechadasDataGridView);
            this.Controls.Add(this.finOrdemButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.ordensAbertasLabel);
            this.Controls.Add(this.quantidadeLabel);
            this.Controls.Add(this.ativoLabel);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(this.ativoTextBox);
            this.Controls.Add(this.operacaoLabel);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.precoLabel);
            this.Controls.Add(this.ordensFinalizadasLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.telefoneLabel);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(this.cpfLabel);
            this.Controls.Add(this.ordensAbertasDataGridView);
            this.Controls.Add(this.cadastroButton);
            this.Controls.Add(this.controleLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.nomeLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordensAbertasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordensFechadasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label controleLabel;
        private System.Windows.Forms.Button cadastroButton;
        private System.Windows.Forms.DataGridView ordensAbertasDataGridView;
        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.Label telefoneLabel;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.Label ordensFinalizadasLabel;
        private System.Windows.Forms.Label precoLabel;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.Label operacaoLabel;
        private System.Windows.Forms.TextBox ativoTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.Label ativoLabel;
        private System.Windows.Forms.Label quantidadeLabel;
        private System.Windows.Forms.Label ordensAbertasLabel;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button finOrdemButton;
        private System.Windows.Forms.DataGridView ordensFechadasDataGridView;
        private System.Windows.Forms.ComboBox operacaoComboBox;
        private System.Windows.Forms.Button editarButton;
    }
}

