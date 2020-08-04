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
        public void Quit (string firstName, string lastName)
        {
            Console.WriteLine(firstName + lastName + "quits");
        }
    }
}
