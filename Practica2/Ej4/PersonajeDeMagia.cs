using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej4
{
    internal class PersonajeDeMagia : Personaje
    {
        public override double CalcularDanio()
        {
            double danio = 0;
            danio = Fuerza + Agilidad + Magia * 4;
            return danio;
        }

        public PersonajeDeMagia(string nombre, int fuerza, int agilidad, int magia)
        {
            Nombre = nombre;
            Fuerza = fuerza;
            Agilidad = agilidad;
            Magia = magia;
        }

        public PersonajeDeMagia(string nombre, int fuerza, int agilidad) : this (nombre, fuerza, agilidad, 60)
        {
            
        }

        public override void Atacar()
        {
            Console.WriteLine($"{Nombre} hizo {CalcularDanio()} gracias a su magia");
        }

    }
}
