using System;
using LostMyLighterGroup4.MenuClasses;
using System.Collections.Generic;

namespace LostMyLighterGroup4
{   
    class Program
    {
        public static void User()
        {
            Console.WriteLine("skriv ditt namn: ");
            try
            {
                string n = Console.ReadLine();
               
            }
            catch
            {
                Console.WriteLine("Error try again");
            }

            Console.WriteLine("skriv ditt Id: ");
            try
            {

                int i = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error try again");
            }

            Console.WriteLine("skriv din ålder: ");
            try
            {

                int å = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error try again");
            }

            Console.WriteLine("skriv din adress: ");
            try
            {

                string a = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Error try again");
            }
        }
    }
}
