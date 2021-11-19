using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4
{
    class Marschall
    {

        //Id, Märke, Förväntad brinntid, Adress, Tid för registrering, Vilken användare som registrerade den, När den förväntas slockna
        private int _id;
        private string _brand;
        private Address _address;
        private string _registeringUser;
        private DateTime _registrationDate = DateTime.Now;
        private double _expectedBurnTime = 0;
        private DateTime _expectedBlowoutTime = DateTime.Now;

        public Marschall(int _id, string _brand, Address _address, string _registeringUser, double _expectedBurnTime)

        {
            this._id = _id;
            this._brand = _brand;
            this._address = _address;
            this._registeringUser = _registeringUser;
            this._registrationDate = DateTime.Now;
            this._expectedBlowoutTime = _expectedBlowoutTime.AddHours(_expectedBurnTime);
        }

        public void PrintInfo()
        { 
            Console.WriteLine("ID: {0}", _id);
            Console.WriteLine("Brand: {0}", _brand);
            Console.WriteLine("Address: {0}", _address);
            Console.WriteLine("Registering user: {0}", _registeringUser);
            Console.WriteLine("Date of registration: {0}", _registrationDate);
            Console.WriteLine("Expected burn time: {0}", _expectedBurnTime);
            Console.WriteLine("Expected blow out time: {0}", _expectedBlowoutTime);
        }
    }
}

