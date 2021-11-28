using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4.MenuClasses
{
    class LoggedInMenu
    {
        //Huvudmenyloop, returnerar int beroende på input
        public int UserMenu(User userName)
        {
            while (true)
            {
                Console.WriteLine("Inloggat ID: {0}\n", userName.ID);
                Console.WriteLine("Välkommen, {0}!".PadLeft(20), userName.Name);
                PrintMenu();
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                        return int.Parse(userInput);
                    case "0":
                        Console.WriteLine("\nAvslutar programmet. Hejdå {0}!",userName.Name);
                        return 0;
                    default:
                        Console.Clear();
                        Console.WriteLine("Felaktig inmatning. Försök igen!");
                        SearchMenu.UserKeyPressToContinue();
                        break;
                }
            }
        }

        //Skriver ut huvudmenyn
        private void PrintMenu()
        {
            PrintSeparator();
            Console.WriteLine();
            Console.WriteLine("Huvudmeny".PadLeft(19));
            PrintShortSeparator();
            Console.WriteLine("1) Visa eller sök marschaller.");
            Console.WriteLine("2) Registrera marschall.");
            Console.WriteLine("3) Registrera borttappad tändare.");
            PrintShortSeparator();
            Console.WriteLine("\n4) Visa profil.");
            Console.WriteLine("5) Redigera profil.");
            Console.WriteLine("6) Logga ut");
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
