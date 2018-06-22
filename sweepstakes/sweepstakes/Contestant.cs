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
        int registrationNumber;

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
        public int RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
            set
            {
                registrationNumber = value;
            }
        }

        //Member Methods
    }
}
