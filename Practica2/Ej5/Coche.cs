using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    public class Coche : IVehiculo
    {

        public int cantidadcombustible { get;  set; }

        public  Coche(int CantidadCombustible)
        {
            cantidadcombustible = CantidadCombustible;
        }
        public void Conducir() 
        {
            if (cantidadcombustible > 0) 
            { 
                Console.WriteLine("El coche se esta conduciendo!"); 
            }
            else 
            {
                Console.WriteLine("¡No hay nafta, llename el tanque!"); 
            }
        }

        public bool CargarCombustible(int sumaNafta) 
        {
            cantidadcombustible += sumaNafta;
            return true;
        }
    }
}
