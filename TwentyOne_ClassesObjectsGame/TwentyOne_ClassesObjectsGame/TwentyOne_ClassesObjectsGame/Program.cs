﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne_ClassesObjectsGame;

namespace TwentyOne_ClassesObjectsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }
           
            Console.WriteLine("Hello, " + playerName +",would you like to join a game of 21 right now?,");
            string answer = Console.ReadLine().ToLower();
           
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Student\Downloads\myProjects.txt", true))
                {
                    file.WriteLine(player.Id);
          
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance >0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security! Kick this person out.");
                        Console.ReadLine();
                        return; 
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred. Please contact your System Administrator.");
                        Console.ReadLine();
                        return; 
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }
    }
 }
    
