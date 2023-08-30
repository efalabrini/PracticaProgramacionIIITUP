//La idea de este proyecto es mostrar como agregar un paquete desde NuGet y utilizarlo.

// See https://aka.ms/new-console-template for more information
using NugetExample;
using QRCoder;
using System.Diagnostics;
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {

            Console.Write("Ingrese el texto a codificar: ");
            string textToCode = Console.ReadLine() ?? "";

            Console.WriteLine("Ingrese path y nombre de archivo a escribir (ej: c:\\unacarpeta\\myqr.png): ");
            string pathToWrite = Console.ReadLine() ?? "";

            var qrWriter = new QRWriter();
            
            qrWriter.WriteQrToFile(textToCode, pathToWrite);

            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = pathToWrite;
            startinfo.CreateNoWindow = true;
            startinfo.UseShellExecute = true;
            Process myProcess = Process.Start(startinfo);
           
        }
        catch (Exception ex)
        {
            Console.WriteLine();
            Console.WriteLine(ex.Message);
        }
    }
}

//QRCodeGenerator qrCode = new QRCodeGenerator();
//var  qrCodeImage = qrCode.GetGraphic(20, Color.Black, Color.White, (Bitmap)Bitmap.FromFile("C:\\myimage.png"));