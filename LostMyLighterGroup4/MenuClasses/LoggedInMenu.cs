﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4.MenuClasses
{
    class LoggedInMenu
    {
        //Huvudmenyloop, returnerar int beroende på input
        public int UserMenu(string userName)
        {
            while (true)
            {
                //Console.Clear();
                Console.WriteLine("Hej {0}", userName);
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
                    case "7":
                    case "8":
                    case "9":
                        return int.Parse(userInput);
                    case "0":
                        Console.WriteLine("Avslutar programmet. Hejdå.");
                        return 0;
                    default:
                        Console.WriteLine("Felaktig inmatning. Försök igen!");
                        break;
                }
            }
        }

        //Skriver ut huvudmenyn
        private void PrintMenu()
        {
            PrintSeparator();
            Console.WriteLine("Användarmeny".PadLeft(19));
            Console.WriteLine("1) Visa aktiva marschaller.");
            Console.WriteLine("2) Registrera marschall.");
            PrintShortSeparator();
            Console.WriteLine("3) Sök marschall.");
            Console.WriteLine("4) Registrera marschall.");
            Console.WriteLine("5) Anmäl borttappad tändare.");
            PrintShortSeparator();
            Console.WriteLine("6) Visa profil.");
            PrintShortSeparator();
            Console.WriteLine("Inställningar".PadLeft(19));
            Console.WriteLine("7) Byt namn.");
            Console.WriteLine("8) Ändra ålder.");
            Console.WriteLine("9) Ändra adress.");
            PrintShortSeparator();
            Console.WriteLine();
            Console.WriteLine("0) Avsluta programmet.");
            PrintSeparator();
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