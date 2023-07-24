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
                playerTwo = new HumanPlayer("Michael");
            }
            
        }

        public void CompareGestures()
        {
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();

                Console.WriteLine();

                // logic for ties
                if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine("Tied, Try again");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine("Tied, Try again");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine("Tied, Try again");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine("Tied, Try again");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Spock")
                {
                    Console.WriteLine("Tied, Try again");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                //logic for rock
                else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "scissors")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "lizard")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                // logic for paper
                else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "rock")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "Spock")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                //logic for scissors
                else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "paper")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "lizard")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                //logic for lizard
                else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "Spock")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "paper")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                //logic for Spock
                else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "scissors")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "rock")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                //logic for playerTwo
                else
                {
                    playerTwo.score++;
                    Console.WriteLine($"{playerTwo.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }

                Console.WriteLine("________________________________________________");
            }
        }

        public void DisplayGameWinner()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine($"\nCongratulation {playerOne.name} is a winner!");
            }
            else
            {
                Console.WriteLine($"\nCongratulation {playerTwo.name} is a winner!");
            }
        }

        public void RunGame()
        {
            WelcomeMessage();
            numberOfHumanPlayers = ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(numberOfHumanPlayers);
            CompareGestures();
            DisplayGameWinner();
        }
    }
}

