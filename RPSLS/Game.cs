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

        int numberOfHumanPlayers;

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
            if(numberOfHumanPlayers == 1)
            {
                playerOne = new HumanPlayer("Nikita");
                playerTwo = new ComputerPlayer("Computer");
            }
            if(numberOfHumanPlayers == 2)
            {
                playerOne = new HumanPlayer("Nikita");
                playerTwo = new HumanPlayer("Computer");
            }
            
        }

        public void CompareGestures()
        {
            
            while (playerOne.score == 3 || playerTwo.score == 3)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();

                if(playerOne.chosenGesture == "rock" || playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine("Tied, Try again");
                }
                else if(playerOne.chosenGesture == "paper" || playerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine("Tied, Try again");
                }
                else if (playerOne.chosenGesture == "scissors" || playerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine("Tied, Try again");
                }
                else if (playerOne.chosenGesture == "lizard" || playerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine("Tied, Try again");
                }
                else if (playerOne.chosenGesture == "Spock" || playerTwo.chosenGesture == "Spock")
                {
                    Console.WriteLine("Tied, Try again");
                }
                else if(playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "rock")



            }
        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
            numberOfHumanPlayers = ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(numberOfHumanPlayers);
            CompareGestures();
        }
    }
}

