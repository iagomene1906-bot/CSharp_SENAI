using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeCursos
{
    public abstract class Curso
    {
        public string nome { get; set; } = string.Empty; // "", vázio
        public int horas { get; set; }

        public Curso(string nomeConstrutor, int horasConstrutor) // Construtor vai forçar preencher os valores
        {
            nome = nomeConstrutor;
            horas = horasConstrutor;
        }

        public abstract double calcularPreco(); // Faz modificação em outro lugar

        public virtual void exibirResumo() // virtual = para ser sobrescrito, void = vazio
        {
            Console.WriteLine($"Curso: {nome}");
            Console.WriteLine($"Horas: {horas}");
            Console.WriteLine($"Preço final: {calcularPreco():f2}\n");
            
        }
    }
}