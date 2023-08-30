using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej4
{
    public class Ej4
    {
        public void Ejecutar()
        {
            List<Personaje> list = new List<Personaje>();
            list.Add(new PersonajeDeAgilidad("Spiderman",7,10,2));
            list.Add(new PersonajeDeFuerza("Rambo",10,10));
            list.Add(new PersonajeDeMagia("Mago",2,10));

            Enemigo e = new();

            Turno.Atacarse(list);
            Turno.MoverFichas(e);
            Turno.MoverFichas(list[2]);

        }
    }
}
