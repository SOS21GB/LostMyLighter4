using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4.MenuClasses
{
    class SearchMenu
    {
        public void SearchAndPrintMenu(User activeUser)
        {
            Console.Clear();
            while (true)
            {
                Console.Clear();
                PrintSearchMenu();

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Marschall.FindStreet();
                        User.AddSearch(activeUser);
                        UserKeyPressToContinue();
                        break;
                    case "2":
                        Console.Clear();
                        Marschall.FindPostCode();
                        User.AddSearch(activeUser);
                        UserKeyPressToContinue();
                        break;
                    case "3":
                        Console.Clear();
                        Marschall.PrintActiveMarschalls();
                        User.AddSearch(activeUser);
                        UserKeyPressToContinue();
                        break;
                    case "4":
                        Console.Clear();
                        Marschall.PrintAllMarschalls();
                        User.AddSearch(activeUser);
                        UserKeyPressToContinue();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Felaktig inmatning. Försök igen.");
                        UserKeyPressToContinue();
                        Console.Clear();
                        break;
                }
            }
        }

        private void PrintSearchMenu()
        {
            PrintSeparator2();
            Console.WriteLine("Hitta marschaller.".PadLeft(30));
            PrintShortSeparator2();
            Console.WriteLine("1) Sök efter marschall baserat på adress.");
            Console.WriteLine("2) Sök efter marschall baserat på postnummer.");
            PrintShortSeparator2();
            Console.WriteLine("3) Visa alla aktiva marschaller.");
            Console.WriteLine("4) Visa alla registerade marschaller.");
            PrintShortSeparator2();
            Console.WriteLine("0) Återgå till huvudmenyn.");
            PrintSeparator2();
            Console.Write("Ditt val: ");
        }

        #region Hjälpmetoder
        //Printar separatorer till menyn
        private void PrintShortSeparator2()
        {
            Console.WriteLine("*----------------*".PadLeft(30));
        }
        private void PrintSeparator2()
        {
            Console.WriteLine("*--------------------------------------------*");
        }
        public static void UserKeyPressToContinue() 
        {
            Console.WriteLine("\nTryck på valfri tangent för att fortsätta.");
            Console.ReadKey();
        }



        #endregion


    }
}
