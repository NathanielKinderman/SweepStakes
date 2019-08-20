using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Sweepstakes
    {   //Dictonary data
        Dictionary<string, Contestant> contestants;
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<string, Contestant>();
            //contestants.Add("jhbjhb", new Contestant());
        }


        void RegisterContestant(Contestant contestant)
        {
            GetContestantInfo();
            RandomNumberGenerator(1,1000);

        }



        //String PickWinner()//random number generator for picking winner



        //void PrintContestantInfo(Contestant contestant)




    }
}
