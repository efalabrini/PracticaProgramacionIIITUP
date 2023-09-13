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
            Coche auto = new(0);
            Console.WriteLine("Ingrese una cantidad de combustible para cargar:");
            int combustible = int.Parse(Console.ReadLine() ?? "");
            auto.CargarCombustible(combustible);
            auto.Conducir();
        }
    }
}
