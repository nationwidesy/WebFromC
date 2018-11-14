using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationCWebForm.App_Code
{
    public class Address
    {
        //auto getter and setter --> propfull --> press Tab twice
        private int _addID;

        public int AddressID
        {
            get { return _addID; }
            set { _addID = value; }
        }
        private int _personId;

        public int PersonID
        {
            get { return _personId; }
            set { _personId = value; }
        }
        private string _address;

        public string Address1
        {
            get { return _address; }
            set { _address = value; }
        }
        private string _city;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        private string _state;

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        private int _zip;

        public int Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

    }
}