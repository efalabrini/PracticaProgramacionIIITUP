namespace Practica2.Ej5;

public class Ej5
{
    public void Ejecutar(){
        Coche coche = new Coche(0);
        Console.WriteLine("Ingrese la cantidad de combustible que desea cargar");
        int combustible = Convert.ToInt32(Console.ReadLine());
        coche.CargarCombustible(combustible);
        coche.Conducir();
    }
}
