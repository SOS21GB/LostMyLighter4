using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4
{
	public static class InputUser
	{
		public static void UserCreate()
		{
			string name = "";
			int age = 0;
			string address = "";
			int lostLighters = 0;

			int i = 0;

            Console.WriteLine("Registrera användare.");

			while (i == 0)
			{
				Console.Write("\nAnge ditt namn: ");
				try
				{
					name = Console.ReadLine();
					i++;
				}
				catch
				{
					Console.Write("\nFelaktig inmatning. Försök igen: ");
				}
			}





			while (i == 1)
			{
				Console.Write("\nAnge din ålder: ");
				try
				{
					age = Convert.ToInt32(Console.ReadLine());
					i++;

				}
				catch
				{
					Console.Write("\nFelaktig inmatning. Försök igen: ");
				}
			}


			while (i == 2)
			{
				Console.Write("\nAnge din adress: ");
				try
				{
					address = Console.ReadLine();
					i++;

				}
				catch
				{
					Console.Write("\nFelaktig inmatning. Försök igen: ");
				}



			}

			while (i == 3)
			{
				Console.Write("\nAnge antal borttappade tändare: ");
				try
				{
					lostLighters = Convert.ToInt32(Console.ReadLine());
					i++;
				}
				catch
				{
					Console.Write("\nFelaktig inmatning. Försök igen: ");
				}
			}

			User user = new User(name, age, address, lostLighters);

            Console.WriteLine("\nDitt användar-ID: {0}", user.ID);

			MenuClasses.SearchMenu.UserKeyPressToContinue();
		}

	}

}
