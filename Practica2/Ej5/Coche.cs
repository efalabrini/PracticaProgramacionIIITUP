using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    public class Coche : IVehiculo
    {
        private int Gasolina { get; set; }

        public Coche(int gasolina)
        {
            Gasolina = gasolina;
        }

        public void Conducir()
        {
            if (Gasolina > 0)
            {
                Console.WriteLine("Conduciendo");
            }
            else
            {
                Console.WriteLine("Necesita combusitble para manejar el coche");
            }
        }

        public bool CargarCombustible(int cantidad)
        {
            bool band = false;

            do
            {
                if (cantidad > 0)
                {
                    Gasolina += cantidad;
                    Console.WriteLine($"Se han cargado {cantidad} unidades de gasolina.");
                    return band == true;
                }
                else
                {
                    Console.WriteLine("La cantidad de combustible a cargar debe ser mayor que 0.");
                    return band == false;
                }

            } while (cantidad < 0 && band == false);
        }
    }
}
