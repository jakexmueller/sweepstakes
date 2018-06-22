using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    interface ISweepstakesManager
    {

        //Member Variables

        //Properties

        //Member Methods
        void InsertSweepstakes(Sweepstakes sweepstakes);

        Sweepstakes GetSweepstakes();
    }
}
