
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
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.controleLabel = new System.Windows.Forms.Label();
            this.cadastroButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ordensFinalizadasLabel = new System.Windows.Forms.Label();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.operacaoLabel = new System.Windows.Forms.Label();
            this.operacaoTextBox = new System.Windows.Forms.TextBox();
            this.identificadorTextBox = new System.Windows.Forms.TextBox();
            this.objetoTextBox = new System.Windows.Forms.TextBox();
            this.identificadorLabel = new System.Windows.Forms.Label();
            this.objetoLabel = new System.Windows.Forms.Label();
            this.ordensAbertasLabel = new System.Windows.Forms.Label();
            this.excluirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
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
            this.nomeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
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
            this.cadastroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cadastroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(112)))));
            this.cadastroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastroButton.ForeColor = System.Drawing.Color.White;
            this.cadastroButton.Location = new System.Drawing.Point(1027, 10);
            this.cadastroButton.Margin = new System.Windows.Forms.Padding(4);
            this.cadastroButton.Name = "cadastroButton";
            this.cadastroButton.Size = new System.Drawing.Size(107, 32);
            this.cadastroButton.TabIndex = 3;
            this.cadastroButton.Text = "Cadastrar";
            this.cadastroButton.UseVisualStyleBackColor = false;
            this.cadastroButton.Click += new System.EventHandler(this.cadastroButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 178);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1121, 210);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cpfLabel
            // 
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
            this.cpfTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.cpfTextBox.Location = new System.Drawing.Point(860, 11);
            this.cpfTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(141, 27);
            this.cpfTextBox.TabIndex = 6;
            // 
            // telefoneLabel
            // 
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
            this.telefoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.telefoneTextBox.Location = new System.Drawing.Point(621, 10);
            this.telefoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(141, 27);
            this.telefoneTextBox.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 448);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1121, 221);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ordensFinalizadasLabel
            // 
            this.ordensFinalizadasLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ordensFinalizadasLabel.AutoSize = true;
            this.ordensFinalizadasLabel.Location = new System.Drawing.Point(13, 406);
            this.ordensFinalizadasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ordensFinalizadasLabel.Name = "ordensFinalizadasLabel";
            this.ordensFinalizadasLabel.Size = new System.Drawing.Size(158, 21);
            this.ordensFinalizadasLabel.TabIndex = 10;
            this.ordensFinalizadasLabel.Text = "Ordens Finalizadas:";
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(780, 60);
            this.codigoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(72, 21);
            this.codigoLabel.TabIndex = 11;
            this.codigoLabel.Text = "Código:";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.codigoTextBox.Location = new System.Drawing.Point(860, 57);
            this.codigoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(141, 27);
            this.codigoTextBox.TabIndex = 12;
            // 
            // operacaoLabel
            // 
            this.operacaoLabel.AutoSize = true;
            this.operacaoLabel.Location = new System.Drawing.Point(13, 59);
            this.operacaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.operacaoLabel.Name = "operacaoLabel";
            this.operacaoLabel.Size = new System.Drawing.Size(96, 21);
            this.operacaoLabel.TabIndex = 13;
            this.operacaoLabel.Text = "Operação:";
            // 
            // operacaoTextBox
            // 
            this.operacaoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.operacaoTextBox.Location = new System.Drawing.Point(114, 57);
            this.operacaoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.operacaoTextBox.Name = "operacaoTextBox";
            this.operacaoTextBox.Size = new System.Drawing.Size(141, 27);
            this.operacaoTextBox.TabIndex = 14;
            // 
            // identificadorTextBox
            // 
            this.identificadorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.identificadorTextBox.Location = new System.Drawing.Point(380, 57);
            this.identificadorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.identificadorTextBox.Name = "identificadorTextBox";
            this.identificadorTextBox.Size = new System.Drawing.Size(148, 27);
            this.identificadorTextBox.TabIndex = 15;
            // 
            // objetoTextBox
            // 
            this.objetoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(92)))));
            this.objetoTextBox.Location = new System.Drawing.Point(621, 57);
            this.objetoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.objetoTextBox.Name = "objetoTextBox";
            this.objetoTextBox.Size = new System.Drawing.Size(141, 27);
            this.objetoTextBox.TabIndex = 16;
            // 
            // identificadorLabel
            // 
            this.identificadorLabel.AutoSize = true;
            this.identificadorLabel.Location = new System.Drawing.Point(263, 60);
            this.identificadorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.identificadorLabel.Name = "identificadorLabel";
            this.identificadorLabel.Size = new System.Drawing.Size(115, 21);
            this.identificadorLabel.TabIndex = 17;
            this.identificadorLabel.Text = "Identificador:";
            // 
            // objetoLabel
            // 
            this.objetoLabel.AutoSize = true;
            this.objetoLabel.Location = new System.Drawing.Point(544, 60);
            this.objetoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.objetoLabel.Name = "objetoLabel";
            this.objetoLabel.Size = new System.Drawing.Size(69, 21);
            this.objetoLabel.TabIndex = 18;
            this.objetoLabel.Text = "Objeto:";
            // 
            // ordensAbertasLabel
            // 
            this.ordensAbertasLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ordensAbertasLabel.AutoSize = true;
            this.ordensAbertasLabel.Location = new System.Drawing.Point(13, 143);
            this.ordensAbertasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ordensAbertasLabel.Name = "ordensAbertasLabel";
            this.ordensAbertasLabel.Size = new System.Drawing.Size(159, 21);
            this.ordensAbertasLabel.TabIndex = 19;
            this.ordensAbertasLabel.Text = "Ordens em Aberto:";
            // 
            // excluirButton
            // 
            this.excluirButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.excluirButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(112)))));
            this.excluirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirButton.Location = new System.Drawing.Point(1027, 54);
            this.excluirButton.Margin = new System.Windows.Forms.Padding(4);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(107, 32);
            this.excluirButton.TabIndex = 20;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1147, 682);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.ordensAbertasLabel);
            this.Controls.Add(this.objetoLabel);
            this.Controls.Add(this.identificadorLabel);
            this.Controls.Add(this.objetoTextBox);
            this.Controls.Add(this.identificadorTextBox);
            this.Controls.Add(this.operacaoTextBox);
            this.Controls.Add(this.operacaoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.codigoLabel);
            this.Controls.Add(this.ordensFinalizadasLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.telefoneLabel);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(this.cpfLabel);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label controleLabel;
        private System.Windows.Forms.Button cadastroButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.Label telefoneLabel;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label ordensFinalizadasLabel;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Label operacaoLabel;
        private System.Windows.Forms.TextBox operacaoTextBox;
        private System.Windows.Forms.TextBox identificadorTextBox;
        private System.Windows.Forms.TextBox objetoTextBox;
        private System.Windows.Forms.Label identificadorLabel;
        private System.Windows.Forms.Label objetoLabel;
        private System.Windows.Forms.Label ordensAbertasLabel;
        private System.Windows.Forms.Button excluirButton;
    }
}

