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
        string name;



        //Constructor
        public Player()
        {

        }


        //methods

        public abstract void PlayerDecide();
        

    }
}
