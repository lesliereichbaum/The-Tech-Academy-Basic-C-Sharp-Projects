using System;

namespace Branching_Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("what is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "you have an awesome fav number." : "you do not have an awesome fav number.";

            Console.WriteLine(result);
            Console.ReadLine();

            //int roomTemperature = 70;
     

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("it is exactly room temp.");
            //}

            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("it is warmer than room temp");
            //}

            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("it is colder than room temp.");
            //}
            //else
            //{
            //    Console.WriteLine("uhhhhh...something went wrong.");
            //}

            //Console.ReadLine(); 

            //int currentTemperature = 80;
            //int roomTemperature = 70;


            //string comparisionResult = currentTemperature == roomTemperature ? "it is room temp." : "it is not room temp,";

            //Console.WriteLine(comparisionResult);
            //Console.ReadLine();

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temp.");
            //}
            //else if  (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("it is warmer than room temp.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("room temp is warmer than current temp.");
            //}
            //else
            //{
            //    Console.WriteLine("it is not exactly room temp.");
            //}

            //Console.ReadLine();
        }
    }
}
