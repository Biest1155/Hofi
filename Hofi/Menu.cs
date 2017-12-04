using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hofi
{
    class Menu
    {
         string choice = "";
        Menu mainmenu { get; set; }
        public void MainMenu()
        {
            bool running = true;
          
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
            Console.Clear();
            Console.WriteLine("HØJBY FITNESS");
            Console.WriteLine();
            Console.WriteLine("1. Tilføj ny instruktør");
            Console.WriteLine("2. Ændre en instruktør");
            Console.WriteLine("3. Slet en instruktør");
            Console.WriteLine();
            Console.WriteLine("0. Luk");
            Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddInstructor();
                    break;
                case "2":
                    ChangeInstructor();
                    break;
                case "3":
                    DeleteInstructor();
                    break;
            }
            Console.ReadLine();
        }

        private void DeleteInstructor()
        {
            Console.Clear();
            Console.WriteLine("Implement this method33");
        }

        private void AddInstructor()
        {
            Console.Clear();
            Console.WriteLine("Implement this method11");
        }

        private void ChangeInstructor()
        {
            Console.Clear();
            Console.WriteLine("Implement this method22");

        }

        private void ShowMenuSelectionError()
        {
            Console.WriteLine("Fejl. Forkert valg");
            Console.ReadLine();
        }
    }
}
