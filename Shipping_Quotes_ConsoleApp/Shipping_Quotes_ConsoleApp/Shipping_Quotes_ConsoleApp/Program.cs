using System;
using System.Runtime.InteropServices;

namespace ShippingQuote_BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //Package WEIGHT
            Console.WriteLine("Please enter the package weight.");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight < 50)
            {
                Console.WriteLine("Please answer the following questions about l, w, and h.");
            }


            else if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
        
            //Package Width, Height, and Length

            Console.WriteLine("Please enter the package width.");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height.");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length.");
                int packageLength = Convert.ToInt32(Console.ReadLine());


                int dimension = packageLength * packageWidth * packageHeight;
      

            if (dimension > 125000)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }

            int threeDimensions = packageLength * packageWidth * packageHeight * packageWeight / 100;
            Console.WriteLine("Your estimated total for shipping this package is: " +" $" +  threeDimensions);
            Console.ReadLine(); 

        }
    }
}
