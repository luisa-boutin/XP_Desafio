using System;
using System.Collections.Generic;
using System.Text;

namespace XP_Projeto
{
    class Ordem
    {
        private string nome; // Campo
        public string Nome // Propriedade
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

        private string telefone; // Campo
        public string Telefone // Propriedade
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

        private string cpf; // Campo
        public string CPF // Propriedade
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

        private string preco; // Campo
        public string Preco // Propriedade
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

        private string operacao; // Campo
        public string Operacao // Propriedade
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

        private string ativo; // Campo
        public string Ativo // Propriedade
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

        private string quantidade; // Campo
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
