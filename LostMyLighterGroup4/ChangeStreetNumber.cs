using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4
{
    class ChangeStreetNumber
    {
        public static void ChangePostCode(int id)
        {
            int postcode = 0;
            Console.WriteLine("Skriv in din nya postnummer utan mellanslag: ");
            postcode = Convert.ToInt32(Console.ReadLine());
            Convert.ToString(postcode);
            User.GetUserById(id).pCode = postcode;

            Console.WriteLine("Ditt nya postnummer är: {0}", postcode);




        }
    }
}