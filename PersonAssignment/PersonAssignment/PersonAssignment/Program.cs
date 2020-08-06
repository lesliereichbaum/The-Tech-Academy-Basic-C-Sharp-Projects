using System;
using System.Security.Cryptography.X509Certificates;

namespace PersonAssignment
{
   public class Program
    {
        public static void Main(string[] args)
        {
           double Number = 2.5;
            Number myObj = new Number();
            Console.WriteLine(Number);

            Employee SayName = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            
            };
            //Console.WriteLine("Type Your name " + SayName);
            //Console.ReadLine();

      
         
            try
            {
            
                Console.WriteLine("Enter the current day of the week ");
               string input = Console.ReadLine();
             DaysOfTheWeek day = Enum.Parse<DaysOfTheWeek>(input);
               
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter an actual day of the week.");

            }
       
        }
    }
}
