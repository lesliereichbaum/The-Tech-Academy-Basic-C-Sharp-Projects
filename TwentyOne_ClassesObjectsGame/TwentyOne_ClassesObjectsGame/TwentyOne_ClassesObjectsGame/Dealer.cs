using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwentyOne_ClassesObjectsGame
{
    public class Dealer
    {
        //Class Property - not inherited 
        public string Name { get; set; }
        public  Deck Deck { get; set; }
        public int Balance { get; set; }

        //DEAL METHOD 
        public void Deal (List<Card>Hand)
        {
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
                Deck.Cards.RemoveAt(0);
        }
    }
}
