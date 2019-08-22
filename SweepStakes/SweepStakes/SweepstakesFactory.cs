using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class SweepstakesFactory 
    {
    
    public static ISweepstakesManager ChooseYourSweepstakesManagerStyle()
        {
            Console.WriteLine("Pick 'stack' or 'queue'");
            string thing = Console.ReadLine().ToLower();
            switch (thing)
            {
                case "stack":
                    return new SweepstakesStackManager();

                case "queue":
                    return new SweepstakesQueueManager();
                default:
                    return ChooseYourSweepstakesManagerStyle();

            }
            
        }

    }
}
