using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej4
{
    public abstract class Personaje : IMoverse
    {
        public string? Nombre { get; set; }

        public int Fuerza { get; set; }

        public int Agilidad { get; set; }

        public int Magia { get; set; }

        public abstract double CalcularDanio();

        public virtual void Atacar()
        {
            Console.WriteLine($"{Nombre} hizo {CalcularDanio()} de daño");
        }

        public void MoverseEjeX()
        {
            Console.WriteLine($"{Nombre} se movió en el eje X");
        }

        public void MoverseEjeY()
        {
            Console.WriteLine($"{Nombre} se movió en le eje Y");
        }
    }
}
