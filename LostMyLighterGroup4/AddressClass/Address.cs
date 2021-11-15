using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4
{
    class Address
    {
        //private static List<Address> addressList = new List<Address>();

        private string _street;
        private string _postCode;
        private string _postTown;

        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
            }
        }

        public string PostCode
        {
            get
            {
                return _postCode;
            }
            set
            {
                _postCode = value;
            }
        }

        public string PostTown
        {
            get
            {
                return _postTown;
            }
            set
            {
                _postTown = value;
            }
        }

        public Address(string street, string postCode, string postTown)
        {
            this._street = street;
            this._postCode = postCode;
            this._postTown = postTown;
            //addressList.Add(this);
        }

        /*
        // Göra alla bokstäver små någonstans.
        // Söka på bara gata (utan nummer)?
        // Svar om ingen marschall finns

        public static void FindStreet()// User input-parameter
        {
            foreach (Address str in addressList)
            {
                if (str.Street.Contains("ABCvägen"))// User input
                {
                    Console.WriteLine("En marschall finns på {0}.", str.Street);
                }
            }
        }

        public static void FindPostCode()//User input-parameter
        {
            int count = 0;

            foreach (Address pos in addressList)
            {
                if (pos.PostCode == "123 45")// User input REMOVE-metod
                {
                    count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine("Det finns {0} marschaller på postnummer {1}.", count, // User input);
            }
            else
            {
                Console.WriteLine("Postnumret saknar marschaller.");
            }
        }

        public static Address PrintAddress(int id)// marschall-id för att skriva ut en adress
        {
            foreach (Address adr in addressList)
            {
                if (adr. == id)// id från marschall
                {
                    return adr;
                }
            }

            return null;
        }

        // Ej nödvändig
        public static void PrintAllAddresses()
        {
            foreach (Address adr in addressList)
            {
                Console.WriteLine(adr.Street);
                Console.Write(adr.PostCode + " ");
                Console.WriteLine(adr.PostTown);
            }
        }
        */



    }
}
