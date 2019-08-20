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



        //member methods
        public string GetContestantInfo()
        {
            Console.WriteLine("Please enter your First Name:");
            FirstName = Console.ReadLine();
            

            Console.WriteLine("Please enter your Last Name:");
            LastName = Console.ReadLine();

            Console.WriteLine("Please enter your Email Address:");
            Email = Console.ReadLine();

            Console.WriteLine("Please enter your Home Address:");
            Address = Console.ReadLine();

            //link a random number generator to get registration Number?
            Console.WriteLine("Heres your Registration Number:");
            // RegistrationNumber = RandomNumberGenerator(1, 100);
            // return;

            // A dictionary should be here

        }

         public int RandomNumberGenerator(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max); 



        }

    }

   

}
