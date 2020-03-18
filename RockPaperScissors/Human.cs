using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Human : Player
    {
        //member variables

        string name;


        //Constructor
        public Human(string name)
            :base(name)
        {
            this.name = name;
            
        }



        //methods

        public override void PlayerDecideGesture()
        {
            Console.WriteLine($"Please choose an option:");
            foreach(string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
            gestureChoice = Console.ReadLine();
        }
    }
}
