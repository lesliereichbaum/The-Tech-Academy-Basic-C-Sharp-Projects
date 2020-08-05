using System;
using System.Security.Cryptography.X509Certificates;

namespace PersonAssignment
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Employee SayName = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            
            };
            //Console.WriteLine("Type Your name " + SayName);
            //Console.ReadLine();

            string value = "Wednesday";

            DayOfWeek week;
         
            try
            {
                week = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfWeek), value);
                Console.WriteLine("Enter the current day of the week ");
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter an actual day of the week.");

            }
       
        }
    }
}
