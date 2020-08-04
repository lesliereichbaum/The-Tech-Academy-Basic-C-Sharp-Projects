using System;

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

        }
    }
}
