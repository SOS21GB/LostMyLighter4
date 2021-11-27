using System;
namespace LostMyLighterGroup4
{
    public class ChangeUser
    {
        public static void ChangeUserMethod(int id)
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Vad vill du redigera?");

                Console.WriteLine("1)  Namn.");
                Console.WriteLine("2)  Ålder.");
                Console.WriteLine("3)  Adress.");
                Console.WriteLine("4)  Ta bort användare.");
                Console.WriteLine("0)  Återgå till huvudmenyn.");
                switch (Console.ReadLine())
                {
                    case "1":
                        if (ChangeName(id))
                        {
                            return;
                        }
                        else
                        {
                            break;
                        }
                    case "2":
                        if (ChangeAge(id))
                        {
                            return;
                        }
                        else
                        {
                            break;
                        }
                    case "3":
                        if (ChangeAddress(id))
                        {
                            return;
                        }
                        else
                        {
                            break;
                        }
                    case "4":
                        if (User.DeleteUser(id))
                        {
                            return;
                        }
                        else
                        {
                            break;
                        }
                    case "0":
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Felaktig inmatning. Försök igen.");
                        break;
                }
            }
        }

        //Ändra namn
        private static bool ChangeName(int id)
        {
            while (true)
            {
                Console.WriteLine("Ändra användarens namn. (0 för att avbryta)");
                string tempInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(tempInput) && tempInput != "0")
                {
                    User.GetUserById(id).Name = tempInput;
                    Console.WriteLine("Ditt namn har ändrats till {0}.", tempInput);
                    MenuClasses.SearchMenu.UserKeyPressToContinue();
                    Console.Clear();
                    return true;
                }
                else if (tempInput == "0")
                {
                    Console.Clear();
                    return false;
                }
                else
                {
                    Console.WriteLine("Ditt namn kan inte vara tomt. Försök igen.");
                }
            }
        }

        //Ändra ålder
        private static bool ChangeAge(int id)
        {
            while (true)
            {
                Console.WriteLine("Ändra användarens ålder till. (0 för att avbryta)");
                int tempAge = 0;
                if (int.TryParse(Console.ReadLine(), out tempAge) && tempAge != 0)
                {
                    User.GetUserById(id).Age = tempAge;
                    Console.WriteLine("Din ålder har ändrats till {0}.", tempAge);
                    MenuClasses.SearchMenu.UserKeyPressToContinue();
                    Console.Clear();
                    return true;
                }
                else if (tempAge == 0)
                {
                    Console.Clear();
                    return false;
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning. Försök igen.");
                }
            }
        }

        //Ändra address
        private static bool ChangeAddress(int id)
        {
            string address = "";

            while (true)
            {
                Console.WriteLine("Skriv in din nya gata. (0 för att avbryta)");

                address = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(address) && address != "0")
                {
                    Console.WriteLine("Din nya gata är: {0}", address);

                    User.GetUserById(id).Address = address;
                    MenuClasses.SearchMenu.UserKeyPressToContinue();
                    Console.Clear();
                    return true;
                }
                else if (address == "0")
                {
                    Console.Clear();
                    return false;
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning. Försök igen.");
                }
            }
        }

    }
}
