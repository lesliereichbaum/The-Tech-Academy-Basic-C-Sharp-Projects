using System;
using System.Collections.Generic;
using System.Linq;

class Program
    {
        static void Main(string[] args)
        {

        //PART ONE 

        Console.WriteLine("Type: \"I like\" into the console");
       string iLike = Console.ReadLine();

        string[] jokeArray = { "pizza", "cookies", "ice cream", "donuts" };
        foreach (string food in jokeArray)
        {
            //jokeArray.Append(iLike);

            Console.WriteLine(iLike + " " + food);
        }

        for (int i = 0; i < jokeArray.Length; i++)
        {
            Console.WriteLine(jokeArray[i]);
        }
        Console.ReadLine();

        //INFINITE LOOP parts 2 and 3 and 4

        Console.WriteLine("Click the \"Enter \"button");
        Console.ReadLine();


        do
        {
            iLike += " these, too. They are yummy.";
            Console.WriteLine(iLike);
        }
        //while (true)
        //{
        //INFINITE LOOP CONDITION 
        //}

        while (jokeArray.Length < 2);
        {

        }

        Console.ReadLine();

        // PART 5 

        for (int i = 0; i <= 12; i = i +3 )
        {
            Console.WriteLine(i);
        }

        //PART 6 LIST of strings that iterates through the list PART 7

        Console.WriteLine("You won! Choose either 0, 1, 2, or 3 to receive your vacation destination!");

        List<string> VacationList = new List<string>();
        VacationList.Add("Hawaii");
        VacationList.Add("Tokyo");
        VacationList.Add("Yosemite");
        VacationList.Add("Disney World");
        int SummerVacation = Convert.ToInt32(Console.ReadLine());
        try
        {
            Console.WriteLine("Your vacation destination is:" + VacationList[SummerVacation]);
        }
        catch
        {
            Console.WriteLine("You entered a different character. Please only choose 0-3");
        }


        foreach (string vacation in VacationList)
        {
            if (VacationList.Count < 100)
            {
                Console.WriteLine("Other Possibility:" + vacation);
            }

           
        }
       
    }

}

