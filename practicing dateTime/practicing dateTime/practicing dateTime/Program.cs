using System;
using System.IO;

namespace practicing_dateTime
{
    public class Program
    {
        class Employee
        {
            public DateTime TodaysDate { get; set; }
        }
      static void Main()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("NOW: " + now);

            Employee employee = new Employee() { TodaysDate = now };
            Console.WriteLine("TODAY\'s DATE: " + employee.TodaysDate);

            Console.WriteLine("Give me a number and I will show you the exact time in that many hours.");
            int userInput = Convert.ToInt32(Console.ReadLine());
           int hours = userInput;
            TimeSpan TimeSpan = new TimeSpan(int hours);
            Console.WriteLine(TimeSpan);
        }
        
        
    }

    internal class PlaceInfo
    {
        private string placeName;

        public PlaceInfo(string placeName)
        {
            this.placeName = placeName;
        }

        public int OriginalName { get; internal set; }
    }
}
