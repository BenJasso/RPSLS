using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
     abstract class Player
    {
        //member variables
        public string name;
        public int score;
        public string gestureChoice;
        public string[] gestures = new string[5] { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
       




        //Constructor
        public Player(string name)
        {
            this.name = name;
        }


        //methods

        public abstract void PlayerDecideGesture();
        

    }
}
