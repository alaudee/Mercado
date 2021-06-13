using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado.Classes
{
    class Produto
    {
        public string Nome { get; set; }

        public double Preco { get; set; }

        public double ValorFinal { get; set; }

        public Produto(string nome, double qtdeOuKg, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.ValorFinal = qtdeOuKg * preco;
        }
    }
}
