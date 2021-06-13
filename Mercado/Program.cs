using Mercado.Classes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Mercado
{
    class Program
    {
        static void Main(string[] args)
        {
            Atendente atendente = new Atendente("christopher");

            Diretor diretor = new Diretor("João");

            Gerente gerente = new Gerente("Thiago");

            Carrinho carrinho = new Carrinho();

            Produto banana = new Produto("Banana", 0.5, 4.5);

            Produto cerveja = new Produto("Heineken", 1, 5);
            Produto cerveja2 = new Produto("Heineken", 1, 5);

            atendente.lancarProduto(carrinho, banana);

            atendente.lancarProduto(carrinho, cerveja);

            atendente.lancarProduto(carrinho, cerveja2);

            diretor.remover(carrinho, cerveja);

            gerente.remover(carrinho, banana);

            atendente.fecharCompra(carrinho, atendente);
            atendente.receberPagamento("Cartão");
        }
    }
}
