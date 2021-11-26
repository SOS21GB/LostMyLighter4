using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4.MenuClasses
{
    class StandardMenu
    {

        //Huvudmenyloop, returnerar int beroende på input
        public int MainMenu()
        {
            while (true)
            {
                //Console.Clear();
                PrintMainMenu();
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                        return int.Parse(userInput);
                    case "0":
                        Console.WriteLine("Avslutar programmet. Hejdå.");
                        return 0;
                    default:
                        Console.WriteLine("Felaktig inmatning. Försök igen!");
                        SearchMenu.UserKeyPressToContinue();
                        Console.Clear();
                        break;
                }
            }
        }

        //Skriver ut huvudmenyn
        private void PrintMainMenu()
        {
            PrintSeparator();
            Console.WriteLine("Huvudmeny".PadLeft(18));
            Console.WriteLine("1) Visa\\Sök marschaller.");
            Console.WriteLine("2) Registrera marschall.");
            Console.WriteLine();
            PrintShortSeparator();
            Console.WriteLine("3) Logga in.");
            Console.WriteLine("4) Skapa användare.");
            PrintShortSeparator();
            Console.WriteLine();
            Console.WriteLine("0) Avsluta programmet.");
            PrintSeparator();
            Console.Write("Ditt val: ");
        }


        #region Hjälpmetoder
        //Printar separatorer till menyn
        private void PrintShortSeparator()
        {
            Console.WriteLine("*----------------*".PadLeft(22));
        }
        private void PrintSeparator()
        {
            Console.WriteLine("*--------------------------*");
        }
        #endregion
    }
}
