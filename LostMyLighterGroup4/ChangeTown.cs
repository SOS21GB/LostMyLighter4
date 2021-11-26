using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4
{
    class ChangeTown
    {
        public static void ChangePostCode(int id)
        {


            string PostTown = "";
            Console.WriteLine("Skriv in din nya postort: ");

            PostTown = Console.ReadLine();

            Console.WriteLine("Din nya gata är: {0}", PostTown);

            User.GetUserById(id).pTown = PostTown;




        }
    }
}
