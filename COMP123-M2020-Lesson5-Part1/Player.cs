using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1
{
    class Player : GameObject
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTOR

        public Player(string name)
            : base(name)
        { 
        }

        // PRIVATGE METHODS

        // PUBLIC METHODS
        public void RaiseShields()
        {
            Console.WriteLine("Raising Shields");
        }
    }
}
