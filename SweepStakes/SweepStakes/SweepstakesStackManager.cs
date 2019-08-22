using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> SweepStakes = new Stack<Sweepstakes>();
        public Sweepstakes GetSweepstakes()
        {
            return SweepStakes.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            SweepStakes.Push(sweepstakes);
        }


       


    }

}
