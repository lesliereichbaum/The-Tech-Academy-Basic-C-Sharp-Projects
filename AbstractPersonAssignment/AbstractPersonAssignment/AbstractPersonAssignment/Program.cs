using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace AbstractPersonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> thingsEmployee = new Employee<string>();
            thingsEmployee.things = new List<string> {"p","o" };
           
          
            Employee<int> numEmployee = new Employee<int>();
            numEmployee.things = new List<int> { 9, 22 };

          foreach (string element in thingsEmployee.things)
            {
                Console.WriteLine( thingsEmployee + "{}"); //not sure how to make string print 
            }

          foreach (int element in numEmployee.things)
            {
                Console.WriteLine(numEmployee); // not sure how to make int print 
            }

            //Employee myEmployee = new Employee();

            //myEmployee.firstName = "Sample";
            //myEmployee.lastName = "Student"; //myEmployee is an object, f/l name are properties; "setting" not "getting"

            //myEmployee.SayName();

            //IQuittable theyQuit = myEmployee;
            //theyQuit.Quit(myEmployee.firstName, myEmployee.lastName);


            ////Overload Operator: 
            //Employee emp1 = new Employee();  
            //emp1.Id = 1;
            //Employee emp2 = new Employee();
            //emp2.Id = 2;

            //Console.WriteLine(emp1 != emp2);
            //Console.ReadLine();

  
            


    }
}
}
