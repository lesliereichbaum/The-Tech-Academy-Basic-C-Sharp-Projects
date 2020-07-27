using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            //Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            // Console.ReadLine();

            //Questions 
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Your name is: " + userName);

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("The course you are on is: " + courseName);

            Console.WriteLine("What page number are you on?");
            int page = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The page you are on is: " + page);

            Console.WriteLine("Do you need help with anything? " +
                "Please Answer \"true\" or \"false\"");
            bool help = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("You answered: " + help);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine("Thank you for sharing: " + experiences);

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("I will contemplate: " + feedback);

            Console.WriteLine("How many hours did you study?");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You studied:" + hours + "hours");

            Console.WriteLine("Thank you for your responses. An Instructor will respond to this shortley. Have a great day!");

  



        }
    }
}
