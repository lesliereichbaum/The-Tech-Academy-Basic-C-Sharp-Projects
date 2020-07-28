using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        //ARRAYS
        //String ARRAY

        //try
        //{
        //    Console.WriteLine("choose a number from 0 through 4. this will be your snack today.");
        //    string[] stringarray = new string[] { "apple", "orange", "watermelon", "grapes", "banana" };



        //    int fruitnum = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("you will have a: " + stringarray[fruitnum]);
        //}

        //catch (Exception e)
        //{
        //    Console.WriteLine(e.Message);
        //}

        //INT ARRAY

        //try
        //{
        //    Console.WriteLine("Choose a number from 0 through 4. Use this number to play the lottery.");
        //    int[] intArray = new int[] { 32, 98, 54, 67, 19 };


        //    int lotteryNum = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Your number is: " + intArray[lotteryNum]);

        //}

        //catch (Exception e)
        //{
        //    Console.WriteLine(e.Message);
        //}

        //LIST 

        Console.WriteLine("Choose either 0, 1, 2, or 3");
     

        List<string> StarList = new List<string>();
        StarList.Add("Twinkle");
        StarList.Add("Twinkle");
        StarList.Add("Little");
        StarList.Add("Star");

   

      int StarSong = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Guess the song with just the word given: " + StarList[StarSong]); 
      



    }
}


