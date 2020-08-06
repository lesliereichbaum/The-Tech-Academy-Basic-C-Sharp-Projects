using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PersonAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //var employee = new List<Employee>(); //used for foreach loop list (questiosn 1-2)

            List<Employee> employee = new List<Employee>();

            employee.Add(new Employee ("Joe", "Shmoe", 9));
            employee.Add(new Employee("Joe" , "Walsh", 8));
            employee.Add(new Employee("Alyssa", "Lollipop", 7));
            employee.Add(new Employee("Anna", "Fruitloops", 6));
            employee.Add(new Employee("Nick" ,"Tootsiepop", 5));
            employee.Add(new Employee("Calvin" , "Marshmallow", 4));
            employee.Add(new Employee("Sonny", "Moon", 3));
            employee.Add(new Employee("Oliver",  "Ollie", 2));
            employee.Add(new Employee("Edith", "Pizza", 1));
            employee.Add(new Employee("Dougie" , "Jones", 0));

            foreach (Employee emp in employee.Where(x => x.FirstName == "Joe")); //lambda 
            {
                Console.WriteLine(employee);
            }

            //foreach (Employee emp in employee)           //Searching employee with fname "joe" using foreach loop 
            //{
            //    if (emp.FirstName == "Joe")
            //    {
            //        var joeList = new List<Employee>();
            //        joeList.Add(emp);
            //    }
            //}



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
