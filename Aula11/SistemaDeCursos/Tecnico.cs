using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeCursos
{
    public class Tecnico : Curso
    {
        public Tecnico(string nomeConstrutor, int horasConstrutor) : base(nomeConstrutor, horasConstrutor)
        {

        }

        // Sobrescrevendo a informação do método abstrato
        public override double calcularPreco()
        {
            return horas * 20; // Valor por hora
        }
    }
}