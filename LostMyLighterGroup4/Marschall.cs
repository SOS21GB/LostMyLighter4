using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4
{
    class Marschall
    {
        private static List<Marschall> marschalls = new List<Marschall>();

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
            this._expectedBurnTime = _expectedBurnTime;
            this._expectedBlowoutTime = _expectedBlowoutTime.AddHours(_expectedBurnTime);

            marschalls.Add(this);
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



        //Properties
        //List
        static public List<Marschall> Marschalls
        {
            get { return marschalls; }
        }

        //Fields
        public int ID
        {
            get { return _id; }
        }
        public string Brand
        {
            get { return _brand; }
        }
        public Address Address
        {
            get { return _address; }
        }
        public string RegisteringUser
        {
            get { return _registeringUser; }
        }
        public DateTime RegistrationDate
        {
            get { return _registrationDate; }
        }
        public double ExpectedBurnTime
        {
            get { return _expectedBurnTime; }
        }
        public DateTime ExpectedBlowoutTime
        {
            get { return _expectedBlowoutTime; }
        }
    }
}

