using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLanchonete
{
    public class Bebida : Produto
    {
        public Bebida(string nomeProduto, decimal precoBase) : base(nomeProduto, precoBase)
        {

        }

        public override decimal calcularPrecoFinal()
        {
            return precoBase;
        }

        public override void exibirResumo()
        {
            Console.WriteLine($"Tipo: Bebida");
            base.exibirResumo();
            Console.WriteLine();
        }
    }
}