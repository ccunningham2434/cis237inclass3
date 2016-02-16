using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    // Abstract classes cannot be created as a new instance.
    abstract class Employee
    {
        //Backing fields
        protected string _firstName;
        protected string _lastName;

        //properties for the backing fields
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }


        //Override method that will print all of the fields
        //It overrides the default ToString that every object gets for free!
        public override string ToString()
        {
            return this._firstName + " " + this._lastName;
        }

        //3 Parameter constructor
        public Employee(string firstName, string lastName)
        {
            //Assign the passed in values to the fields
            this._firstName = firstName;
            this._lastName = lastName;
        }

        //Default constructor
        public Employee()
        {
            //Lets just leave this blank
        }
    }
}
