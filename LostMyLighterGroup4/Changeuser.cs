using System;
namespace LostMyLighterGroup4
{
    public class Changeuser
    {
        private static List<Changeuser> users = new List<Changeuser>();
        private string _name;
        private int _id;
        private int _ålder;
        private string _adress;
        private int _antalsökning;
        private int _antalregisterade;
        private int _borttappadetänder;


        public void InfoSearch()
        {
            Changeuser changeuser = new Changeuser("sara", 1, 33, "Önnered", 34, 35, 36);
            Changeuser changeuser1 = new Changeuser("Jessica", 2, 34, "Saltholmsgatan", 44, 45, 46);
            Changeuser changeuser2 = new Changeuser("Filippa", 3, 35, "Bildal", 54, 55, 56);




        }


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




        public Changeuser(string n, int i, int å, string a, int s, int r, int b)
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
            foreach (Changeuser i in users)
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


        public void Ändranamn()
        {
            Console.WriteLine("ditt nuvarande namn är: {0}", _name);
            Console.WriteLine("skriv nytt namn:");
            this._name = Console.ReadLine();
            Console.WriteLine("ditt nytt namn är: {0}", this._name);
        }
        public void Ändraålder()
        {
            Console.WriteLine("ditt nuvarande ålder är: {0}", _ålder);
            Console.WriteLine("skriv nytt ålder:");
            if (int.TryParse(Console.ReadLine(), out this._ålder)) ;
            {
                Console.WriteLine("ny Ålder är :{0}", this._ålder);
            }
            else
            {
                Console.WriteLine("fel!");
            }



        }
        public void Ändraadress()
        {
            Console.WriteLine("din nuvarande adress är :{0}", this._adress);
            Console.WriteLine("skriv ny adress");
            this._adress = Console.ReadLine();
            Console.WriteLine("din ny adress är:{0}", this._adress);
        }
    }
}
