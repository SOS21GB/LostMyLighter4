using System;
namespace LostMyLighterGroup4
{
    public class MethodChange
    {
        public static void ChangeUserMethod(int id)
        {
            int Input = 0;

            do
            {
                Console.WriteLine(" Choose what do you want to change? ");
                Console.WriteLine("1.  Name:");
                Console.WriteLine("2.  Age:");


                try
                {
                    Input = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();

                }

            } while (Input == 0);

            switch (Input)
            {
                case 1:

                    Console.WriteLine("Ändra namn: ");
                    User.GetUserById(id).Name = Console.ReadLine();
                   
                    break;

                case 2:
                    Console.WriteLine("Ändra ålder: ");
                    User.GetUserById(id).Age = Convert.ToInt32(Console.ReadLine());
                    break;


            }


        }
    }
}
