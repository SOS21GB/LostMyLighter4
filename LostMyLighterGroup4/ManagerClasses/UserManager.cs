using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4.ManagerClasses
{
    //UserManager klass med utkommenterade calls till faktiska user-klassen
    class UserManager
    {
        //private Dictionary<int, user> _users = new Dictionary<int, users>();
        private Dictionary<int, string> _users = new Dictionary<int, string>();

        //Returnerar en array med alla giltiga ID:n
        public int[] GetAllIDs() { return _users.Keys.ToArray(); }

        //Här ska finnas call till login-metoden så småningom

        #region Add, Remove, GetUser
        //Lägger till användare, letar upp oanvänt id och assignar det till användaren, vilket sedan också blir dess key i dictionaryn
        public void AddUser(string user)
        {
            int newId = 1;
            foreach (KeyValuePair<int, string> kvp in _users)
            {
                if (newId == kvp.Key)
                    newId++;
                else
                {
                    break;
                }
            }

            //user.id = newId;
            _users.Add(newId, user);
        }

        //Tar bort en användare. Returnerar true om den lyckas
        public bool DeleteUser(int id)
        {
            if (_users.ContainsKey(id))
            {
                _users.Remove(id);
                return true;
            }
            return false;
        }

        //Returnera en användare eller null. byt ut string mot User-klassen 
        public string GetUser(int id)
        {
            if (_users.TryGetValue(id, out string user))
                return user;
            else
                return null;
        }
        #endregion

        #region Change user values
        //Ändra namn. Tar in id och namn, returnerar true om namnet är giltigt och användaren finns
        public bool ChangeName(int id, string newName)
        {
            if (!string.IsNullOrEmpty(newName) && _users.ContainsKey(id))
            {
                //_users[id].Name = newName;
                return true;
            }
            else
                return false;
        }

        //Ändra ålder. Tar in id och ny ålder, returnerar true om åldern inte är negativ och användaren finns
        public bool ChangeAge(int id, int newAge)
        {
            if (newAge > -1 && _users.ContainsKey(id))
            {
                //_users[id].Age = newAge;
                return true;
            }
            else
                return false;
        }
        //Ändra address. Tar in id och ett addressobjekt. Returnerar true om användarn finns och newAddress inte är null
        public bool ChangeAddress(int id, Address newAddress)
        {
            if (newAddress != null && _users.ContainsKey(id))
            {
                //_users[id].Address = newAddress;
                return true;
            }
            else
                return false;
        }
        #endregion

        #region Add no of searches, reg.marschalls, lost lighters
        //Metoder för att lägga till saker. Returnerar nya värdet
        //public int AddSearch(int id)
        //{
        //    if (_users.ContainsKey(id))
        //        return _users[id].Searches++;
        //    else
        //        return -1;
        //}

        //public int AddRegisteredMarschalls(int id)
        //{
        //    if (_users.ContainsKey(id))
        //        return _users[id].RegisteredMarschalls++;
        //    else
        //        return -1;
        //}

        //public int LostLighters(int id)
        //{
        //    if (_users.ContainsKey(id))
        //        return _users[id].LostLighters++;
        //    else
        //        return -1;
        //}
        #endregion
    }
}
