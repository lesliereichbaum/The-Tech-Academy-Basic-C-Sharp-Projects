using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

class Program
    {
        static void Main(string[] args)
        {

       // //PART ONE 

       // Console.WriteLine("Type: \"I like\" into the console");
       //string iLike = Console.ReadLine();

       // string[] jokeArray = { "pizza", "cookies", "ice cream", "donuts" };
       // foreach (string food in jokeArray)
       // {
       //     //jokeArray.Append(iLike);

       //     Console.WriteLine(iLike + " " + food);
       // }

       // for (int i = 0; i < jokeArray.Length; i++)
       // {
       //     Console.WriteLine(jokeArray[i]);
       // }
       // Console.ReadLine();

       // //INFINITE LOOP parts 2 and 3 and 4

       // Console.WriteLine("Click the \"Enter \"button");
       // Console.ReadLine();


       // do
       // {
       //     iLike += " these, too. They are yummy.";
       //     Console.WriteLine(iLike);
       // }
       // //while (true)
       // //{
       // //INFINITE LOOP CONDITION 
       // //}

       // while (jokeArray.Length < 2);
       // {

       // }

       // Console.ReadLine();

       // // PART 5 

       // for (int i = 0; i <= 12; i = i +3 )
       // {
       //     Console.WriteLine(i);
       // }

       // //PARTs 6, 7, and 8 

       // Console.WriteLine("You won! Choose either 0, 1, 2, or 3 to receive your vacation destination!");

       // List<string> VacationList = new List<string>();
       // VacationList.Add("Hawaii");
       // VacationList.Add("Tokyo");
       // VacationList.Add("Yosemite");
       // VacationList.Add("Disney World");
       // int SummerVacation = Convert.ToInt32(Console.ReadLine());
       // try
       // {
       //     Console.WriteLine("Your vacation destination is:" + VacationList[SummerVacation]);
       // }
       // catch
       // {
       //     Console.WriteLine("You entered a different character. Please only choose 0-3");
       // }


       // foreach (string vacation in VacationList)
       // {
           
       //         Console.WriteLine("Other Possibility:" + vacation);
       //     break; 
       // }

        //Part 9 -- NOT COMPLETE/WORKING

        Console.WriteLine("Which is your favorite type of animal from the list?");

      

        List<string> animalList = new List<string>();
        animalList.Add("sloth");
        animalList.Add("panda");
        animalList.Add("penguin");
        animalList.Add("panda");
        animalList.Add("dog");
        animalList.Add("cat");

        try
        {
            foreach (string animal in animalList)
            {
                Console.WriteLine(animal.ToString() + " ");
            }
            Console.ReadLine();

            Console.WriteLine("Find out what index each animal is");

            int index;
            for (int i = 0; i < animalList.Count; i++)
            {
                if (animalList.Count > 6)
                {
                    index = i;
                    break;


                }  
               
            }
          
        }

        catch (Exception e)
        {
            Console.WriteLine("You entered an animal name that does not exit. Look at list and try again.");
        }

        // Finding the index of each animal (not working) 
        int index1 = animalList.FindIndex(a => a.Contains(' '));
        Console.WriteLine("List Item ('panda') at Index: " + index1);
        string animalName=Console.ReadLine();

        foreach (string animal in animalList);
        {
            Console.WriteLine(index1);
            
        }

        //PART 11

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


