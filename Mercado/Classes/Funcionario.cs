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

        public void lancarProduto()
        {
            /*
             Adicionar um produto no carrinho
                - Insere um novo objeto do tipo Produto em uma List<Produto> passada por parâmetro
                  da função lancarProduto()
            */
        }

        public void fecharCompra()
        {
            /*
             Finalizar a compra
                - Calcular o valor total dos itens no carrinho
             */
        }

        public void receberPagamento(string formPagamento)
        {
            Console.WriteLine($"Pagamento feito por: {formPagamento}");
        }
    }
}
