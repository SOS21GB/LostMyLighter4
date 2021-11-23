using System;
using LostMyLighterGroup4.MenuClasses;
using System.Collections.Generic;

namespace LostMyLighterGroup4
{
    class Program
    {
        static void Main(string[] args)
        {
            LogIn.DummyUser name = new LogIn.DummyUser();
            LogIn.DummyUser name2 = new LogIn.DummyUser();
            ProgramManager pMan = new ProgramManager();
            pMan.Presenter();
        }
    }
}
