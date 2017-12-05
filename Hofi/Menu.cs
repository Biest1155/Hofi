using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hofi
{
    class Menu
    {
        bool running = true;
        string choice = "";
        Menu mainmenu { get; set; }
        public void MainMenu()
        {
        
           
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
            Console.Clear();
            Console.WriteLine("HØJBY FITNESS");
            Console.WriteLine();
            Console.WriteLine("1. Vis Vagter");
            Console.WriteLine();
            Console.WriteLine("0. Luk");
            choice = GetUserChoice();
            switch (choice)
            {
                case "1":
                    ShowWatches();
                    break;
            }
            
        }
        private void ShowWatches()
        {
            Console.Clear();
            Console.WriteLine("Implement this method");
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
            choice = GetUserChoice();
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
        private void AddInstructor()
        {
            Console.Clear();
            InstructorRepo I_Repo = new InstructorRepo();
            I_Repo.AddInstructorSQL();
        }
        private void DeleteInstructor()
        {
            Console.Clear();
            Console.WriteLine("Implement this method");

        }
        
        private void ChangeInstructor()
        {
            Console.Clear();
            Console.WriteLine("HØJBY FITNESS");
            Console.WriteLine();
            Console.WriteLine("1. Ændrer navn");
            Console.WriteLine("2. Ændrer mailadresse");
            Console.WriteLine("3. Ændrer telefonnummer");
            Console.WriteLine("4. Registrer vagt");
            Console.WriteLine();
            Console.WriteLine("0. Luk");
            choice = GetUserChoice();
            switch (choice)
            {
                case "1":
                    ChangeName();
                    break;
                case "2":
                    ChangeMailAdress();
                    break;
                case "3":
                    ChangePhonenumber();
                    break;
                case "4":
                    RegisterWatch();
                    break;
            }
           
        }

        private void ChangeName()
        {
            Console.Clear();
            Console.WriteLine("Implement this method33");
        }
        private void ChangeMailAdress()
        {
            Console.Clear();
            Console.WriteLine("Implement this method22");
        }
        private void ChangePhonenumber()
        {
            Console.Clear();
            Console.WriteLine("Implement this method11");
        }
        private void RegisterWatch() //4
        {
            Console.Clear();
            Console.WriteLine("HØJBY FITNESS");
            Console.WriteLine();
            Console.WriteLine("1. Fitness vagt");
            Console.WriteLine("2. Spinning vagt");
            Console.WriteLine();
            Console.WriteLine("0. Luk");
            choice = GetUserChoice();
            switch (choice)
            {
                case "1":
                    FitnessWatch();
                    break;
                case "2":
                    SpinningWatch();
                    break;

            }
            Console.ReadLine();
        }
        private void FitnessWatch()
        {
            Console.Clear();
            WatchRepo WatchRepo1 = new WatchRepo();
            WatchRepo1.RegisterFitnessWatch();
        }
        private void SpinningWatch()
        {
            Console.Clear();
            WatchRepo WatchRepo2 = new WatchRepo();
            WatchRepo2.RegisterSpinningWatch();
        }
        private void ShowMenuSelectionError()
        {
            Console.WriteLine("Fejl. Forkert valg");
            Console.ReadLine();
        }
    }
}
