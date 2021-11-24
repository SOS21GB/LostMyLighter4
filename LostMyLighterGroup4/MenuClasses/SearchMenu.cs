using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4.MenuClasses
{
    class SearchMenu
    {
        public void SearchAndPrintMenu()
        {
            while (true)
            {
                PrintSearchMenu();

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Marschall.FindStreet();
                        break;
                    case "2":
                        Marschall.FindPostCode();
                        break;
                    case "3":
                        Marschall.PrintActiveMarschalls();
                            break;
                    case "4":
                        Marschall.PrintAllMarschalls();
                        break;
                    case "0":
                        Console.WriteLine("Återgå till huvudmenyn.");
                        return;
                    default:
                        Console.WriteLine("Felaktig inmatning. Försök igen.");
                        break;
                }
            }
        }

        private void PrintSearchMenu()
        {
            PrintSeparator();
            Console.WriteLine("Sök eller visa.".PadLeft(19));
            Console.WriteLine("1) Sök på adress. ");
            Console.WriteLine("2) Sök på postnummer.");
            Console.WriteLine("3) Visa alla aktiva marschaller.");
            Console.WriteLine("4) Visa alla registerade marschaller.");
        }

        #region Hjälpmetod
        //Printar separatorer till menyn
        private void PrintSeparator()
        {
            Console.WriteLine("*--------------------------*");
        }
        #endregion


    }
}
