using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PersonAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*public int Id { get; set; } *///created property called Id

            var employee = new List<Employee>();
            employee.Add(new Employee ("Joe", "Shmoe", 99));
            employee.Add(new Employee("Joe" , "Walsh", 88));
            employee.Add(new Employee("Alyssa", "Lollipop", 77));
            employee.Add(new Employee("Anna", "Fruitloops", 66));
            employee.Add(new Employee("Nick" ,"Tootsiepop", 55));
            employee.Add(new Employee("Calvin" , "Marshmallow", 44));
            employee.Add(new Employee("Sonny", "Moon", 33));
            employee.Add(new Employee("Oliver",  "Ollie", 22));
            employee.Add(new Employee("Edith", "Pizza", 11));
            employee.Add(new Employee("Dougie" , "Jones", 00));

            foreach (Employee emp in new List)
            {
                Console.WriteLine(firstName = "Joe");
            }

            //double Number = 2.5;
            // Number myObj = new Number();
            // Console.WriteLine(Number);

            // Employee SayName = new Employee()
            // {
            //     FirstName = "Sample",
            //     LastName = "Student"

            // };
            //Console.WriteLine("Type Your name " + SayName);
            //Console.ReadLine();



            //try
            //{

            //    Console.WriteLine("Enter the current day of the week ");
            //   string input = Console.ReadLine();
            // DaysOfTheWeek day = Enum.Parse<DaysOfTheWeek>(input);

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Please enter an actual day of the week.");

            //}

        }
    }
}
