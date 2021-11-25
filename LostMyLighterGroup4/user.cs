using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LostMyLighterGroup4
{
    public class User
    {
        //Fields
        private static List<User> users = new List<User>();
        private string _name;
        private int _age;
        private string _address;
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
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
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
            this._address = adress;
            this._regMarschalls = 0;
            this._searches = 0;
            this._lostLighters = lostLighters;
            this._id = AddUserID();
            users.Add(this);
        }

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
            Console.Clear();
            Console.WriteLine("NAME: {0}", _name);
            Console.WriteLine("ID: {0}", _id);
            Console.WriteLine("ÅLDER: {0}", _age);
            Console.WriteLine("ADRESS: {0}", _address);
            Console.WriteLine("ANTAL SÖKNING: {0}", _searches);
            Console.WriteLine("ANTAL REGISTERADE MARSCHALLER: {0}", _regMarschalls);
            Console.WriteLine("ANTAL BORTTAPADE TÄNDER: {0}", _lostLighters);
            Console.WriteLine("\n tryck på valfri tangent för att återgå..");
            Console.ReadKey();
        }


        //Behöver vi denna metod? Admin funktion?
        public static void PrintInfo()
        {
            foreach (User i in users)
            {
                Console.WriteLine("NAME: {0}", i._name);
                Console.WriteLine("ID: {0}", i._id);
                Console.WriteLine("ÅLDER: {0}", i._age);
                Console.WriteLine("ADRESS: {0}", i._address);
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
        //Metod som lägger alla Id i en lista och returnerar den.
        public static List<int> UserIDList()
        {
            List<int> userIDList = new List<int>();
            foreach (User user in users)
            {
                userIDList.Add(user.ID);
            }
            return userIDList;
        }

        public static User GetUserById(int id)
        {
            foreach (User i in users)
            {
                if (i._id == id)
                {
                    return i;
                }
            }
            return null;
        }

    }
}
