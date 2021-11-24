using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4
{

	class UserInput
	{
		public static void UserCreate()
		{
			int i = 0;

            while (i == 0)
            {
				Console.WriteLine("skriv ditt namn: ");
				try
				{
					string _name = Console.ReadLine();
					i++;

				}
				catch
				{
					Console.WriteLine("Error try again");
				}
			}
			

			while(i == 1)
            {
				Console.WriteLine("skriv ditt Id: ");
				try
				{
					int _id = Convert.ToInt32(Console.ReadLine());
					i++;
				}
				catch
				{
					Console.WriteLine("Error try again");
				}
			}
			

			while(i == 2)
            {
				Console.WriteLine("skriv din ålder: ");
				try
				{
					int _age = Convert.ToInt32(Console.ReadLine());
					i++;
				}
				catch
				{
					Console.WriteLine("Error try again");
				}
			}
			

			while(i == 3)
            {
				Console.WriteLine("skriv din adress: ");
				try
				{
					string _address = Console.ReadLine();
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
