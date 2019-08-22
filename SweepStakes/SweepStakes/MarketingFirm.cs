using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        //Marking firm class = game class

        //member variable
        ISweepstakesManager manager;


        //constructor
        public MarketingFirm(ISweepstakesManager user)
        {
            manager = user;
        }


        //member methods
        public void CreateSweepstakes()
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Enter a name for your sweepstakes:");
                Sweepstakes sweepstakes = new Sweepstakes(Console.ReadLine());
                for (int i = 0; i < 2; i++)
                {
                    sweepstakes.RegisterContestant(new Contestant());
                }
                manager.InsertSweepstakes(sweepstakes);
            }
        }
        public void RunSweepstakes()
        {
            for (int i = 0; i < 5; i++)
            {                
                Sweepstakes sweep = manager.GetSweepstakes();
                string winner = sweep.PickWinner();
                Console.WriteLine(winner + " won " + sweep.name);
                Console.ReadLine();
            }
        }

    }
}
