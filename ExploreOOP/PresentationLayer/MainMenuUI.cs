using ExploreOOP.BusinessLayer.Services;
using ExploreOOP.BusinessLayer.Entities;
using ExploreOOP.PersistenceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreOOP.PresentationLayer
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
