using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4.MenuClasses
{
    static class LogIn
    {
        static bool userFound = false;
        static int userID;
        

        //Metod kollar inskrivet ID med sparade ID:n från skapade DummyUsers
        //Måste uppdateras med riktiga Userklassen
        public static int CheckUser()
        {
            while (true)
            {
                Console.Write("Skriv in ditt användar-ID: ");
                try
                {
                    userID = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception)
                {
                }
                foreach (int item in DummyUser.UsersIDS.Keys)
                {
                    if (userID == item)
                    {
                        userFound = true;
                    }
                }
                    switch (userFound)
                {
                    case true:
                        //PasswordCheckMethod();
                        Console.WriteLine("Du är inloggad");
                        return userID;
                            
                    default:
                        Console.WriteLine("Ej giltigt användar-ID");
                        break;
                }
            }
        }
    }
}
