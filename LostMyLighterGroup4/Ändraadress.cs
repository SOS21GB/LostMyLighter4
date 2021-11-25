using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4
{
    class Ändraadress
    {
        public static void ÄndraGata()
        {
            Console.WriteLine("Är du säker att du vill ändra din adress?: ");
            Console.WriteLine("1/ ja");
            Console.WriteLine("2/ nej");
            int x = Convert.ToInt32(Console.ReadLine());
            
            if (x == 1)
            {
                Console.WriteLine("Skriv in din nya andress. men lämna nummer mm till nästa steg: ");
                string street = Console.ReadLine();

                Console.Write("\nNummer: ");
                string streetNumber = Console.ReadLine();

                Console.Write("\nBokstav: ");
                string streetLetter = Console.ReadLine();

                string streetAddress = street + " " + streetNumber + " " + streetLetter;

                Console.WriteLine("Din nya adress är: {0}", streetAddress);
            }
            else
            {
                Console.WriteLine("Du har kvar din gamla adress");
            }



        }
       

    }







}
