using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Sweepstakes
    {   //member variables


        //constructors
        Dictionary<string, Contestant> contestants;
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<string, Contestant>();
            




        }
        //member methods


        void RegisterContestant(Contestant contestant)
        {
            int x = contestants.Count;
            contestant.GetContestantInfo();
            contestant.ContestantRegistrationNumberGenerator(1, 1000);
            contestants.Add("jhbjhb", new Contestant());

        }



        String PickWinner()
        {//random number generator for picking winner
            // number linked to dictonary

            contestant.count.RandomNumberGenerator(1, contestants.count);
            //move generator here .contestant 

            


        }
        //void PrintContestantInfo(Contestant contestant)

        public int RandomNumberGenerator(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);



        }


    }
}
