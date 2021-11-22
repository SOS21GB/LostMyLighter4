using System;
using LostMyLighterGroup4.MenuClasses;
using System.Collections.Generic;

namespace LostMyLighterGroup4
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine(User);
            Console.WriteLine("Vill du ta bort användaren?");
            Console.WriteLine("1/ Ja" );
            Console.WriteLine("2/ Nej");
            int x = Convert.ToInt32(Console.ReadLine());

            switch(x)
            {
                case 1:

                   // User.Clear();
                   // Console.WriteLine(User);
                    Console.WriteLine("Nu är användaren borttagen");

                    break;

                default:

                    Console.WriteLine("användaren är kvar");

                    break;


            }
                LogIn.CheckUser(users);

        }
    }
}
