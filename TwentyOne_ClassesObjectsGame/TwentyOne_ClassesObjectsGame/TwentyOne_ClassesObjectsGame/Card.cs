using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne_ClassesObjectsGame
{
   public struct Card   //Changed data type to struct 
    {
        //Properties (light blue) are now an enum type 
        public Suit Suit { get; set; } 
        public Face Face { get; set; }
    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace

    }
}
