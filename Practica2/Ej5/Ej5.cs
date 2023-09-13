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
            Coche corsa = new Coche(0);
            corsa.Conducir();
            corsa.CargarCombustible(30);
            corsa.Conducir();
            corsa.CargarCombustible(50);
            corsa.CargarCombustible(10);
        }
    }
}
