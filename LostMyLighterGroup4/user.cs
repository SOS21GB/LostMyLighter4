using System;
using System.Collections.Generic;

namespace LostMyLighterGroup4
{
    public class user

    {
       



        private static List<user> users = new List<user>();
        private string _name;
        private int _id;
        private int _ålder;
        private string _adress;
        private int _antalsökning;
        private int _antalregisterade;
        private int _borttappadetänder;


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
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public int Ålder
        {
            get
            {
                return _ålder;
            }
            set
            {
                _ålder = value;
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
        public int Antalsökning
        {
            get
            {
                return _antalsökning;
            }
            set
            {
                _antalsökning = value;
            }
        }
        public int Antalregisterade
        {
            get
            {
                return _antalregisterade;
            }
            set
            {
                _antalregisterade = value;
            }
        }
        public int Borttappadetändare
        {
            get
            {
                return _borttappadetänder;
            }
            set
            {
                _borttappadetänder = value;
            }
        }




        public user(string n, int i, int å, string a, int s, int r, int b)
        {
            this._name = n;
            this._id = i;
            this._ålder = å;
            this._adress = a;
            this._antalsökning = s;
            this._antalregisterade = r;
            this._borttappadetänder = b;
            users.Add(this);

        }
        public void  ListInfo()
        {
            new user("sara", 2, 22, "Käringbärget", 4, 3, 2);
            new user("Filippa", 3, 33, "Frölunda", 5, 2, 1);

        }

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

       








        public void PrintUser()
        {
            Console.WriteLine();
            Console.WriteLine(_name);
            Console.WriteLine(_ålder);
            Console.WriteLine(_adress);
            Console.WriteLine(_antalsökning);
            Console.WriteLine(_antalregisterade);
            Console.WriteLine(_borttappadetänder);
        }



        public static void PrintInfo()
        {
            foreach (user i in users)
            {
                Console.WriteLine("NAME: {0}", i._name);
                Console.WriteLine("ID: {0}", i._id);
                Console.WriteLine("ÅLDER: {0}", i._ålder);
                Console.WriteLine("ADRESS: {0}", i._adress);
                Console.WriteLine("ANTAL SÖKNING: {0}", i._antalsökning);
                Console.WriteLine("ANTAL REGISTERADE MARSCHALLER: {0}", i._antalregisterade);
                Console.WriteLine("ANTAL BORTTAPADE TÄNDER: {0}", i._borttappadetänder);
            }
        }
        public void AntalsSökning()
            {
                _antalsökning++;
                Console.WriteLine(_antalsökning);
            }
            public static void AntalsSökningStatic(user veh)
            {
                veh._antalsökning++;
                Console.WriteLine("ID: {0}", veh._id);
                Console.WriteLine(veh._antalsökning);
            }

        public static user GetUserById(int id)
        {
            foreach(user i in users)
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
        /* public static void BorttTappade(user user)
         {
            
         }*/
    }
}
}