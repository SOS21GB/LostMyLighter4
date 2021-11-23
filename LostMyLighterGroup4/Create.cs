using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4
{
class Create
    {
     public static void UserCreate()
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