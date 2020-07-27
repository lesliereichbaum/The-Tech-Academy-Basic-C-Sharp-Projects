using Microsoft.VisualBasic.FileIO;
using System;

namespace OperationsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Gimmie a number and watch me multiply it by 50");
            //int firstInput = Convert.ToInt32(Console.ReadLine());
            //int total = firstInput * 50; 
            //Console.WriteLine("your number times 50 is: " + total);


            //Console.WriteLine("Give me a number and I will add 25");
            //int thisInput = Convert.ToInt32(Console.ReadLine());
            //int total = thisInput + 25;
            //Console.WriteLine("your number plus 25 is: " + total);


            //Console.WriteLine("Give me a number and I will divide by 12.5");
            //decimal divideInput = Convert.ToInt32(Console.ReadLine());
            //decimal total = divideInput / 12.5m;
            //Console.WriteLine("your number divided by is: " + total);

            //Console.WriteLine("Give me a number. If it is greater than 50, it will be true. If not, it will be false");
            //int TorFinput = Convert.ToInt32(Console.ReadLine());
            //bool trueFalse = TorFinput > 50;
            //Console.WriteLine(trueFalse.ToString());
            //Console.ReadLine();

            Console.WriteLine("Give me a number and I will divide it by 7 and give you the remainder.");
            int remainderinput = Convert.ToInt32(Console.ReadLine());
            int total = remainderinput %  7;
            Console.WriteLine("The remainder is " + total);

        }
    }
}
