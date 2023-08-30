using Practica2.Ej3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej4
{
    public static class Turno
    {
        public static void Atacarse(IList<Personaje> personajes)
        {
            foreach (Personaje p in personajes)
            {
                p.Atacar();
            }
        }

        public static void MoverFichas(IMoverse ficha)
        {
            ficha.MoverseEjeX();
            ficha.MoverseEjeY();
        }
    }
}
