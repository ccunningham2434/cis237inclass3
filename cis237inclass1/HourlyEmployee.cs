using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class HourlyEmployee : Employee
    {
        // Constants for the hour per week, and the weeks for year.
        private const decimal _HOURS_PER_WEEK = 40;
        private const decimal _WEEKS_PER_YEAR= 52;

        // Create a backing field for the hourly rate
        private decimal _hourlyRate;

        // Properties
        //
        public decimal Salary
        {
            get
            {
                return this._hourlyRate * _WEEKS_PER_YEAR * _HOURS_PER_WEEK;
            }
        }

        // Methods
        //
        public override string ToString()
        {
            return base.ToString() + " " + this._hourlyRate.ToString("c");
        }

        // Constructors
        //
        public HourlyEmployee(string firstName, string lastName, decimal hourlyRate) : base(firstName, lastName)
        {
            _hourlyRate = hourlyRate;
        }

        // This is the override for the abstract method we have declared in the...
        // ...employee class. We are required to provide an implementation since it...
        // ...was declared abstract in the parent 'Employee'.
        public override string GetFormattedSalary()
        {
            return this.Salary.ToString("C");
        }
    }

}
