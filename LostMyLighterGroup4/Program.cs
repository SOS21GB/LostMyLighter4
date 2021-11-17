using System;
using LostMyLighterGroup4.MenuClasses;
using System.Collections.Generic;

namespace LostMyLighterGroup4
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyUser name = new DummyUser();
            DummyUser name2 = new DummyUser();
            List<int> users = new List<int>();
            foreach(int item in DummyUser.UsersIDS.Keys)
            {
                users.Add(item);
            }
                LogIn.CheckUser(users);




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

            user user = new user(name, id, ålder, adress, antals, antalr, antalb);
            /* user.Dobare();
              user user1 = new user(name, id, ålder, adress, antals, antalr, antalb);*/




            // måste skriva en metod för att få flera user
            user user2 = new user("sara", 2, 22, "salt", 10, 20, 30);
            user.PrintInfo();
            Console.WriteLine("Enter ID:");
            int iD = Convert.ToInt32(Console.ReadLine());
            user currentuser = user.GetUserById(iD);
            currentuser.PrintUser();

            /*currentuser.AntalsSökning();
            user.AntalsSökningStatic(currentuser.)*/
        }
    }
}
