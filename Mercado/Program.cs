using Mercado.Classes;
using System;

namespace Mercado
{
    class Program
    {
        static void Main(string[] args)
        {
            Atendente atendente = new Atendente("christopher");

            Diretor diretor = new Diretor("João");
            diretor.remover();
            diretor.receberPagamento("Cartão");
        }
    }
}
