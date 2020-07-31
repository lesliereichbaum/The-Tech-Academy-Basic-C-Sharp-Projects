using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;

class Program
    {
        static void Main(string[] args)
        {

        //PART ONE 

        //Console.WriteLine("Type: \"I like\" into the console");
        //string iLike = Console.ReadLine();

        //string[] jokeArray = { "pizza", "cookies", "ice cream", "donuts" };


        //for (int i = 0; i < jokeArray.Length; i++)
        //{

        //    jokeArray[i] = iLike + " " + jokeArray[i];
        //}

        //for (int i = 0; i < jokeArray.Length; i++)
        //{
        //    Console.WriteLine(jokeArray[i]);
        //}
        //Console.ReadLine();

        //INFINITE LOOP parts 2 and 3 and 4

        //Console.WriteLine("Click the \"Enter \"button");
        //Console.ReadLine();


        //do
        //{
        //    iLike += " these, too. They are yummy.";
        //    Console.WriteLine(iLike);
        //}
        ////while (true)
        ////{
        ////INFINITE LOOP CONDITION 
        ////}

        //while (jokeArray.Length < 2);
        //{

        //}

        //Console.ReadLine();

        //// PART 5 

        //for (int i = 0; i <= 12; i = i + 3)
        //{
        //    Console.WriteLine(i);
        //}

        ////PARTs 6, 7, and 8

        //Console.WriteLine("Challenge: see if you can guess a place on this mystery list.");

        //List<string> VacationList = new List<string>();
        //VacationList.Add("Hawaii");
        //VacationList.Add("Tokyo");
        //VacationList.Add("Yosemite");
        //VacationList.Add("Paris");
        //string SummerVacation = Console.ReadLine();

        //for (int i =0; i < VacationList.Count; i++)
        //{
        //    if (VacationList[i] == SummerVacation)
        //    {
        //        Console.WriteLine("Congrats! You found the index of this list, it' is " + i);
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Sorry! That location wasn't on the list.");

        //    }

        //}



        //Part 9 and 10 

        Console.WriteLine("Select and type one animal from the following list to see if it has a match: sloth, panda, penguin, dog, cat.");
        string animalName = Console.ReadLine();

        List<string> animalList = new List<string>();
        animalList.Add("sloth");
        animalList.Add("panda");
        animalList.Add("penguin");
        animalList.Add("panda");
        animalList.Add("dog");
        animalList.Add("cat");

        for (int i = 0; i < animalList.Count; i++)
        {
            foreach
            }
        }



        ////PART 11

        List<string> candyList = new List<string>();
        candyList.Add("sprees");
        candyList.Add("sour patch kids");
        candyList.Add("sweet tarts");
        candyList.Add("jaw breaker");
        candyList.Add("sweet tarts");
        candyList.Add("gummy bears");

        foreach (string candy in candyList) ;
        {
            Console.WriteLine(candyList);
        }

        try
        {
            foreach (string candy in candyList)
            {
                candyList.Remove(candy);
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
       
    }


