using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Contestant
    {

        //Member Variables
        string firstName;
        string lastName;
        string eMailAddress;

        //Constructor
        public Contestant()
        {

        }

        //Properties
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string EMailAddress
        {
            get
            {
                return eMailAddress;
            }
            set
            {
                eMailAddress = value;
            }
        }


        //Member Methods

        public void SetFirstName()
        {
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
        }
        public void SetLastName()
        {
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
        }
        public void SetEmail()
        {
            Console.WriteLine("What is you eMail address?");
            eMailAddress = Console.ReadLine();
        }

    }
}
