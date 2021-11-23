using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4
{
    class Marschall
    {
        private static List<Marschall> marschalls = new List<Marschall>();

        //Id, Märke, Förväntad brinntid, Adress, Tid för registrering, Vilken användare som registrerade den, När den förväntas slockna
        private int _id;
        private string _brand;
        private Address _address;
        private string _registeringUser;
        private DateTime _registrationDate = DateTime.Now;
        private double _expectedBurnTime = 0;
        private DateTime _expectedBlowoutTime = DateTime.Now;

        public Marschall(string _brand, Address _address, string _registeringUser, double _expectedBurnTime)

        {
            this._id = marschalls.Count + 1;
            this._brand = _brand;
            this._address = _address;
            this._registeringUser = _registeringUser;
            this._registrationDate = DateTime.Now;
            this._expectedBurnTime = _expectedBurnTime;
            this._expectedBlowoutTime = _expectedBlowoutTime.AddHours(_expectedBurnTime);

            marschalls.Add(this);
        }

        public void PrintInfo()
        { 
            Console.WriteLine("ID: {0}. Brand: {1}. Address: {2}", _id, _brand, _address.Street);
            Console.WriteLine("   Registered by: {0} on {1} at {2}", _registeringUser, _registrationDate.ToString("yyyy/MM/dd"), _registrationDate.ToString("HH:mm:ss"));
            Console.WriteLine( "   Expected blow out: {0}, {1}", _expectedBlowoutTime.ToString("yyyy/MM/dd"), _expectedBlowoutTime.ToString("HH:mm:ss"));
        }


        //Statiska metoder för listan
        public static void PrintAllMarschalls()
        {
            foreach(Marschall m in marschalls)
            {
                m.PrintInfo();
            }
        }

        public static void PrintActiveMarschalls()
        {
            foreach (Marschall m in marschalls)
            {
                if(m._expectedBlowoutTime > DateTime.Now)
                    m.PrintInfo();
            }
        }

        public static void FindStreet(string street) // Addressobjektets gata ska in här.
        {
            Console.WriteLine("Ange adress. Raderna för nummer och bokstav kan lämnas tomma. ");

            string userStreet = "";

            bool loop = true;

            while (loop)
            {
                Console.Write("\nGata: ");

                userStreet = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userStreet))
                {
                    Console.Write("Ingen uppgift. Försök igen: ");
                }
                else
                {
                    loop = false;
                }
            }

            Console.Write("\nNummer: ");

            string userStreetNumber = Console.ReadLine();

            Console.Write("\nBokstav: ");

            string userStreetLetter = Console.ReadLine();

            userStreet = userStreet.ToLower().Trim();

            userStreetNumber = userStreetNumber.ToLower().Trim();

            userStreetLetter = userStreetLetter.ToUpper().Trim();

            string userQuery = userStreet + " " + userStreetNumber + " " + userStreetLetter; // Uppdelning och sammansättning för bättre kontroll.

            string firstLetterUpper = userStreet.Substring(0, 1); // Formatering av utskrift.

            string followingLetters = userStreet.Substring(1);

            firstLetterUpper = firstLetterUpper.ToUpper() + followingLetters;

            List<char> streetList = new List<char>(); // För att få med hela gatunamnet om bara första ordet anges i en flerordig adress.

            streetList.AddRange(street);

            string streetAddLetters = "";

            foreach (var item in streetList)
            {
                if (!Char.IsDigit(item))
                {
                    streetAddLetters += item;
                }
                else
                {
                    break;
                }
            }

            streetAddLetters = streetAddLetters.TrimEnd();

            if (street.Equals(userQuery) && !string.IsNullOrWhiteSpace(userStreetNumber) && !string.IsNullOrWhiteSpace(userStreetLetter))
            {
                Console.WriteLine("\nEn marshall finns på {0} {1} {2}.", firstLetterUpper, userStreetNumber, userStreetLetter);
            }
            else if (streetAddLetters.Equals(userStreet) && street.Contains(userStreetNumber) && !string.IsNullOrWhiteSpace(userStreetNumber))// streetStart här och under
            {
                Console.WriteLine("\nEn marshall finns på {0}.", street);
            }
            else if (streetAddLetters.Equals(userStreet) || streetAddLetters.StartsWith(userStreet))
            {
                Console.WriteLine("\nMinst en marschall finns någonstans på {0}", streetAddLetters);
            }
            else
            {
                Console.WriteLine("\nIngen träff.");
            }
        }

        public static void FindPostCode(string postCode) // Adressobjektets postnummer ska in här.
        {
            Console.Write("Ange postnummer: ");

            List<char> userPostCodeList = new List<char>();

            bool loop = true;

            while (loop)
            {
                userPostCodeList.Clear(); // Nollställ om loopen går igen så att det inte byggs på element.

                int j = 0;

                string userPostCode = Console.ReadLine();

                userPostCodeList.AddRange(userPostCode);

                if (!string.IsNullOrWhiteSpace(userPostCode))
                {
                    for (int i = userPostCodeList.Count - 1; i >= 0; i--) // Tar bort eventuella mellanslag.
                    {
                        if (userPostCodeList[i] == ' ')
                        {
                            userPostCodeList.Remove(userPostCodeList[i]);
                        }
                    }

                    foreach (char item in userPostCodeList) // Kollar om något annat än tal angetts eller om listan innehåller fler siffror än tillåtet.
                    {
                        if (!Char.IsDigit(item) || userPostCodeList.Count != 5)
                        {
                            Console.Write("Felaktig inmatning. Försök igen: ");

                            break;
                        }

                        if (j == userPostCodeList.Count - 1) // Bryter loopen om korrekt inmatning skett.
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

            string pCode = new string(userPostCodeList.ToArray()); // Listan tillbaka som string.

            if (postCode == pCode)
            {
                postCode = postCode.Insert(3, " "); // Formatering av postnumret.

                Console.WriteLine("Det finns minst en marshall på postnummer {0}.", postCode); // FIXA EN RÄKNARE SÅ ATT DET INTE SKRIVS UT
            }                                                                                  // IGEN OCH IGEN?
            else
            {
                Console.WriteLine("Ingen träff.");
            }
        }

        //Properties
        //List
        static public List<Marschall> Marschalls
        {
            get { return marschalls; }
        }

        //Fields
        public int ID
        {
            get { return _id; }
        }
        public string Brand
        {
            get { return _brand; }
        }
        public Address Address
        {
            get { return _address; }
        }
        public string RegisteringUser
        {
            get { return _registeringUser; }
        }
        public DateTime RegistrationDate
        {
            get { return _registrationDate; }
        }
        public double ExpectedBurnTime
        {
            get { return _expectedBurnTime; }
        }
        public DateTime ExpectedBlowoutTime
        {
            get { return _expectedBlowoutTime; }
        }
    }
}

