using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne_ClassesObjectsGame
{
   public  class Player <Card> // generics ex: T reps the type to be passed in
    {
        public  List <Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        ////Overloading the Operator +
        //public static Game operator +(Game game, Player player)
        //{
        //    game.Players.Add(player);
        //    return game;
        //}
        ////Overlading the - Operator 
        //public static Game operator -(Game game, Player player)
        //{
        //    game.Players.Remove(player);
        //    return game;
        //}
    }
}
