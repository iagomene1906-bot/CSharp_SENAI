using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLanchonete.Models
{
    public class Sobremesa : Produto
    {
        public Sobremesa(string nomeProduto, decimal precoBase) : base(nomeProduto, precoBase)
        {

        }

        public decimal aplicarDesconto()
        {
            return precoBase * 0.10m;
        }

        public override decimal calcularPrecoFinal() 
        {
            return precoBase - aplicarDesconto();
        }

        public override void exibirResumo()
        {
            Console.WriteLine($"Tipo: Sobremesa");
            base.exibirResumo();
            Console.WriteLine($"Desconto: R$ {aplicarDesconto():f2}");
        }
        
    }
}