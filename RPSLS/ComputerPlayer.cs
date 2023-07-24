using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class ComputerPlayer : Player
    {
        Random rnd = new Random();
        int number;

        public ComputerPlayer(string name) : base(name)
        {
            
        }

        public override void ChooseGesture()
        {
            number = rnd.Next(1, 6);

            if(number == 1)
            {
                chosenGesture = "rock";
                Console.WriteLine($"{name} chooses {chosenGesture}");
            }
            else if(number == 2)
            {
                chosenGesture = "paper";
                Console.WriteLine($"{name} chooses {chosenGesture}");
            }
            else if(number == 3)
            {
                chosenGesture = "scissors";
                Console.WriteLine($"{name} chooses {chosenGesture}");
            }
            else if(number == 4)
            {
                chosenGesture = "lizard";
                Console.WriteLine($"{name} chooses {chosenGesture}");
            }
            else if (number == 5)
            {
                chosenGesture = "Spock";
                Console.WriteLine($"{name} chooses {chosenGesture}");
            }
        }
    }
}
