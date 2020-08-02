using System;
using System.Text.Encodings.Web;

namespace AssignmentMethods_Int_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Method 
            Integer firstInt = new Integer();
            int newInt = 8;
            int result = firstInt.AddInteger(newInt);
            Console.WriteLine(result);

            //Second Method 
             Integer secInt = new Integer();
            decimal newDec = 5.5m;
            decimal decResult = secInt.AddInteger(newDec);
            Console.WriteLine(decResult);

            //Third Method 
            Integer thirdInt = new Integer();
            string newMult = "10";
            int multResult = thirdInt.AddInteger(newMult);
            Console.WriteLine(multResult);
      

        }
    }
}
