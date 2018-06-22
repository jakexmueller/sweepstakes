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
        public void CreateContestant()
        {

        }

        public void RegisterContestant(Contestant contestant)
        {

            int count = 1;
            contestantDictionary.Add(count + 1, contestant);
            Console.WriteLine(contestantDictionary);

        }

        //public string PickWinner()
        //{

        //}

        public void PrintContestantInfo(Contestant contestant)
        {

        }

    }
}
