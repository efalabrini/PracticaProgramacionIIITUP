using Practica2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Coche : IVehiculo
{
    private int gasolina;

    public Coche(int gasolinaInicial)
    {
        this.gasolina = gasolinaInicial;
    }

    public void Conducir()
    {
        if (this.gasolina > 0)
        {
            Console.WriteLine("El coche está conduciendo");
            this.gasolina--;
        }
        else
        {
            Console.WriteLine("No hay suficiente gasolina para conducir");
        }
    }

    public bool CargarCombustible(int cantidad)
    {
        this.gasolina += cantidad;
        return true;
    }
}
