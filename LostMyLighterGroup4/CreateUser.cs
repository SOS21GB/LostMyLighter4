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

			while (i == 0)
			{
				Console.WriteLine("skriv ditt namn: ");
				try
				{
					name = Console.ReadLine();
					i++;
				}
				catch
				{
					Console.WriteLine("Error try again");
				}
			}





			while (i == 1)
			{
				Console.WriteLine("skriv din ålder: ");
				try
				{
					age = Convert.ToInt32(Console.ReadLine());
					i++;

				}
				catch
				{
					Console.WriteLine("Error try again");
				}
			}


			while (i == 2)
			{
				Console.WriteLine("skriv din adress: ");
				try
				{
					address = Console.ReadLine();
					i++;

				}
				catch
				{
					Console.WriteLine("Error try again");
				}



			}

			while (i == 3)
			{
				Console.WriteLine("skriv antalet borttappade tändare: ");
				try
				{
					lostLighters = Convert.ToInt32(Console.ReadLine());
					i++;
				}
				catch
				{
					Console.WriteLine("Error try again");
				}
			}

			User user = new User(name, age, address, lostLighters);
			user.PrintUser();

			MenuClasses.SearchMenu.UserKeyPressToContinue();
		}

	}

}
