using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX08
{
    public class Customer
    {
        public string Firstname;
        public string Lastname;
        private int _Age;
        private bool _IsQualified;
        public string Address;
        public string Description;

        public Customer(string firstname, string lastname, int age)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this._Age = age;

            this._IsQualified = age >= 18;
        }
        /*
        public int GetAge()
        {
            return _Age;
        }

        public void setAge(int age)
        {
            _Age = age;
            _IsQualified = age >= 18;
        }
        */

        public int Age
        {
            get { return _Age; }
            set
            {
                _Age = value;
                _IsQualified = Age >= 18;
            }
        }

        /*
        public bool getIsQualified()
        {
            return _IsQualified;
        }
        */

        public bool IsQualified
        {
            get
            {
                return _IsQualified;
            }
        }
        /*
        public string GetFullname()
        {
            return Firstname + " " + Lastname
        }
        */

        public string Fullname
        {
            get
            {
                return Firstname + " " + Lastname;
            }
        }
    }
}
