using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeCursos
{
    public class Superior : Curso
    {
        public Superior(string nomeConstrutor, int horasConstrutor) : base(nomeConstrutor, horasConstrutor) 
        {

        }

        public override double calcularPreco()
        {
            return horas * 40;
        }
    }
}