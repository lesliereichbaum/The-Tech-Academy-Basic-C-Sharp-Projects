﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesandDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            ////Console.WriteLine("Your favorite number is: " + favoriteNumber);
            ////Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursworked = 42;
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.30980989;

            float secondsLeft = 2.62f;

            short temperatureOnMars = -341;

            string myName = "leslie";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            //Another example of Casting variable/data types:

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();


            Console.WriteLine(questionMark);
            Console.ReadLine();
        }
    }
}
