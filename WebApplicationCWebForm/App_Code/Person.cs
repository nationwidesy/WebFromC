using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationCWebForm.App_Code
{
    public class Person
    {

        //auto getter and setter --> propfull --> press Tab twice
        private int myAge;

        public int Age
        {
            get { return myAge; }
            set { myAge = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private string _middleInitial;

        public string MiddleInitial
        {
            get { return _middleInitial; }
            set { _middleInitial = value; }
        }
        private string mName;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
        private string mAddress;

        public string Address
        {
            get { return mAddress; }
            set { mAddress = value; }
        }

        private string mCity;

        public string City
        {
            get { return mCity; }
            set { mCity = value; }
        }
        private string mState;

        public string State
        {
            get { return mState; }
            set { mState = value; }
        }
        private int mZip;

        public int Zip
        {
            get { return mZip; }
            set { mZip = value; }
        }


        public string Company
        {
            //read only property
            get { return "Nationwide Insurance"; }
        }

        private string mNotes = string.Empty;
        public string showNotes
        {
            get { return mNotes; }
        }

        public string Notes
        {
            set { mNotes = value; }
        }

        
        public string FullName
        {
            get { return _firstName + " " + _lastName; }
        }

    }
}
