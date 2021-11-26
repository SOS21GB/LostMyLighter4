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
            //Input by user

            //Console.Write("ID no. : ");
            //int id = Convert.ToInt32(Console.ReadLine()); Id behöves inte, utan läggs till automatiskt - se konstruktorn i Marschall.
            Console.Write("Brand name: ");
            string brand = Console.ReadLine();
            Console.Write("Address: ");
            Address address = new Address(CreateAddress.AddStreet(), CreateAddress.AddPostCode(), CreateAddress.AddPostTown());
            Console.Write("Användare: ");
            string registeringUser = Console.ReadLine();
            Console.Write("Hours of expected burn time: ");
            double burntime = Convert.ToDouble(Console.ReadLine());

            new Marschall(brand, address, registeringUser, burntime);

            

            Console.WriteLine();
        }

        
    }

}


