using System;

namespace CarInsuranceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());
           

            Console.WriteLine("Have you ever had a DUI? Answer yes or no");
            string safeDriver = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            if (userAge >= 16 && safeDriver != "yes" && speedingTickets <= 3)
            {
                Console.WriteLine("You have qualified. Congratulations");
            }
            else
            {
                Console.WriteLine("You do not meet our qualifications. Thank you for your time.");
            }
           

        }
    }
}
