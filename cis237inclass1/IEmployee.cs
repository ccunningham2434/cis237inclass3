//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace cis237inclass3
{
    // using namespace is only need if you inherit from another interace in a different namespace.
    interface IEmployee
    {
        // An interface contains only method declarations and properties.
        // There is no need to put an access modifier down because it will...
        // ...always be public. We are specifying only public methods and properties.

        // Any class that implements this interface must implement the following...
        // ...mehtods. Even if they are abstract with no method body.
        string GetFormattedSalary();

        // Any class that implements this interface must implement the following...
        // ...properties.
        string GetLastNameFirstName();

        string FirstName
        {
            get;
            set;
        }

        string LastName
        {
            get;
            set;
        }
    }
}
