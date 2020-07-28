//using System;

//namespace WhileStatements
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Guess a number between 1 - 10.");
//            int numberGuess = Convert.ToInt32(Console.ReadLine());
//            bool guessnumber = false;

//            while (guessnumber == false)
//            switch (numberGuess)
//                {
//                    case 8:
//                        Console.WriteLine("You guessed 8. Try again");
//                        Console.WriteLine("Guess a number between 1-10.");
//                        numberGuess= Convert.ToInt32(Console.ReadLine());
//                        break;
//                    case 5:
//                        Console.WriteLine("You guessed 5. Try again.");
//                        Console.WriteLine("Guess a number between 1-10.");
//                        numberGuess = Convert.ToInt32(Console.ReadLine());
//                        break;
//                    case 4:
//                        Console.WriteLine("You guess 4. That is correct!");
//                        guessnumber = true; 
//                        break;
//                    default:
//                        Console.WriteLine("You are wrong.");
//                        Console.WriteLine("Guess a number between 1-10.");
//                        numberGuess = Convert.ToInt32(Console.ReadLine());
//                        break; 
//                }
//            Console.Read();
//        }

//DO WHILE LOOP 

using System;

namespace WhileStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 - 10.");
            int numberGuess = Convert.ToInt32(Console.ReadLine());
            bool guessnumber = numberGuess == 4;

            do
            {
                switch (numberGuess)
                {
                    case 8:
                        Console.WriteLine("You guessed 8. Try again");
                        Console.WriteLine("Guess a number between 1-10.");
                        numberGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5. Try again.");
                        Console.WriteLine("Guess a number between 1-10.");
                        numberGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guess 4. That is correct!");
                        guessnumber = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number between 1-10.");
                        numberGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (guessnumber == false);
                
            Console.Read();
        }














    }
}
