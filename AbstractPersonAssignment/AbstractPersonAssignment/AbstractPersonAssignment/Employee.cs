using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPersonAssignment
{
    class Employee : Person
    {
        public void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
