using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4.LogIn
{
    static class LogIn
    {
     
        //Metod kontrollerar inmatat användar id mot lista av användar-ID
        public static int CheckUser(List<int> userIDList)
        {
            while (true)
            {
                bool userFound = false;
                int userID=0;
                Console.Write("Skriv in ditt användar-ID, eller välj \"0\" för att gå tillbaka: ");
                try
                {
                    userID = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception)
                {
                    Console.WriteLine("Ogiltigt ID. Försök igen.");
                    continue;
                }
                if(userID==0)
                {
                    return 0;
                }
                foreach (int item in userIDList)
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
