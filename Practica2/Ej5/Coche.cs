using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej5
{
    public class Coche : IVehiculo
    {
        public int CantCombustible { get; set; }
        public Coche(int cantCombustible)
        {
            CantCombustible = cantCombustible;
        }

        public void Conducir()
        {
            if (CantCombustible > 0)
            {
                Console.WriteLine("El Coche esta Conduciendo.");
            }
            else {
                Console.WriteLine("Llename el tanke padre");
            }
        }
        public bool CargarCombustible(int SumaCombustible)
        {
            CantCombustible = CantCombustible + SumaCombustible;
            return true;
        }

    }
}
    