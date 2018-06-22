using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringName = "Jake";
            Sweepstakes sweepstakes = new Sweepstakes(stringName);
            Contestant contestant = null;
            sweepstakes.RegisterContestant(contestant);
            Console.ReadLine();

        }
    }
}
