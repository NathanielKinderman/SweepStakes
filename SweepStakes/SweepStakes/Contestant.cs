using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant
    {
        //member variables
        //first name, last name, email, Address Registration number
        public string FirstName;
        public string LastName;
        public string Email;
        public string Address;
        public int RegistrationNumber;


        //constructor
        public Contestant()
        {       
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
        

       

    }

   

}
