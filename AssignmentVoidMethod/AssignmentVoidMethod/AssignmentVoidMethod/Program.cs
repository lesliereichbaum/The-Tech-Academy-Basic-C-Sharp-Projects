using System;

namespace AssignmentVoidMethod
{
    class Program
    {
       public static void Main(string[] args)
        {
            //Console.WriteLine("Type a number to add to my number");
            int firstNumb = 100;

            //Console.WriteLine("Here is my other number.");
            int secNumb = 4;

            //instantiated class 
            MyClass vClass = new MyClass();
            //calling method in class and passing two numbers
            vClass.VMethod(6, 11);
            //calling method in class and specifying parameters by name
           vClass.VMethod(firstNumb, secNumb);
            

        }
    }
}
