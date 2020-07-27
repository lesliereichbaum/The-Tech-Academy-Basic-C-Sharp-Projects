using System;

namespace Step89Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Annonymous Income Comparison Program");
            Console.WriteLine("Person 1");

            Console.WriteLine("What is your Hourly Rate?");
            int ratePerson1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many hours do you work each week?");
           int hoursPerson1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");

            Console.WriteLine("What is your Hourly Rate?");
            int ratePerson2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many hours do you work each week?");
            int hoursPerson2 = Convert.ToInt32(Console.ReadLine());

            
            int total1 = ratePerson1 * hoursPerson1 * 52;
            Console.WriteLine("Person 1's annual salary is: " + total1);

            int total2 = ratePerson2 * hoursPerson2 * 52;
            Console.WriteLine("Person 2's annual salary is: " + total2);

            if (total1 > total2) {

                Console.WriteLine("Person 1 makes more money than Person 2");
            }
            else
            {
                Console.WriteLine("Person 2 makes more money than Person1");
            }
            
        }
    }
}
