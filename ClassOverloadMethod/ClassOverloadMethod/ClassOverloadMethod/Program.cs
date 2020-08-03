using System;

namespace ClassOverloadMethod
{
    class Program
    {
        private static readonly int divInt;


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number so that I can divide it by 2");
            int divInt = Convert.ToInt32(Console.ReadLine());
          
         
            //instantiated class
            MyClass vClass = new MyClass();
            vClass.VMethod(divInt);
        }
    }
}
