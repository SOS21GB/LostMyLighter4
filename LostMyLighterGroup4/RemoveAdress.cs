using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4
{
    class ChangeStreet
    {

        public static void ÄndraGata(int id)
        {
            

            string street = "";
            Console.WriteLine("Skriv in din nya gata: ");

            street = Console.ReadLine();

            Console.WriteLine("Din nya gata är: {0}", street);

            User.GetUserById(id).Address = street;


        }
        
    }
}
