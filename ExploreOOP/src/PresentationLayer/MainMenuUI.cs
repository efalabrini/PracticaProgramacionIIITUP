using BusinessLayer.Services;
using ExploreOOP.src.BusinessLayer.Entities;
using PersistenceLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreOOP.src.PresentationLayer
{
    public static class MainMenuUI
    {
        public static void Display()
        {
            LineOfCreditAccountService lineOfCreditAccountService = new(new LineOfCreditAccountRepositoryMoked());

            int option;
            do
            {
                PrintMenu();
                Console.WriteLine("Select an option:");
                int.TryParse(Console.ReadLine(),out option);

                switch (option)
                {
                    case 0:
                        Environment.Exit(0);
                        break;


                    case 1:
                        Console.Clear();
                        
                        var lista = lineOfCreditAccountService.GetAll();

                        foreach (var item in lista)
                        {
                            Console.WriteLine($"Account ID: {item.Number} {item.Owner} Balance {item.Balance}" );
                        }

                        PrintPressToContinue();
                        break;

                    case 2:
                        decimal creditLimit;
                        Console.Write("Enter account name: ");
                        var name = Console.ReadLine() ?? "";

                        Console.Write("Enter credit limit: ");
                        decimal.TryParse(Console.ReadLine(), out creditLimit);

                        LineOfCreditAccount l = new(name, 0, creditLimit);
                        lineOfCreditAccountService.Add(l);


                        break;

                    case 3:
                        Console.WriteLine("Ingrese el numero de cuenta a buscar");
                        var id = Console.ReadLine() ?? "";
                        var List2 = lineOfCreditAccountService.GetAll();
                        var cuentaBuscar = List2.FirstOrDefault(x => x.Number == id);

                        if(cuentaBuscar != null)
                        {
                            Console.WriteLine("Se ha encontrado la cuenta!");
                            Console.WriteLine($"Owner: {cuentaBuscar.Owner}");
                            Console.WriteLine($"Account ID: {cuentaBuscar.Number}");
                            Console.WriteLine($"Balance: {cuentaBuscar.Balance}");
                            
                        }
                        else
                        {
                            Console.WriteLine("No se ha encontrado la cuenta");
                        }
                       PrintPressToContinue();
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el número de cuenta a eliminar");
                        string numeroEliminar = Console.ReadLine() ?? "";

                        var List3 = lineOfCreditAccountService.GetAll();
                        var cuentaEliminar = List3.FirstOrDefault(x => x.Number == numeroEliminar);

                        if (cuentaEliminar != null)
                        {
                            Console.WriteLine($"Se ha eliminado la cuenta {cuentaEliminar.Number}");
                            int idToDelete = int.Parse(cuentaEliminar.Number);
                            lineOfCreditAccountService.Delete(idToDelete);
                        }
                        else
                        {
                            Console.WriteLine("Cuenta no encontrada");
                        }
                        PrintPressToContinue();
                        break;
                }

            } while (option != 0);

            

        }

        private static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Main menu");
            Console.WriteLine("---------");
            Console.WriteLine();
            Console.WriteLine("     1 - List all Line of credit accounts");
            Console.WriteLine("");
            Console.WriteLine("     2 - Add a Line of credit account");
            Console.WriteLine("");
            Console.WriteLine("     3 - Search a Line of credit account");
            Console.WriteLine("");
            Console.WriteLine("     4 - Delete a Line of credit account");
            Console.WriteLine("");
            Console.WriteLine("     0 - Exit program");
            Console.WriteLine("");

        }

        private static void PrintPressToContinue()
        {
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

    }
}
