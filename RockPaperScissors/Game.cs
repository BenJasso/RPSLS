using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        //member variables

        string gameTypeChoice;
        Player player1;
        Player player2;
        


        //constructor




        //methods

        public void RunGame()
        {
            AssignGameMode();
            player1.PlayerDecideGesture();
            player2.PlayerDecideGesture();
            
        }
        public void AssignGameMode()
        {
            Console.WriteLine("Press 1 for Single Player Mode\nPress 2 for Multiplayer Mode");
            gameTypeChoice = Console.ReadLine();
            if (gameTypeChoice != "1" && gameTypeChoice != "2")
            {
                while (gameTypeChoice != "1" && gameTypeChoice != "2")
                {
                    Console.WriteLine("Not a valid entry.\nPress 1 for Single Player Mode\nPress 2 for Multiplayer Mode");
                    gameTypeChoice = Console.ReadLine();
                }
            }
            else if (gameTypeChoice == "1")
            {
                Console.WriteLine("Player 1 enter your name:");
                player1 = new Human(Console.ReadLine());
                player2 = new Computer("Computer");
            }
            else if (gameTypeChoice == "2")
            {
                Console.WriteLine("Player 1 enter your name:");
                 player1 = new Human(Console.ReadLine());
                Console.WriteLine("Player 2 enter your name:");
                 player2 = new Human(Console.ReadLine());

            }
        }


    }
}
