using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    // Abstract classes cannot be created as a new instance. | Impliments the IEmployee interface.
    abstract class Employee : IEmployee
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

        //***********************

        // An abstract method MUST have no method body. Hence the ; at the end
        // An abstract method MUST be overrriden in all child classes.
        public abstract string GetFormattedSalary();

        // A virtual method MUST have a method body even if it is empty.
        // A virtual method CAN, but does not have to be overridden in the children classes.
        public virtual string GetLastNameFirstName()
        {
            return this.LastName + ", " + this.FirstName;
        }

        //***********************

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
