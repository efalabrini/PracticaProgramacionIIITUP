using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej2
{
    public class Ej2
    {
        public void Ejecutar()
        {
            PhotoBook pb = new();
            Console.WriteLine($"Albún 1 {pb.GetNumberPages()}");
            pb = new PhotoBook(24);
            Console.WriteLine($"Albún 2 {pb.GetNumberPages()}");
            pb = new BigPhotoBook();
            Console.WriteLine($"Albún 3 {pb.GetNumberPages()}");

        }
    }
}
