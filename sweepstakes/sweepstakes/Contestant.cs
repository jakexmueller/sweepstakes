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
        int registrationNumber = 0;

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

        public void GetFirstName()
        {
            Console.WriteLine("What is your first name?");
            FirstName = Console.ReadLine();
        }
        public void GetLastName()
        {
            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();
        }
        public void GetEmail()
        {
            Console.WriteLine("What is you eMail address?");
            EMailAddress = Console.ReadLine();
        }
        public void GetRegistrationNumber()
        {
            RegistrationNumber += 1;
            Console.WriteLine("Your registration number is " + RegistrationNumber + ". Don't forget it!");
        }
    }
}
