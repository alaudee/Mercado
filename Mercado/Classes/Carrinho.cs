using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mercado.Classes
{
    class Carrinho
    {
        public ArrayList carrinho { get; set; }

        public Carrinho()
        {
            this.carrinho = new ArrayList();
        }

        public void adicionarProduto(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void removerProduto(Produto produto)
        {
            Produto itemExclusao = null;

            foreach (Produto p in carrinho)
            {
                if (p.Equals(produto))
                {
                    itemExclusao = p;
                }
            }

            carrinho.Remove(itemExclusao);
        }

        public void fecharCompra(Carrinho carrinho)
        {
            double total = 0;

            foreach (Produto p in carrinho.carrinho)
            {
                total += p.ValorFinal;
            }

            Console.WriteLine($"------------------ \nTotal      R$ {total}");
        }

        public void mostrarCarrinho()
        {
            foreach(Produto p in carrinho)
            {
                Console.WriteLine($"{p.Nome}");
            }
        }
    }
}
