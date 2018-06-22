﻿using System;
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
        Random random = new Random();
        int registrationNumber = 0;

        //Contructor
        public Sweepstakes(string stringName)
        {

        }

        //Properties
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
        public void SetRegistrationNumber()
        {
            registrationNumber += 1;
            Console.WriteLine("Your registration number is " + RegistrationNumber + ". Don't forget it!");
        }

        public Contestant CreateContestant()
        {
            Contestant contestant = new Contestant();
            contestant.SetFirstName();
            contestant.SetLastName();
            contestant.SetEmail();
            SetRegistrationNumber();
            return contestant;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestantDictionary.Add(RegistrationNumber, contestant);
        }

        public string PickWinner()
        {
            int winner = random.Next(1, contestant.RegistrationNumber);
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }

    }
}
