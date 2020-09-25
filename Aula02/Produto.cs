using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02
{
    class Produto
    {
        public int codigo;
        public string nome;
        public int quantidade;
        public double preco;
        public DateTime validade;
        public Produto()
        {
            codigo = -1;
            nome = "Aderbaldo";
            quantidade = -1;
            preco = -1;
        }
        public Produto(int codigo, string nome, int quantidade, double preco,DateTime validade)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
            this.validade = validade;
        }
        public Produto(string nome, int quantidade, double preco)
        {

            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
        }
    }

}
