using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {


        string gameTypeChoice;
        string userInput1;
        string userInput2;
        

        
        
        



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
                Player player1 = new Human(Console.ReadLine());
            }
            else if (gameTypeChoice == "2")
            {
                Console.WriteLine("Player 1 enter your name:");
                Player player1 = new Human(Console.ReadLine());
                Console.WriteLine("Player 2 enter your name:");
                Player player2 = new Human(Console.ReadLine());

            }
        }


    }
}
