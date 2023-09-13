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
            Coche miCoche = new Coche();

            Console.Write("Ingrese la cantidad de gasolina a cargar: ");
            int cantidadGasolina = int.Parse(Console.ReadLine());

            bool cargaExitosa = miCoche.CargarCombustible(cantidadGasolina);

            if (cargaExitosa)
            {
                miCoche.Conducir();
            }
        }
    }
}
