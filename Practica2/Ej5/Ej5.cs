using Practica2.Ej3;
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
            
            Coche miCoche = new Coche(0);


            Console.Write("Ingrese una cantidad de combustible para cargar: ");
            int combustible = int.Parse(Console.ReadLine()); 

            miCoche.CargarCombustible(combustible);

            miCoche.Conducir();

        }
    }
}