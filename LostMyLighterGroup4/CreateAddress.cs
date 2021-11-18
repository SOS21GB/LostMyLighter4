using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4
{
    public static class CreateAddress
    {
        // Inmatningskontroll etc kommer läggas till.
        public static string AddStreet(string userInput)
        {
            Console.Write("Gatuadress: ");
            string street = userInput;
            return street;
        }

        public static int AddPostCode(int userInput)
        {
            Console.Write("Postnummer: ");
            int pCode = userInput;
            return pCode;
        }

        public static string AddPostTown(string userInput)  
        {
            Console.Write("Postort: ");
            string pTown = userInput;
            return pTown;
        }

    }
}