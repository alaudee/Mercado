using Mercado.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado.Interfaces
{
    interface IRemover
    {
        public void remover(Carrinho carrinho, Produto produto);
    }
}
