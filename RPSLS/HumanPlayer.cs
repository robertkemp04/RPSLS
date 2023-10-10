using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
            
        }

        public override void ChooseGesture()
        {
            Console.WriteLine("What gesture will you play? Your options are Rock, Paper, Scissors, Lizard, Spock");
            chosenGesture = Console.ReadLine();
        }
        
    }
}
