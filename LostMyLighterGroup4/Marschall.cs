using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4
{
    class Marschall
    {
        public static List<Marschall> marschalls = new List<Marschall>();

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
            Console.WriteLine("ID: {0}.", _id);
            Console.WriteLine("Märke: {0}.", _brand);
            Console.WriteLine("Adress: {0} {1}, {2}.",_address.Street, _address.PostCode, _address.PostTown);
            Console.WriteLine("Registrerad av: {0} den {1} vid {2}", _registeringUser, _registrationDate.ToString("yyyy/MM/dd"), _registrationDate.ToString("HH:mm:ss"));
            Console.WriteLine(_expectedBlowoutTime > DateTime.Now ? ("Förväntad slockningstid: "+ _expectedBlowoutTime.ToString("yyyy/MM/dd") + " " + _expectedBlowoutTime.ToString("HH:mm:ss")) : "Har slocknat");
        }


        //Statiska metoder för listan
        public static void PrintAllMarschalls()
        {
            if (marschalls.Count>0)
            { 
                foreach(Marschall m in marschalls)
                {
                    m.PrintInfo();
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Inga marschaller registrerade.");
            }
        }

        public static void PrintActiveMarschalls()
        {
            int i = 0;

            foreach (Marschall m in marschalls)
            {
                if(m._expectedBlowoutTime > DateTime.Now)
                {
                    m.PrintInfo();
                    Console.WriteLine();
                    i++;
                }
            }
            if(i==0)
            {
                Console.WriteLine("Inga aktiva marschaller hittades.");
            }
        }

        //Hitta gata
        public static void FindStreet() 
        {
            Console.WriteLine("Ange adress. Raderna för nummer och bokstav kan lämnas tomma (0 för att avbryta).");

            string userStreet = "";

            bool loop = true;

            while (loop)
            {
                Console.Write("\nGata: ");

                userStreet = Console.ReadLine();
                if(userStreet == "0")
                {
                    return;
                }
                if (string.IsNullOrWhiteSpace(userStreet))
                {
                    Console.Write("Ingen uppgift. Försök igen (0 för att avbryta): ");
                }
                else
                {
                    loop = false;
                }
            }

            string userStreetNumber = "";
            while (true)
            {
                Console.Write("\nNummer: ");
                string tempStr = Console.ReadLine();
                if (int.TryParse(tempStr, out int streetNo))
                {
                    userStreetNumber = streetNo.ToString();
                    break;
                }
                else if(tempStr == "")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning. Endast siffror.");
                }
            }

            string userStreetLetter = "";

            while(true)
            {
                Console.Write("\nBokstav: ");
                string tempStr = Console.ReadLine();
                if (!tempStr.All(char.IsDigit) && tempStr.Length == 1)
                {
                    userStreetLetter = tempStr;
                    break;
                }
                else if (tempStr == "")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning. Endast bokstäver.");
                }
            }

            userStreet = userStreet.ToLower().Trim();

            userStreetNumber = userStreetNumber.ToLower().Trim();

            userStreetLetter = userStreetLetter.ToUpper().Trim();

            string userQuery = userStreet + (userStreetNumber != "" ? " " + userStreetNumber : "") + (userStreetLetter != "" ? " " + userStreetLetter : ""); // Uppdelning och sammansättning för bättre kontroll.

            string firstLetterUpper = userStreet.Substring(0, 1).ToUpper() + userStreet.Substring(1); // Formatering av utskrift.

            Console.WriteLine("---------------");

            string marschallText = GetMarschallsString(streetSearch: userQuery);

            if (!string.IsNullOrEmpty(marschallText))
            {
                if (!string.IsNullOrWhiteSpace(userStreet) && !string.IsNullOrWhiteSpace(userStreetNumber) && !string.IsNullOrWhiteSpace(userStreetLetter))
                {
                    Console.WriteLine("\nEn marshall finns på {0} {1} {2}:", firstLetterUpper, userStreetNumber, userStreetLetter);
                    Console.WriteLine(marschallText);
                }
                else if (!string.IsNullOrWhiteSpace(userStreet) && !string.IsNullOrWhiteSpace(userStreetNumber))
                {
                    Console.WriteLine("\nDet finns marshall(er) på {0} {1}:", userStreet, userStreetNumber);
                    Console.WriteLine(marschallText);
                }
                else if (!string.IsNullOrWhiteSpace(userStreet))
                {
                    Console.WriteLine("\nDin sökning på {0} gav dessa träffar:", userStreet);
                    Console.WriteLine(marschallText);
                }
            }
            else
            {
                Console.WriteLine("\nIngen träff.");
            }
        }

        //Returnera sträng med flera marschallers info
        private static string GetMarschallsString(string streetSearch = "", string codeSearch = "")
        {
            string marschallsStr = "";
            int i = 0;
            foreach(Marschall m in Marschalls)
            {
                if(!String.IsNullOrEmpty(streetSearch))
                {
                    if (m.Address.Street.ToLower().Contains(streetSearch.ToLower()))
                    {
                        i++;
                        marschallsStr += $"\nMarschall nr {m.ID} finns på {m.Address.Street}, {m.Address.PostCode} {m.Address.PostTown}.";
                        marschallsStr += $"\n   Beräknas slockna: {m.ExpectedBlowoutTime.ToString("yyyy/MM/dd HH:mm")}\n";
                    }
                }
                else
                {
                    if (m.Address.PostCode.Contains(codeSearch))
                    {
                        i++;
                        marschallsStr += $"\nMarschall nr {m.ID} finns på {m.Address.Street}, {m.Address.PostCode} {m.Address.PostTown}.";
                        marschallsStr += $"\n   Beräknas slockna: {m.ExpectedBlowoutTime.ToString("yyyy/MM/dd HH:mm")}\n";
                    }
                }
            }

            return marschallsStr;
        }

        //Hitta postkod
        public static void FindPostCode()
        {
            Console.Write("Ange postnummer (0 för att avbryta): ");

            List<char> userPostCodeList = new List<char>();

            bool loop = true;

            while (loop)
            {
                userPostCodeList.Clear(); // Nollställ om loopen går igen så att det inte byggs på element.

                string userPostCode = Console.ReadLine();

                if(userPostCode == "0")
                {
                    return;
                }

                userPostCodeList.AddRange(userPostCode);

                if (!string.IsNullOrWhiteSpace(userPostCode))
                {
                    for (int i = userPostCodeList.Count - 1; i >= 0; i--) // Tar bort eventuella mellanslag.
                    {
                        if (userPostCodeList[i] == ' ')
                        {
                            userPostCodeList.RemoveAt(i);
                        }
                    }

                    if(int.TryParse(new String(userPostCodeList.ToArray()), out int _) && userPostCodeList.Count == 5) //Efter mellanslagsborttagning: om listan, konverterade till string, går att konvertera till int så är den giltig
                    {
                        loop = false;
                    }
                    else
                    {
                        Console.Write("\nFelaktig inmatning. Försök igen: ");
                    }
                }
                else // Om inget postnummer anges.
                {
                    Console.Write("\nIngen uppgift. Försök igen: ");
                }
            }

            Console.WriteLine("---------------");


            string pCode = new string(userPostCodeList.ToArray()); // Listan tillbaka som string.

            string marschallStr = GetMarschallsString(codeSearch: pCode);

            if (!string.IsNullOrWhiteSpace(marschallStr))
            {
                pCode = pCode.Insert(3, " "); // Formatering av postnumret.

                Console.WriteLine("\nDet finns marschall(er) på {0}.", pCode); 
                Console.WriteLine(marschallStr);
            }                                                                                
            else
            {
                Console.WriteLine("\nIngen träff.");
            }
        }

        public static Marschall GetMarschall(int id)
        {
            foreach (Marschall v in marschalls)
            {
                if (v._id == id)
                {
                    return v;
                }
            }
            return null;
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

