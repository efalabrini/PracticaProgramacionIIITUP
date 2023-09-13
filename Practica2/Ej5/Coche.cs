using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    public class Coche : IVehiculo
    {
        int gasolina;
        public Coche(int gasolinaInicial)
        {
            gasolina = gasolinaInicial;
        }

        public void Conducir()
        {
            if (gasolina > 0)
            {
                Console.WriteLine("El coche está conduciendo");
            }
            else { Console.WriteLine("El coche no tiene gasolina"); }
        }

        public bool CargarCombustible(int cant_combustible)
        {
            if (cant_combustible > 0)
            {
                gasolina += cant_combustible;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
