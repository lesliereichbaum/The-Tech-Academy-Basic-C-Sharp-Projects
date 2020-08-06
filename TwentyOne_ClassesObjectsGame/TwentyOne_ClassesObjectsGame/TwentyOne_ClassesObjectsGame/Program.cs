using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_ClassesObjectsGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();

            //int count = deck.Cards.Count(x => x.Face == Face.Ace);   //Example of a lambda function using "=>"

            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList(); //Ex of lambda function using 'Where'

            List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 }; //Ex of lambda function 

            int sum = numberList.Max();
            Console.WriteLine(sum);

            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}

            //Console.WriteLine(count);

            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }


    }
   }
    
