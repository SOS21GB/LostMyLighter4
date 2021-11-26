﻿using System;
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
                        Console.Clear();
                        // Metod
                        SearchMenu.UserKeyPressToContinue();
                        break;
                    case "2":
                        Console.Clear();
                        // Metod
                        SearchMenu.UserKeyPressToContinue();
                        break;
                    case "3":
                        Console.Clear();
                        // Metod
                        SearchMenu.UserKeyPressToContinue();
                        break;
                    case "4":
                        Console.Clear();
                        // Metod
                        SearchMenu.UserKeyPressToContinue();
                        //break; Return låg här sedan tidigare.
                        return int.Parse(userInput);
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Avslutar programmet. Hejdå.");
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
