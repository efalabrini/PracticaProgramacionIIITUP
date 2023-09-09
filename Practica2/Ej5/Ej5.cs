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
            Coche coche = new Coche(0);
            coche.Conducir();

            Console.WriteLine("Cuantos Litros de Gasolina desea cargar: ");
            int carga = int.Parse(Console.ReadLine());
            coche.CargarCombustible(carga);
            coche.Conducir();
        }
    }
}
