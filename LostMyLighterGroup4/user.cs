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
        
        //Metoder

        //Skapar ID
        private int AddUserID()
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

        //Visar info
        public void PrintUser()
        {
            Console.Clear();
            Console.WriteLine("ID:{0}. Namn: {0}.", _id, _name);
            Console.WriteLine("Ålder: {0}. Adress: {1}", _age, _address);
            Console.WriteLine("Sökningar: {0}. Registrerade marschaller: {1}. Borttappade tändare: {3}.", _searches, _regMarschalls, _lostLighters);
            Console.WriteLine();
            Console.WriteLine("\n \n Tryck på valfri tangent för att återgå till huvudmeny...");
            Console.ReadKey();
        }


        //Listar alla användare, behöver vi denna metod? Admin funktion?
        public static void PrintInfo()
        {
            Console.Clear();
            foreach (User i in users)
            {
                Console.WriteLine("Namn: {0}", i._name);
                Console.WriteLine("ID: {0}", i._id);
                Console.WriteLine("Ålder: {0}", i._age);
                Console.WriteLine("Adress: {0}", i._address);
                Console.WriteLine("Antal sökningar: {0}", i._searches);
                Console.WriteLine("Antal registrerade marschaller: {0}", i._regMarschalls);
                Console.WriteLine("Antal borttappade tändare: {0} \n", i._lostLighters);
            }
            Console.WriteLine("\n \n Tryck på valfri tangent för att återgå till huvudmeny..");
            Console.ReadKey();
        }

        //Ökar sökningscountern
        public static void AddSearch(User u)
        {
            u.Searches++;
        }


        //Metod som lägger alla Id i en lista och returnerar den.
        public static List<int> UserIDList()
        {
            List<int> userIDList = new List<int>();
            foreach (User u in users)
            {
                userIDList.Add(u.ID);
            }
            return userIDList;
        }


        //returnerar användarobjekt beroende på ID
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

        //Tar bort en användare om id kan hittas i listan
        public static bool DeleteUser(int id)
        {
            Console.Clear();
            Console.WriteLine("Är du säker på att du vill ta bort din användarprofil ? \nTryck (1) för att fortsätta, eller (0) för att avbryta");
            while (true)
            {
                Console.Write("Ditt val: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        foreach (User i in users)
                        {
                            if (i.ID == id)
                            {
                                users.Remove(i);
                                Console.WriteLine("Användare borttagen.");
                                MenuClasses.SearchMenu.UserKeyPressToContinue();
                                return true;
                            }
                        }
                        break;
                    case "0":
                        return false;
                    default:
                        Console.WriteLine("Ogiltigt val");
                        break;
                }
            }
        }

        public static void AddLostLighter(User users)
        {
            Console.Clear();
            bool loop = true;

            while (loop)    
            {
                Console.Write("Antal borttappade tändare att registera: ");     

                if (int.TryParse(Console.ReadLine(), out int lighter))
                {
                    Console.WriteLine("{0} borttappade tändare har registrerats", lighter);
                    users._lostLighters += lighter;
                    loop = false;
                }
                else
                {
                    Console.Write("Felaktig inmatning. Försök igen: ");
                }
            }
            Console.WriteLine("Tryck på valfri tangent för att fortsätta..");
            Console.ReadKey();
        }

    }
}
