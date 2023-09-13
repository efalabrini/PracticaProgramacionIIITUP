using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodaPractica.Practica2.Ej5
{
    public class Ej5
    {   
        public void Ejecutar()
        {
            Coche Auto1 = new Coche(0);
            Auto1.Conducir();
            Console.WriteLine("Ingrese la cantidad de combustible que desea cargar: ");
            int Carga = int.Parse(Console.ReadLine());

            Auto1.CargarCombustible(Carga);
            Auto1.Conducir();

        }
    }
}
