using System;
using System.Collections.Generic;
using System.Text;

namespace XP_Projeto
{
    class Ordem
    {
        private string nome; 
        private string telefone;
        private string cpf;
        private string preco;
        private string operacao;
        private string ativo;
        private string quantidade;

        // Construtor da classe:
        public Ordem(string nome, string telefone, string cpf, string preco, 
            string operacao, string ativo, string quantidade)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cpf = cpf;
            this.preco = preco;
            this.operacao = operacao;
            this.ativo = ativo;
            this.quantidade = quantidade;
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                telefone = value;
            }
        }
        public string CPF
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;
            }
        }
        public string Preco
        {
            get
            {
                return preco;
            }
            set
            {
                preco = value;
            }
        }
       
        public string Operacao
        {
            get
            {
                return operacao;
            }
            set
            {
                operacao = value;
            }
        }
       
        public string Ativo
        {
            get
            {
                return ativo;
            }
            set
            {
                ativo = value;
            }
        }
       
        public string Quantidade
        {
            get
            {
                return quantidade;
            }
            set
            {
                quantidade = value;
            }
        }
    }
}
