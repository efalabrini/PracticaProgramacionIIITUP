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
            Coche miCoche = new Coche(0);
            miCoche.Conducir();
            miCoche.CargarCombustible(45);
            miCoche.Conducir();
        }
    }
}
