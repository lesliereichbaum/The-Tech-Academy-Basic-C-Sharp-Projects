using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPersonAssignment
{
    class Employee : Person, IQuittable
    {
        public void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        public void Quit(string firstName, string lastName)
        {
            Console.WriteLine(firstName + lastName + "quits");
        }
        public int ID { get; set; } //ID property with variable int - added from Person Assignment Project

        //Overloading operator ==
        public static Employee==(Employee employee, ID id)
            {
            employee.Employee.Equal(id);
            return employee; 
            }
           
    }
}
