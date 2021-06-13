using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado.Classes
{
    class Gerente : Funcionario
    {
        public Gerente(string nome) : base(nome)
        {
        }

        public void remover(Carrinho carrinho, Produto produto)
        {
            carrinho.removerProduto(produto);
            Console.WriteLine($"-Removido pelo Gerente: {produto.Nome}");
        }
    }
}
