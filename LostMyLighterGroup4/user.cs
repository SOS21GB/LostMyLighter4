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

        public void AntalsSökning()
        {
            _antalsökning++;
            Console.WriteLine(_antalsökning);
        }
        public static void AntalsSökningStatic(user inf)
        {
            inf._antalsökning++;
            Console.WriteLine("ID: {0}", inf._id);
            Console.WriteLine(inf._antalsökning);
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



        public static user GetUserById(int id)

        {

            foreach (user i in users)
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

   
