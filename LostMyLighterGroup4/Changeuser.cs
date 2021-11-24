using System;
using System.Collections.Generic;

namespace LostMyLighterGroup4
{
    public static class Changeuser
    {


        public static void Ändranamn()
        {
            Console.WriteLine("ditt nuvarande namn är: {0}", _name);
            Console.WriteLine("skriv nytt namn:");
            this._name = Console.ReadLine();
            Console.WriteLine("ditt nytt namn är: {0}", this._name);
        }
        public static void Ändraålder()
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
        
        public static void Ändraadress()
        {
            Console.WriteLine("din nuvarande adress är :{0}", this._adress);
            Console.WriteLine("skriv ny adress");
            this._adress = Console.ReadLine();
            Console.WriteLine("din ny adress är:{0}", this._adress);
        }
    }
}
