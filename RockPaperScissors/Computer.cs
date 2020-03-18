using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Computer : Player
    {
        //member variables
        string name;



        //Constructor
        public Computer(string name):base(name)

        {
            this.name = name;
        }



        //methods
        public override void PlayerDecideGesture()
        {
            var random = new Random();
            gestureChoice = gestures[random.Next(0,4)];
            Console.WriteLine($"\n{name}:{gestureChoice}");
            Console.ReadLine();
            

            
        }

    }
}
