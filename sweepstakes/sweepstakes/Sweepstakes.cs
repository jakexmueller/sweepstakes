using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Sweepstakes //Use Dictionary Data Structure
    {

        //Member Variables
        private Dictionary<int, Contestant> contestantDictionary = new Dictionary<int, Contestant>();

        //Contructor
        public Sweepstakes(string stringName)
        {

        }

        //Properties

        //Member Methods
        public Contestant CreateContestant()
        {
            Contestant contestant = new Contestant();
            contestant.GetFirstName();
            contestant.GetLastName();
            contestant.GetEmail();
            contestant.GetRegistrationNumber();
            return contestant;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestantDictionary.Add(contestant.RegistrationNumber, contestant);
        }

        //public string PickWinner()
        //{

        //}

        public void PrintContestantInfo(Contestant contestant)
        {

        }

    }
}
