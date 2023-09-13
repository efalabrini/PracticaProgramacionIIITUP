using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TodaPractica.Practica2.Ej5
{
   
    public class Coche : IVehiculo
    {
        public int gasolina;
        public Coche(int CombustibleInicial)
        {
            gasolina = CombustibleInicial;
        }

        public bool CargarCombustible(int CantCombustible)
        {


            if (CantCombustible > 0) 
            {
                gasolina =+ CantCombustible;
                Console.WriteLine($"se cargo  {CantCombustible}de nafta. El tanque tiene {gasolina}");
                return true;
            }else
            {
                Console.WriteLine("no se cargo");
                return false;
            }
        }

        public void Conducir()
        {
            if (gasolina > 0)
            {
                Console.WriteLine("El Coche esta Conduciendo");
            }
            else 
            {
                Console.WriteLine("No tiene Nafta");
            }
        }
    }
}
