using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4.ManagerClasses
{
    class MarschallManager
    {
        //private List<marschall> _marschalls = new List<string>();
        private List<string> _marschalls = new List<string>();

        //Returnerar en array med alla giltiga ID:n
        public string[] GetAllMarschalls() { return _marschalls.ToArray(); }

        //Här ska finnas call till login-metoden så småningom

        #region Add, Remove, GetUser
        //Lägger till användare, letar upp oanvänt id och assignar det till användaren, vilket sedan också blir dess key i dictionaryn
        //public void AddUser(string marschall)
        //{
        //    int newId = 1;
        //    foreach (string m in _marschalls)
        //    {
        //        if (newId == m.ID)
        //            newId++;
        //        else
        //            break;
        //    }

        //    //marschall.ID = newId;
        //    _marschalls.Add(marschall);
        //}

        //Tar bort en användare. Returnerar true om den lyckas
        //public bool DeleteUser(int id)
        //{
        //    foreach (string m in _marschalls)
        //    {
        //        if (m.ID = id)
        //    {
        //            _marschalls.Remove(m);
        //            return true;
        //        }
        //    }

        //    return false;
        //}

        //Returnera en användare eller null. byt ut string mot User-klassen 
        //public string GetMarschall(int id)
        //{
        //    foreach(string m in _marschalls)
        //    {
        //        if (m.ID = id)
        //            return m;
        //    }
        //    return null;
        //}
        #endregion
    }
}
