using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4
{
    public static class CreateAddress
    {
        public static string AddStreet()
        {
            Console.WriteLine("\nLägg till gatuadress. Raderna för nummer och bokstav kan lämnas tomma.");

            string street = "";

            bool loop = true;

            while (loop) // Ser till att raden inte är tom.
            {
                Console.Write("\nGata: ");

                street = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(street))
                {
                    Console.Write("Ingen uppgift. Försök igen: ");
                }
                else
                {
                    loop = false;
                }
            }

            string streetNumber = "";
            while (true)
            {
                Console.Write("\nNummer: ");
                string tempStr = Console.ReadLine();
                if (int.TryParse(tempStr, out int streetNo))
                {
                    streetNumber = streetNo.ToString();
                    break;
                }
                else if (tempStr == "")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning.");
                }
            }

            string streetLetter = "";

            while (true)
            {
                Console.Write("\nBokstav: ");
                string tempStr = Console.ReadLine();
                if (!tempStr.All(char.IsDigit) && tempStr.Length == 1)
                {
                    streetLetter = tempStr;
                    break;
                }
                else if (tempStr == "")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning.");
                }
            }

            street = street.ToLower().Trim();

            streetNumber = streetNumber.ToLower().Trim();

            streetLetter = streetLetter.ToUpper().Trim();

            string streetAddress = street + " " + streetNumber + " " + streetLetter; // För att veta hur värdet är lagrat.

            return streetAddress;
        }

        public static string AddPostCode()
        {
            Console.Write("\nPostnummer: ");

            List<char> postCodeList = new List<char>();

            bool loop = true;

            while (loop)
            {
                postCodeList.Clear(); // Nollställ om loopen går igen så att det inte byggs på element.

                int j = 0;

                string postCode = Console.ReadLine();

                postCodeList.AddRange(postCode);

                if (!string.IsNullOrWhiteSpace(postCode))
                {
                    for (int i = postCodeList.Count - 1; i >= 0; i--) // Tar bort eventuella mellanslag.
                    {
                        if (postCodeList[i] == ' ')
                        {
                            postCodeList.Remove(postCodeList[i]);
                        }
                    }

                    foreach (char item in postCodeList) // Kollar om något annat än tal angetts eller om listan innehåller fler siffror än tillåtet.
                    {
                        if (!Char.IsDigit(item) || postCodeList.Count != 5)
                        {
                            Console.Write("Felaktig inmatning. Försök igen: ");

                            break;
                        }

                        if (j == postCodeList.Count - 1) // Bryter loopen om korrekt inmatning skett.
                        {
                            loop = false;
                        }

                        j++;
                    }
                }
                else // Om inget postnummer anges.
                {
                    Console.Write("Ingen uppgift. Försök igen: ");
                }
            }

            string pCode = new string(postCodeList.ToArray()); // Listan tillbaka som string.

            return pCode;
        }

        public static string AddPostTown()
        {
            string pTown = "";

            bool loop = true;

            while (loop)
            {
                Console.Write("\nPostort: ");

                pTown = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(pTown))
                {
                    Console.Write("Ingen uppgift. Försök igen: ");
                }
                else
                {
                    loop = false;
                }
            }

            pTown = pTown.ToLower().Trim();

            string firstLetterUpper = pTown.Substring(0, 1);

            string followingLetters = pTown.Substring(1);

            firstLetterUpper = firstLetterUpper.ToUpper() + followingLetters;

            return firstLetterUpper;
        }
    }
}




