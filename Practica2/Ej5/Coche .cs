using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    public class Coche : IVehiculo
    {
        private bool _Combustible; 
        public Coche(int combustible) 
        {
            _Combustible = Convert.ToBoolean(combustible);
        }

        public bool CargarCombustible(int cantidad)
        {
            if (cantidad > 0)
            {
                Console.WriteLine("Cargando gasolina ...");
                Console.WriteLine("Gasolina cargada con exito.");
                return _Combustible = true;
            }
            else
            {
                Console.WriteLine("La cantidad de gasolina a cargar debe ser mayor que 0.");
                return _Combustible = false;
            }
        }

        public void Conducir()
        {
            if( _Combustible == true) { Console.WriteLine("Estoy conduciendo"); }
            else { Console.WriteLine("El coche no tiene gasolina, Yendo a cargar"); }
            
        }
    }
}
