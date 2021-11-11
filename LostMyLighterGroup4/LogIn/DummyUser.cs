using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4.MenuClasses
{
    class DummyUser
    {
        //Klass för att skapa en dummy user för LogIn test.
        private int _userID;
        private static Dictionary<int,DummyUser> users = new Dictionary<int,DummyUser>();

        public static Dictionary<int,DummyUser> UsersIDS
        {
            get
            {
                return users;
            }
        }
        public static int UserIDCreator()
        {
            int newUser = users.Count + 1;
            return newUser;
        }
        public DummyUser()
        {
            
            users.Add(UserIDCreator(),this);
            
        }
    }
}
