using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Student\Downloads\myProjects.txt", true)) 
            {
                file.WriteLine(card);
            }
                Deck.Cards.RemoveAt(0);
        }
    }
}
