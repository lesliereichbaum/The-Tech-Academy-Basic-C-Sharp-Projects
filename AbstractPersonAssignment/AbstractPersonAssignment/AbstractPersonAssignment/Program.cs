using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace AbstractPersonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee();

            myEmployee.firstName = "Sample";
            myEmployee.lastName = "Student"; //myEmployee is an object, f/l name are properties; "setting" not "getting"

            myEmployee.SayName();

            IQuittable theyQuit = myEmployee;
            theyQuit.Quit(myEmployee.firstName, myEmployee.lastName);


            //Overload Operator: 
            Employee emp1 = new Employee();  
            emp1.Id = 1;
            Employee emp2 = new Employee();
            emp2.Id = 2;

            Console.WriteLine(emp1 != emp2);
            Console.ReadLine();

  
            


    }
}
}
