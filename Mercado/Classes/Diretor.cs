using Mercado.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado.Classes
{
    class Diretor : Funcionario, IRemover
    {
        public Diretor(string nome) : base(nome)
        {
        }

        public void remover()
        {
            /*
             Excluir um item da List<Produto>
                - remover() deve receber a List como parâmetro para poder remover o item
             */
            Console.WriteLine("Item excluído");
        }
    }
}
