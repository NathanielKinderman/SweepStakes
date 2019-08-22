using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Sweepstakes
    {   //member variables
        public string name;

        //constructors
        Dictionary<int, Contestant> contestants;
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            this.name = name;
        }
        //member methods


        public void RegisterContestant(Contestant contestant)
        {
            int Contestantregisteration = contestants.Count;
            contestant.RegistrationNumber = Contestantregisteration;
            contestant.GetContestantInfo();            
            contestants.Add(Contestantregisteration, contestant);

        }



        public string PickWinner()
        {
            // number linked to dictonary
            //how to accesss dictonary match the key store in a variable the number that generated, get the value at matching key
            int winner = RandomNumberGeneratorForWinner(1, contestants.Count);
            Contestant cont = contestants[winner];
            return cont.FirstName;

        }


        public void PrintContestantInfo(Contestant contestant)
        {
            // Writing first and last name
            Console.WriteLine(contestant); 
        }








        public int RandomNumberGeneratorForWinner(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);



        }


    }
}
