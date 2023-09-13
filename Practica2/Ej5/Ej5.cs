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
            //Coche con 0 litro de gasolina inicial
            Coche miCoche = new Coche(0);

            Console.Write("Ingrese la cantidad de combustible a cargar: ");
            int cantidadACargar = int.Parse(Console.ReadLine());

            if (miCoche.CargarCombustible(cantidadACargar))
            {
                miCoche.Conducir();
            }
        }
    }
}
