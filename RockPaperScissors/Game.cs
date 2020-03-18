using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RunGame
    {


        string gameTypeChoice;

        public void StartGame()
        {
            Console.WriteLine("Press 1 for Single Player Mode\nPress 2 for Multiplayer Mode");
            gameTypeChoice = Console.ReadLine();
            if(gameTypeChoice != "1" && gameTypeChoice != "2")
            {
                while(gameTypeChoice != "1" && gameTypeChoice != "2")
                {
                    Console.WriteLine("Not a valid entry.\nPress 1 for Single Player Mode\nPress 2 for Multiplayer Mode");
                    gameTypeChoice = Console.ReadLine();
                }
            }
                
            else if(gameTypeChoice == "1")
            {

            }
            else if(gameTypeChoice == "2")
            {

            }
            else
            {

            }
        }
        
        






    }
}
