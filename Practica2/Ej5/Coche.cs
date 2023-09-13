using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    public class Coche : IVehiculo
    {
        public int Gasolina { get; set; }
        public Coche(int gasolinaInicial) {
            Gasolina = gasolinaInicial;
        }

        public void Conducir()
        {
            if (Gasolina > 0) {
                Gasolina--;
                Console.WriteLine("El coche está conduciendo");
            }
            else
            {
                Console.WriteLine("El coche no tiene gasolina");
            }
        }

        public bool CargarCombustible(int cantidad)
        {
            if (Gasolina < 60)
            {
                if (Gasolina + cantidad > 60)
                {
                    Gasolina = 60;
                    Console.WriteLine("Se cargó hasta llenar el tanque, el resto no se cargó");
                    return true;
                }
                Console.WriteLine("Se cargó la cantidad pedida de combustible");
                Gasolina += cantidad;
                return true;
            }
            Console.WriteLine("El tanque ya está lleno. No se cargó combustible");
            return false;
        }
    }
}
