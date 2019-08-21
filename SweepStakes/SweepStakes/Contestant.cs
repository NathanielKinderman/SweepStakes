using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Contestant
    {
        //member variables
        //first name, last name, email, Address Registration number
        string FirstName;
        string LastName;
        string Email;
        string Address;
        string RegistartionNumber;


        //constructor
        public Contestant()
        {
            GetContestantInfo();
        }


        //member methods
        public void GetContestantInfo()
        {
            Console.WriteLine("Please enter your First Name:");
            FirstName = Console.ReadLine();
            

            Console.WriteLine("Please enter your Last Name:");
            LastName = Console.ReadLine();

            Console.WriteLine("Please enter your Email Address:");
            Email = Console.ReadLine();

            Console.WriteLine("Please enter your Home Address:");
            Address = Console.ReadLine();

        }
        //contestant count instead of random number generator
         public int ContestantRegistrationNumberGenerator(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

       

    }

   

}
