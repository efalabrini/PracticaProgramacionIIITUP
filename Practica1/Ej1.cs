using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Ej1 : IEjercicio
    {
        public void Ejecutar()
        {
            int a = 1, b = 2, c = 3, d;

            d = a + b + c;

            Console.WriteLine(d);

        }
    }
}
