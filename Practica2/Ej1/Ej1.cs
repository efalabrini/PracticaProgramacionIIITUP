using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej1
{
    public class Ej1
    {
        const int _cantIteraciones = 3;
        
        public void Ejecutar()
        {

            List<Persona> lista = new();
            string nombre;
            for (int i = 1; i <= _cantIteraciones; i++)
            {
                Console.Write($"Ingrese el nombre de la persona número {i}: ");
                nombre = Console.ReadLine() ?? "";
                Persona persona = new(nombre);
                lista.Add(persona);

            }

            foreach (Persona persona in lista)
            {
                Console.WriteLine(persona.GetSaludo()) ;
            }

        }


    }
}
