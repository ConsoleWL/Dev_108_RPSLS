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
            Console.WriteLine($"{name}, here are your options: ");

            while (true)
            {
                for (int i = 0; i < gestures.Count; i++)
                {
                    Console.WriteLine($"Press: {i + 1} for {gestures.Count}");
                }
                chosenGesture = Console.ReadLine();

                if (chosenGesture == "1")
                {
                    chosenGesture = "rock";
                    Console.WriteLine($"{name} chooses {chosenGesture}");
                    break;
                }
                else if (chosenGesture == "2")
                {
                    chosenGesture = "paper";
                    Console.WriteLine($"{name} chooses {chosenGesture}");
                    break;
                }
                else if (chosenGesture == "3")
                {
                    chosenGesture = "scissors";
                    Console.WriteLine($"{name} chooses {chosenGesture}");
                    break;
                }
                else if (chosenGesture == "4")
                {
                    chosenGesture = "lizard";
                    Console.WriteLine($"{name} chooses {chosenGesture}");
                    break;
                }
                else if (chosenGesture == "5")
                {
                    chosenGesture = "Spock";
                    Console.WriteLine($"{name} chooses {chosenGesture}");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input, try again");
                }
            }  
        }
    }
}
