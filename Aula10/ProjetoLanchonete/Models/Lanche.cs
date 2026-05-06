using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLanchonete
{
    public class Lanche : Produto
    {
        private decimal taxaDeEmbalagem = 2m;

        public Lanche(string nomeProduto, decimal precoBase) : base(nomeProduto, precoBase)
        {

        }

        public override decimal calcularPrecoFinal()
        {
            return  precoBase + taxaDeEmbalagem;            
        }

        public override void exibirResumo(){
            Console.WriteLine($"Tipo: Lanche");
            base.exibirResumo();
            Console.WriteLine();
        }
    }
}