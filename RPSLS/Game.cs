using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
            Console.WriteLine("Rock crushes Schissors");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Paper disprives Spock");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Spock vaporizes Rock");

            Console.WriteLine("\nGame will be best out of 3");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            string userInput;
            Console.WriteLine("\nHow many players are playing:?");
            Console.WriteLine("Press 1 or 2");

            while (true)
            {
                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    return 1;
                }
                if (userInput == "2")
                {
                    return 2;
                }
                else
                {
                    Console.WriteLine("\nWrong input. Choose between 1 or 2");
                }
            }  
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {

        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
            ChooseNumberOfHumanPlayers();
        }
    }
}
