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
        private int _postCode;
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

        public int PostCode
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

        public string PostTown
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

        public Address(string street, int postCode, string postTown)
        {
            this._street = street;
            this._postCode = postCode;
            this._postTown = postTown;
        }
    }
}
