using System;
using System.Collections.Generic;

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

            //Attempt at overloading operators 
            Employee employee = new Person();
            employee.ID = new List<ID>();
            employee.Person = "Leslie";
            employee == IDi;

        }
    }
}
