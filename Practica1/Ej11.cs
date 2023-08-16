using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    //Extra
    //Leer un archivo con formato Legajo, Alumno
    //Donde Alumno = "Apellido, Nombre completo (email)"
    //y transformarlo en un archivo con formato Legajo, Nombre, Apellido, Email.
    public class Ej11 : IEjercicio
    {
        public void Ejecutar()
        {
            List<Alumno> listA = new List<Alumno>();
            
            using (var reader = new StreamReader(@"PathInputFile.csv", Encoding.Latin1))
            {
               
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    string legajo = values[0].Trim();
                    string apellido = values[1].Replace("\"","").Trim();

                    var values2 = values[2].Split("(");

                    string nombre = values2[0].Trim();
                    
                    string email = values2[1].Replace(")","").Replace("\"","").Trim();

                    Alumno alumno = new(legajo,nombre,apellido,email);
                    listA.Add(alumno);


                    
                }
            }
            var csv = new StringBuilder();
            foreach (Alumno a in listA)
            {
                string newLine = $"{a.Legajo},{a.Nombre},{a.Apellido},{a.Email}";
                csv.AppendLine(newLine);
            }
            File.WriteAllText(@"PathOutputFile.csv", csv.ToString());
        }
    }

    public record Alumno(string Legajo,string Nombre, string Apellido, string Email);
}
