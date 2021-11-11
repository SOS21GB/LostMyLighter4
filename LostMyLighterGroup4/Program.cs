using System;
using LostMyLighterGroup4.MenuClasses;
using System.Collections.Generic;

namespace LostMyLighterGroup4
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyUser name = new DummyUser();
            DummyUser name2 = new DummyUser();
            List<int> users = new List<int>();
            foreach(int item in DummyUser.UsersIDS.Keys)
            {
                users.Add(item);
            }
                LogIn.CheckUser(users);

        }
    }
}
