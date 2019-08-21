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
        Dictionary<int, Contestant> contestants;
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            




        }
        //member methods


        void RegisterContestant(Contestant contestant)
        {
            int Contestantregisteration = contestants.Count;
            contestant.GetContestantInfo();
            
            contestants.Add(Contestantregisteration, contestant);

        }



        String PickWinner()
        {//random number generator for picking winner
            // number linked to dictonary
            //how to accesss diction match the key store in a variable the number that generated, get the value at matching key
            RandomNumberGenerator(1, contestants.Count);
            //move generator here .contestant 
            //return name of the winner
            return ;


        }
        //void PrintContestantInfo(Contestant contestant)

        public int RandomNumberGenerator(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);



        }


    }
}
