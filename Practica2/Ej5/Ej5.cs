using Practica2.Ej4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    internal class Ej5
    {
       public void Ejecutar()
       {
            Coche coche = new Coche(0);
            coche.Conducir();

            Console.WriteLine("Ingrese la cantidad de gasolina a cargar");
            int cantCombustible = int.Parse(Console.ReadLine());

            coche.CargarCombustible(cantCombustible);
            coche.Conducir();


        }

    }
}
