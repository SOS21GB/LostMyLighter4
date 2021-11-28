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
				name = Console.ReadLine();

				if(!string.IsNullOrEmpty(name))
					i++;
				else
					Console.Write("\nFelaktig inmatning. Försök igen: ");

			}





			while (i == 1)
			{
				Console.Write("\nAnge din ålder: ");
				
				if(int.TryParse(Console.ReadLine(), out age))
					i++;
				else
					Console.Write("\nFelaktig inmatning. Försök igen: ");
			}


			while (i == 2)
			{
				Console.Write("\nAnge din adress: ");
				address = Console.ReadLine();

				if (!string.IsNullOrEmpty(address))
					i++;
				else
					Console.Write("\nFelaktig inmatning. Försök igen: ");
			}

			while (i == 3)
			{
				Console.Write("\nAnge antal borttappade tändare: ");
				if (int.TryParse(Console.ReadLine(), out lostLighters))
					i++;
				else
					Console.Write("\nFelaktig inmatning. Försök igen: ");
			}

			User user = new User(name, age, address, lostLighters);

            Console.WriteLine("\nDitt användar-ID: {0}", user.ID);

			MenuClasses.SearchMenu.UserKeyPressToContinue();
		}

	}

}
