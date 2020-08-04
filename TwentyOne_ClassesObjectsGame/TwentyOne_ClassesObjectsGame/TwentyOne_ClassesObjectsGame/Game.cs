using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne_ClassesObjectsGame
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        //ABSTRACT METHOD - only exists in abstract class - has no implementation 
        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
