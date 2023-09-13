﻿using BusinessLayer.Services;
using ExploreOOP.src.BusinessLayer.Entities;
using PersistenceLayer;
using System;
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
                            Console.WriteLine($"Account ID: {item.Number} Account {item.Owner} Balance {item.Balance}" );
                        }

                        PrintPressToContinue();
                        break;

                    case 2:
                        decimal creditLimit;
                        Console.Write("Enter account name: ");
                        var name = Console.ReadLine() ?? "";

                        Console.Write("Enter credit limit: ");
                        decimal.TryParse(Console.ReadLine(), out creditLimit);

                        LineOfCreditAccount l = new(name, 0, creditLimit,null);
                        lineOfCreditAccountService.Add(l);

                        Console.WriteLine($"Account added" );
                        PrintPressToContinue();

                        break;
                    
                    case 3:
                        Console.Write("Enter account id: ");
                        var id = int.Parse(Console.ReadLine() ?? "0");

                        l = lineOfCreditAccountService.Get(id);

                        Console.WriteLine($"Account ID: {l.Number} Account {l.Owner} Balance {l.Balance}" );
                        PrintPressToContinue();
                        break;

                    case 4:
                        Console.Write("Enter account id: ");
                        id = int.Parse(Console.ReadLine() ?? "0");

                        lineOfCreditAccountService.Delete(id);

                        Console.WriteLine($"Account {id} deleted" );
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
            Console.WriteLine("     3 - Find a line of credit account by ID");
            Console.WriteLine("");
            Console.WriteLine("     4 - Delete a line of credit account");
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
