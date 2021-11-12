using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostMyLighterGroup4
{
    class Address
    {
        private string _street;
        private string _postCode;
        private string _postTown;

        public string Street
        {
            get
            {
                return _street;
            }
            set 
            {
                _street = value;
            }
        }

        public string PostCode
        {
            get
            {
                return _postCode;
            }
            set
            {
                _postCode = value;
            }
        }

        public string postTown
        {
            get 
            {
                return _postTown;
            }
            set
            {
                _postTown = value;
            }
        }

        public Address(string street, string postCode, string postTown)
        {
            this._postTown = street;
            this._postCode = postCode;
            this._postTown = postTown;
        }
    }
}
