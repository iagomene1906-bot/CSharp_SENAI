using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLanchonete
{
    public abstract class Produto
    {
        public string nomeProduto { get; set; }

        private decimal precoBaseProduto;

        public decimal precoBase{
            get {return precoBaseProduto;}

            set
            {
                if (value >= 0)
                    precoBaseProduto = value;
                else
                    precoBaseProduto = 0;
            }
        }

        // Construtor
        public Produto(string nome, decimal precoBase)
        {
            nomeProduto = nome;
            precoBaseProduto = precoBase;
        }

        // Método abstrato
        public abstract decimal calcularPrecoFinal();

        public virtual void exibirResumo(){
            Console.WriteLine($"Produto: {nomeProduto}");
            Console.WriteLine($"Preço final: ${calcularPrecoFinal():f2}");
        }
    }
}