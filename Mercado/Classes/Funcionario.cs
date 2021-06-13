using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado.Classes
{
    class Funcionario
    {
        public string Nome { get; set; }

        public Funcionario(string nome)
        {
            this.Nome = nome;
        }

        public void lancarProduto(Carrinho carrinho, Produto produto)
        {
            carrinho.adicionarProduto(produto);
            Console.WriteLine($"{produto.Nome}          R$ {produto.Preco.ToString()}");
        }

        public void fecharCompra(Carrinho carrinho, Funcionario funcionario)
        {
            carrinho.fecharCompra(carrinho);
            Console.WriteLine($"\nAtendido por: {funcionario.Nome}");
        }

        public void receberPagamento(string formPagamento)
        {
            Console.WriteLine($"Pagamento feito por: {formPagamento}");
        }
    }
}
