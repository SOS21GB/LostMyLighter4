using System;
using LostMyLighterGroup4.MenuClasses;
using System.Collections.Generic;

namespace LostMyLighterGroup4
{

    class Program
    {
        static void Main(string[] args)
        {
            User namn1 = new User("laban", 13, "gata", 0);
            ProgramManager pMan = new ProgramManager();
            pMan.Presenter();
        }
    }

}
