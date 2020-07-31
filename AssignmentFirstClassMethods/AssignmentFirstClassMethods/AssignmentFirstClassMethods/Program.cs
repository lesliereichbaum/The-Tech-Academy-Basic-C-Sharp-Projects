using System;
using System.Diagnostics.CodeAnalysis;

namespace AssignmentFirstClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {

           //ADD 
            Console.WriteLine("Type a number");
            int inputAdding = Convert.ToInt32(Console.ReadLine());
           
            int addingtest = Integer.AddFive(inputAdding);
            Console.WriteLine("Your number plus five is " + addingtest);

            //MULT 
                Console.WriteLine("Type a number");
                int inputMult = Convert.ToInt32(Console.ReadLine());

                int multiplicationtest = Integer.MultSix(inputMult);
            Console.WriteLine("your number times six is " + multiplicationtest);
            //Sub
            Console.WriteLine("Type a number");
            int inputDiv = Convert.ToInt32(Console.ReadLine());

            int subtest = Integer.SubHundred(10);
            Console.WriteLine("your number subtracted by 100 is  "+ subtest);
            

        }

         
    }
}


    