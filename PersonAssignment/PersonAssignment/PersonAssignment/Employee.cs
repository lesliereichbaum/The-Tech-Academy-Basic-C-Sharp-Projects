using System;
using System.Collections.Generic;
using System.Text;

namespace PersonAssignment
{
    public class Employee : Person // Employee class inherited Person class 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; } //ID property with variable int 
    
  
    public Employee(string firstName, string lastName, int iD)
    {
            FirstName = firstName;
            LastName = lastName;
            ID = iD;
    }

}
   public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
