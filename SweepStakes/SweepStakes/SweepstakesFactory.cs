using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesFactory 
    {
    
        //method injection but how????
    //make a method and then use iSweepstakesMananger and then a swtich case for user to choose queue or stack
    public ISweepstakesManager ChooseYourSweepstakesManagerStyle()
        {
            Console.WriteLine("");
               string thing = Console.ReadLine().ToLower();
            switch (thing))
            {
                case "stack":
                    return new SweepstakesStackManager();

                case "queue":
                    return new SweepstakesQueueManager();


            }

        }

    }
}
