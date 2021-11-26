using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4
{
     static class UserInput
    {
		public static void UserCreate()
		{





			int i = 0;

			while (i == 0)
			{
				Console.WriteLine("skriv ditt namn: ");
				try
				{
					string name = Console.ReadLine();
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
					int age = Convert.ToInt32(Console.ReadLine());
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
					string address = Console.ReadLine();
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
					int lostLighters = Convert.ToInt32(Console.ReadLine());
					i++;

				}
				catch
				{
					Console.WriteLine("Error try again");
				}
			}




		}
	}
}
