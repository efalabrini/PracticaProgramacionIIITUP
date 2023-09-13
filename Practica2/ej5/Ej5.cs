using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.ej5
{
    public class Ej5
    {
        public void Ejecutar()
        {
            coche c = new(0);

            Console.WriteLine("cargue naftita ingrese num");
            int epa = Int32.Parse(Console.ReadLine());

            c.CargarCombustible(epa);

            c.Conducir();
        }
    }
}
