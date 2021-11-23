using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4
{
    // Sökfunktionen måste ta hänsyn till hur adressen lagras. Kanske bättre att formattera på annat ställe?
    // Skriva i menyn att det går att lämna postnummerfältet tomt. Går ej på de andra fälten.

    public static class CreateAddress   
    {
       public static string AddStreet() // Ej klar.
        {
            Console.Write("Gatuadress: ");

            string street = Console.ReadLine();

            street = street.ToLower().Trim();

            return street;
        }

        public static string AddPostCode()
        {
            Console.Write("Postnummer: ");

            List<char> postCodeList = new List<char>();// Lista för att kunna justera inmatningen.

            bool loop = true;

            while (loop)
            {
                postCodeList.Clear(); // Nollställ så att loopen inte lägger till element.

                int j = 0;

                string postCode = Console.ReadLine();

                postCodeList.AddRange(postCode);

                if (!string.IsNullOrWhiteSpace(postCode))// Möjliggör att postnummerfältet lämnas tomt. ELLER GÖRA TVÄRT OM, DVS SOM PÅ DE ANDRA?
                {
                    for (int i = postCodeList.Count - 1; i >= 0; i--)// Tar bort ev. mellanslag.
                    {
                        if (postCodeList[i] == ' ') 
                        {
                            postCodeList.Remove(postCodeList[i]);
                        }
                    }

                    foreach (char item in postCodeList)// Kollar om något annat än tal angivits eller om listan innehåller fler siffror än tillåtet.
                    {
                        if (!Char.IsDigit(item) || postCodeList.Count > 5)// Kan sättas till != 5 om inga inkompletta inmatningar tillåts.
                        {
                            Console.Write("Felaktig inmatning. Försök igen: ");

                            break;
                        }

                        if (j == postCodeList.Count - 1)// Bryter loopen vid korrekt inmatning.
                        {
                            loop = false;
                        }

                        j++;
                    }
                }
                else// Om inget postnummer angivits.
                {
                    Console.WriteLine("Ingen uppgift.");

                    loop = false;
                }
            }

            string pCode = new string(postCodeList.ToArray());// Listan tillbaka till string.

            return pCode;
        }
        
        public static string AddPostTown() // Ej klar.
        {
            Console.Write("Postort: ");

            string pTown = Console.ReadLine();

            pTown = pTown.ToLower().Trim();

            return pTown;
        }
    }
}