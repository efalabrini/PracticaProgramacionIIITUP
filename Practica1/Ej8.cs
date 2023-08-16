using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Ej8 : IEjercicio
    {
        public void Ejecutar()
        {
            int i = 1;
            while (i < 101)
            {
                Console.WriteLine(i);
                i++;

            }
        }
    }
}
