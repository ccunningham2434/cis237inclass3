using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    // use the colon to denote that this class inherits from the class listed after the colon.
    class SalaryEmployee : Employee
    {
        private decimal _salary;

        // Properties
        //
        public decimal Salary
        {
            get { return this._salary; }
        }

        // Constructors
        //
        /// <summary>
        /// 3 Paramater constructor that takes the following arguments
        /// </summary>
        /// <param name="_firstName">First Name of Employee</param>
        /// <param name="_lastName">Last Name of Employee</param>
        /// <param name="_salary">Yearly Salary the Employee earns</param>
        public SalaryEmployee(string firstName, string lastName, decimal salary) : base(firstName, lastName)
        {
            // assign the passed in salary to the class level one. The first and last names that 
            // ...were passed in are assigned by the parent's constructor.
            _salary = salary;
        }

        /// <summary>
        /// Print out the information of the class in a readable format
        /// </summary>
        /// <returns>String consiting of first name, last name, and _salary</returns>
        public override string ToString()
        {
            // base.ToString() calls the method of the parent class.
            // We can get a full string by adding onto the parent's ToString method.
            return base.ToString() + " " + Salary.ToString("c");
        }

    }

}
