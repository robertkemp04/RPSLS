using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class ComputerPlayer : Player
    {
        public ComputerPlayer(string name) : base(name)
        {
           
        }
        public override void ChooseGesture()
        {
            
            var random = new Random();
            int rGesture = random.Next(gestures.Count);
            chosenGesture = Convert.ToString(gestures[rGesture]);
        }
    }
}



