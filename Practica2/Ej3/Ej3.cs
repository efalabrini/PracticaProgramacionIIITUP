using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej3
{
    internal class Ej3
    {
        public void Ejecutar()
        {
            Persona p = new();
            p.Saludar();

            Estudiante e = new();
            e.SetEdad(20);
            e.Saludar();
            e.MostrarEdad();

            Profesor prof = new();
            prof.SetEdad(30);
            prof.Saludar();
            prof.Explicar();

        }
    }
}
