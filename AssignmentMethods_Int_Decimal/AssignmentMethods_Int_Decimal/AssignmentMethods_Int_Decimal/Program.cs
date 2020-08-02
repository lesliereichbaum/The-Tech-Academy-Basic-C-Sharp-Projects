using System;

namespace AssignmentMethods_Int_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {

            Integer firstInt = new Integer();
            int newInt = 8;
            int result = firstInt.AddInteger(newInt);
            Console.WriteLine(result)


             Integer secInt = new Integer();
            decimal newDec = 1;
            decimal result = secInt.AddInteger(newDec);
            Console.WriteLine(result)
      

            //ADD 
            Console.WriteLine("Type a number into console");
            int firstIntAdd = Convert.ToInt32(Console.ReadLine());

            int addThis = Integer.AddInteger(firstIntAdd);
            Console.WriteLine("Your number plus 5" + addThis);
        }
    }
}
