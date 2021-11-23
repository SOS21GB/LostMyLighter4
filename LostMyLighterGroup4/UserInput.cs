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
			Console.WriteLine("skriv ditt namn: ");
			try
			{
				string _name = Console.ReadLine();


			}
			catch
			{
				Console.WriteLine("Error try again");
			}


			Console.WriteLine("skriv ditt Id: ");
			try
			{


				int _id = Convert.ToInt32(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("Error try again");
			}


			Console.WriteLine("skriv din ålder: ");
			try
			{


				int _age = Convert.ToInt32(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("Error try again");
			}


			Console.WriteLine("skriv din adress: ");
			try
			{


				string _address = Console.ReadLine();
			}
			catch
			{
				Console.WriteLine("Error try again");
			}






		}

	}
}
