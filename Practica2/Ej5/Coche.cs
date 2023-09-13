using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    public class Coche: IVehiculo
    {
        private int gasoil;

        public Coche(int gasoilInicial)
        {
            gasoil = gasoilInicial;
        }

        public void Conducir()
        {
            if (gasoil > 0)
            {
                Console.WriteLine("El coche está conduciendo.");
            }
            else
            {
                Console.WriteLine("No hay suficiente gasolina para conducir.");
            }
        }

        public bool Cargar(int cantidad)
        {
            if (cantidad > 0)
            {
                gasoil += cantidad;
                Console.WriteLine($"Se han cargado {cantidad} unidades de gasolina.");
                return true;
            }
            else
            {
                Console.WriteLine("La cantidad de combustible a cargar debe ser mayor que 0.");
                return false;
            }
        }

        public bool CargarCombustible(int cantidad)
        {
            throw new NotImplementedException();
        }
    }
}
