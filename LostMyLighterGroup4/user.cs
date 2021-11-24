using System;
using System.Collections.Generic;

namespace LostMyLighterGroup4
{
    public class User

    {
        //Fields
        private static List<User> users = new List<User>();
        private string _name;
        private int _age;
        private string _adress;
        private int _searches;
        private int _regMarschalls;
        private int _lostLighters;
        private int _id;

        //Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public string Adress
        {
            get
            {
                return _adress;
            }
            set
            {
                _adress = value;
            }
        }
        public int Searches
        {
            get
            {
                return _searches;
            }
            set
            {
                _searches = value;
            }
        }
        public int ID
        {
            get
            {
                return _id;
            }
            set //Tillåtet att ändra sitt ID?
            {
                _id = value;
            }
        }
        public int RegisteredMarschalls
        {
            get
            {
                return _regMarschalls;
            }
            set
            {
                _regMarschalls = value;
            }
        }
        public int LostLighters
        {
            get
            {
                return _lostLighters;
            }
            set
            {
                _lostLighters = value;
            }
        }



        //Konstruktor
        public User(string name, int age, string adress, int lostLighters)
        {
            this._name = name;
            this._age = age;
            this._adress = adress;
            this._regMarschalls = 0;
            this._searches = 0;
            this._lostLighters = lostLighters;
            this._id = AddUserID();
            users.Add(this);

        }
        // Poänglös metod?
        /*
        public void  ListInfo()
        {
            new user("sara", 2, 22, "Käringbärget", 4, 3, 2);
            new user("Filippa", 3, 33, "Frölunda", 5, 2, 1);

        }
        */

        //Onödig metod då detta sköts via statiska klassen?
        /*
        public void Info()
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ålder:");
            int ålder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adress:");
            string adress = Console.ReadLine();
            Console.WriteLine("Antal sökning:");
            int antals = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Antal registerade marschall:");
            int antalr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Antal borttapade tänder:");
            int antalb = Convert.ToInt32(Console.ReadLine());
        }
        */
        public static int AddUserID()
        {
            int newId = 1;
            foreach (User user in users)
            {
                if (newId == user.ID)
                {
                    newId++;
                }
                else
                {
                    break;
                }
            }
            return newId;
        }

            public void PrintUser()
        {
            Console.WriteLine();
            Console.WriteLine(_name);
            Console.WriteLine(_age);
            Console.WriteLine(_adress);
            Console.WriteLine(_searches);
            Console.WriteLine(_regMarschalls);
            Console.WriteLine(_lostLighters);
        }


        //Behöver vi denna metod? Admin funktion?
        public static void PrintInfo()
        {
            foreach (User i in users)
            {
                Console.WriteLine("NAME: {0}", i._name);
                Console.WriteLine("ID: {0}", i._id);
                Console.WriteLine("ÅLDER: {0}", i._age);
                Console.WriteLine("ADRESS: {0}", i._adress);
                Console.WriteLine("ANTAL SÖKNING: {0}", i._searches);
                Console.WriteLine("ANTAL REGISTERADE MARSCHALLER: {0}", i._regMarschalls);
                Console.WriteLine("ANTAL BORTTAPADE TÄNDER: {0}", i._lostLighters);
            }
        }
        public void AddSearch()
            {
                _searches++;
                Console.WriteLine(_searches);
            }
            public static void AntalsSökningStatic(User veh)
            {
                veh._searches++;
                Console.WriteLine("ID: {0}", veh._id);
                Console.WriteLine(veh._searches);
            }


        //Denna metoden fungerar inte.får inte returnerna null? Behöver vi denna ens?
        /*
        public static user GetUserById(int id)

        {
            foreach(User i in users)
            {
                if(i._id == id)
                {
                    return i;
                }
                else
                {
                    return null;
                }
            }
        }
        */

        /* public static void BorttTappade(user user)
         {
            
         }*/
    }
}
}