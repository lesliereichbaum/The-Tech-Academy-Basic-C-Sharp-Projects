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
            Console.WriteLine("Type Your name " + SayName);
            Console.ReadLine();

        }
    }
}
