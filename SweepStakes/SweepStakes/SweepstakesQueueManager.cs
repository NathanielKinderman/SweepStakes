using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesQueueManager
    {
        public void Queue()
        {
            //ISweepstakesManager interface 
            //queue data 
            //member variables
            Queue<int> SweepStakes = new Queue<int>();
            SweepStakes.Enqueue(1);
            SweepStakes.Enqueue(2);
            SweepStakes.Enqueue(3);

            

            //constructor




            //member methods
            Console.WriteLine("Sweepstakes that are in queue:");
            foreach (int number in SweepStakes)
            {
                Console.WriteLine(number);


            }

            int startOfQueue = SweepStakes.Dequeue();
            SweepStakes.Enqueue(3);

            Console.WriteLine("Sweepstakes in queue after Dequeue and Enqueue(3):");
            foreach (int number in SweepStakes)
            {

                Console.WriteLine(number);

            }



        }





    }
}
