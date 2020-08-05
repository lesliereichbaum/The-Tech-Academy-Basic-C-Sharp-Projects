using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPersonAssignment
{
    public class Employee <T>
    {
        public List <T> things { get; set; } // T instead of "strings"

    }

    //class Employee : Person, IQuittable
    //{
    //    public int Id { get; set; } //created property called Id

    //    public static bool operator==(Employee employee1, Employee employee2)
    //    {
    //        bool result;
    //        if (employee1.Id == employee2.Id) // Overload operator to check if ==
    //        {
    //            result = true;
                
    //        }
    //        else
    //        {
    //            result = false; 
    //        }
    //        return result;
    //    }

    //    public static bool operator!=(Employee employee1, Employee employee2) //Overload operator to check !=
    //    {
    //        bool result;
    //        if (employee1.Id != employee2.Id)
    //        {
    //            result = true;
           
    //        }
    //        else
    //        {
    //            result = false; 
               
    //        }
    //        return result; 
    //    }

    //    public void SayName()
    //    {
    //        Console.WriteLine(firstName + " " + lastName);
    //    }
    //    public void Quit(string firstName, string lastName)
    //    {
    //        Console.WriteLine(firstName + lastName + "quits");
    //    }
      
    //    public int ID { get; set; } //ID property with variable int - added from Person Assignment Project
           
    //}

    
    
    
}
