using System;
using System.Collections.Generic;

class Program
{ 
        static void Main(string[] args)
        {
        Console.WriteLine("Pick a number to divide each number in this list by.");


        List<int> numberList = new List<int>();
        numberList.Add(2);
        numberList.Add(4);
        numberList.Add(6);
        numberList.Add(8);
        numberList.Add(10);
        numberList.Add(12);
        numberList.Add(14);
   
        foreach (int number in numberList)
        {
            Console.WriteLine(number);
        }
       
        try
        {
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing....");
            
            foreach (int number in numberList)
            {
                int result = number / numberTwo;
                Console.WriteLine(result);
            }
           
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number.");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero");
        }
        //GENERIC ERROR MESSAGE
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


        Console.WriteLine("Now outside the try/catch block. Continuing program execution");

    Console.ReadLine();
    }
    }

