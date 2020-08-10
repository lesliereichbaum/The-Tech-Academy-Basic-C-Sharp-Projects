using System;
using System.Collections.Generic;
using System.Text;

namespace Casino.TwentyOne_ClassesObjectsGame
{
    public class TwentyOneDealer : Dealer 
    {
        //fields
        private List<Card> _hand = new List<Card>();

        //properties - give access to fields
        public List<Card> Hand { get { return _hand; } set { _hand = value; }  }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }

        //Constructor

        //Methods
    }
}
