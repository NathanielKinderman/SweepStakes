﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> SweepStakes = new Queue<Sweepstakes>();
        public Sweepstakes GetSweepstakes()
        {
             return SweepStakes.Dequeue();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            SweepStakes.Enqueue(sweepstakes);
        }

       





    }
}
