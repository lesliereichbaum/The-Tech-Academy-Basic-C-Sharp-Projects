using System;

namespace ExceptionHandlingTryCatch
{
    class Program
    {
        public static object birthYear { get; private set; }

        public TimeSpan YearsfromAge { get; set; }

        static void Main(string[] args)
        {

            DateTime now = DateTime.Now;
            Console.WriteLine("NOW:" + now);

            Console.WriteLine("How old are you?");
            int personAge = (int)Convert.ToDouble(Console.ReadLine());
            double years = personAge;
            TimeSpan span = birthYear.Subtract(personAge);
            now = now.SubtractYears(personAge);
            Console.WriteLine(now);

        }


    }
}
