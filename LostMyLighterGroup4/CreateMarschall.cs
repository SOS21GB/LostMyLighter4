using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4
{
    public class CreateMarschall
    {
        public static void CreateMarschalls()
        {

            {   //Input by user

                Console.Write("ID no. : ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Brand name: ");
                string brand = Console.ReadLine();
                Console.Write("Address: ");
                string address = Console.ReadLine();
                Console.Write("Name of user: ");
                string registeringUser = Console.ReadLine();
                Console.Write("Hours of expected burn time: ");
                double burntime = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                new Marschall(id, brand, Address, registeringUser, burntime);

                Marschall.PrintInfo();

            }

        }

    }
     
    }
 

