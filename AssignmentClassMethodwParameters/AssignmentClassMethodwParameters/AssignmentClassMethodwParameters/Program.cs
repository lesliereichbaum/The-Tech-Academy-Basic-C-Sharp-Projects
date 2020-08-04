using System;
using System.Security.Cryptography.X509Certificates;

namespace MethodwParameters
{
    class Program
    {
        public static int numberTwo { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Input one number and it will multiply by 10");
            int numberOne= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Put in another number, only if you want to.");
            string numberTwoStr = Console.ReadLine();

           
            //instantiated class below 
            MyClass firstNumber = new MyClass();
            int myReturn = firstNumber.MultTwoInt(numberOne, numberTwo);
            int myReturn1 = firstNumber.MultTwoInt(numberOne);
            Console.WriteLine(myReturn);

            // if-else statement to check if string is empty 
            int MyReturn = 0;

            if (numberTwoStr == "")
            {
                MyReturn = firstNumber.MultTwoInt(numberOne);
            }

            else
            {
                int numberTwo = Convert.ToInt32(numberTwoStr);
                myReturn = firstNumber.MultTwoInt(numberOne, numberTwo);
            }
        }
    }
}
