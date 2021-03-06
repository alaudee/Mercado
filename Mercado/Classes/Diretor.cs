using Mercado.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado.Classes
{
    class Diretor : Funcionario
    {
        public Diretor(string nome) : base(nome)
        {
        }

        public void remover(Carrinho carrinho, Produto produto)
        {
            carrinho.removerProduto(produto);
            Console.WriteLine($"-Removido pelo Diretor: {produto.Nome}");
        }
    }
}
