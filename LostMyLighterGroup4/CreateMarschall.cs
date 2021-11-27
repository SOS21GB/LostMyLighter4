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
            Console.WriteLine("Registrera marschall.");

            Console.Write("\nMärke: ");
            string brand = Console.ReadLine();

            Console.Write("\nAddress: ");
            Address address = new Address(CreateAddress.AddStreet(), CreateAddress.AddPostCode(), CreateAddress.AddPostTown());

            Console.Write("\nDitt namn: ");
            string registeringUser = Console.ReadLine();

            Console.Write("\nFörväntad brinntid: ");

            double burntime = 0;
            bool loop = true;

            while (loop)
            {
                if (double.TryParse(Console.ReadLine(), out burntime))
                {
                    loop = false;
                }
                else
                {
                    Console.Write("\nFelaktig inmatning. Försök igen: ");
                }
            }

            Marschall marshall = new Marschall(brand, address, registeringUser, burntime);

            Console.WriteLine("\nMarschall registrerad.");

            MenuClasses.SearchMenu.UserKeyPressToContinue();
        }
    }
}


