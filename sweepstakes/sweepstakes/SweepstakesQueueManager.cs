using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class SweepstakesQueueManager: ISweepstakesManager
    {

        //Member Variables
        

        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes();
            Contestant winner = sweepstakes.PickWinner();
            Convert.ChangeType(winner, typeof(Sweepstakes));
            return winner;
        }

        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }

        //Properties

        //Member Methods

    }
}
