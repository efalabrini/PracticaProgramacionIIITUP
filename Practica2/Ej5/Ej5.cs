using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    public class Ej5
    {
        public void Ejecutar()
        {
            Coche c = new Coche(0);

            Console.Write("Ingrese la cantidad de combustible a cargar: ");
            int combustible = int.Parse(Console.ReadLine());

            c.CargarCombustible(combustible);
            c.Conducir();
        }
    }
}
