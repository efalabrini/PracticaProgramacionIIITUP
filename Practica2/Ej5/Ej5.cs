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
            Console.WriteLine("Cuanta nafta tenes?");
            int NaftaInicial = int.Parse(Console.ReadLine());
            Coche FordKa = new(NaftaInicial);
            Console.WriteLine(FordKa.cantidadcombustible);
            FordKa.Conducir();

            Console.WriteLine("Cuanta Nafta vas a cargar?");
            int CantNafta = int.Parse(Console.ReadLine());

            Console.WriteLine(FordKa.CargarCombustible(CantNafta));
            Console.WriteLine($"Cantidad total de nafta: {FordKa.cantidadcombustible}");
        }
    }
}
