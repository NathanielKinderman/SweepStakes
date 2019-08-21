using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesStackManager
    {
        //ISweepstakeManger interface
        //Stack data
        public void PushOnToStack()
        {

            //member variables
            Stack<int> SweepStakes = new Stack<int>();

            //constructor
            SweepStakes.Push(1);
            SweepStakes.Push(2);
            SweepStakes.Push(3);

            Console.WriteLine("SweepStakes in stack:");
            //member methods
            foreach ( int number in SweepStakes)
            {
                Console.WriteLine(number);

            }

            int topOfStack = SweepStakes.Pop();
            SweepStakes.Push(3);

            Console.WriteLine("SweepStakes in stack after Pop and Pusj(3):");
            foreach (int number in SweepStakes)
            {
                Console.WriteLine(number);

            }








        }

       


    }

}
