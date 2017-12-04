using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hofi
{
    class Menu
    {
        Menu mainmenu { get; set; }
        public void MainMenu()
        {
            bool running = true;
            string choice = "";
            do
            {
                ShowMenu();
                choice = GetUserChoice();
                switch (choice)
                {
                    case "1": DoActionFor1(); break;
                    case "2": DoActionFor2(); break;
                    case "0": running = false; break;
                    default: ShowMenuSelectionError(); break;
                }
            } while (running);
        }
        private void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.WriteLine("HØJBY FITNESS");
            Console.WriteLine();
            Console.WriteLine("1. Vagter");
            Console.WriteLine("2. Instruktører");
            Console.WriteLine();
            Console.WriteLine("0. Luk");
        }
        private string GetUserChoice()
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }
        private void DoActionFor1()
        {
            
        }

        private void DoActionFor2()
        {
            
        }
        private void ShowMenuSelectionError()
        {
            Console.WriteLine("Fejl. Forkert valg");
            Console.ReadLine();
        }
    }
}
