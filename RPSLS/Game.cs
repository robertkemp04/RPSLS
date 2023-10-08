using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock\n");
            Console.WriteLine("Games will be best 2 out of 3\n");
            
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("How many human players will there be:");
            int humanPlayers = Convert.ToInt32(Console.ReadLine());
            return humanPlayers;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if (numberOfHumanPlayers < 2)
            {
                Console.WriteLine("What is player one's name?");
                playerOne = new HumanPlayer(Console.ReadLine());
                playerTwo = new ComputerPlayer("CPU");
            }
            else
            {
                Console.WriteLine("What is player one's name?");
                playerOne = new HumanPlayer(Console.ReadLine());
                Console.WriteLine("What is player two's name?");
                playerTwo = new HumanPlayer(Console.ReadLine());
            }
        }

        public void CompareGestures()
        {

            Console.WriteLine(playerOne.name + " chose " + playerOne.chosenGesture + " while " + playerTwo.name + " chose " + playerTwo.chosenGesture);

            if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Rock")
            {
                Console.WriteLine("The round is a tie");
                playerOne.score += 0;
                playerTwo.score += 0;
            }
            else if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine(playerTwo.name + " wins the round");
                playerOne.score += 0;
                playerTwo.score += 1;
            }
            else if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Scissors")
            {
                Console.WriteLine(playerOne.name + " wins the round");
                playerOne.score += 1;
                playerTwo.score += 0;
            }
            else if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Lizard")
            {
                Console.WriteLine(playerOne.name + " wins the round");
                playerOne.score += 1;
                playerTwo.score += 0;
            }
            else if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine(playerTwo.name + " wins the round");
                playerOne.score += 0;
                playerTwo.score += 1;
            }
            else if(playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Rock")
            {
                Console.WriteLine(playerOne.name + " wins the round");
                playerOne.score += 1;
                playerTwo.score += 0;
            }
            else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine("The round is a tie");
                playerOne.score += 0;
                playerTwo.score += 0;
            }
            else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Scissors")
            {
                Console.WriteLine(playerTwo.name + " wins the round");
                playerOne.score += 0;
                playerTwo.score += 1;
            }
            else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Lizard")
            {
                Console.WriteLine(playerTwo.name + " wins the round");
                playerOne.score += 0;
                playerTwo.score += 1;
            }
            else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine(playerOne.name + " wins the round");
                playerOne.score += 1;
                playerTwo.score += 0;
            }
            else if (playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Rock")
            {
                Console.WriteLine(playerTwo.name + " wins the round");
                playerOne.score += 0;
                playerTwo.score += 1;
            }
            else if (playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine(playerOne.name + " wins the round");
                playerOne.score += 1;
                playerTwo.score += 0;
            }
            else if (playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Scissors")
            {
                Console.WriteLine("The round is a tie");
                playerOne.score += 0;
                playerTwo.score += 0;
            }
            else if (playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Lizard")
            {
                Console.WriteLine(playerOne.name + " wins the round");
                playerOne.score += 1;
                playerTwo.score += 0;
            }
            else if (playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine(playerTwo.name + " wins the round");
                playerOne.score += 0;
                playerTwo.score += 1;
            }
            else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Rock")
            {
                Console.WriteLine(playerTwo.name + " wins the round");
                playerOne.score += 0;
                playerTwo.score += 1;
            }
            else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine(playerOne.name + " wins the round");
                playerOne.score += 1;
                playerTwo.score += 0;
            }
            else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Scissors")
            {
                Console.WriteLine(playerTwo.name + " wins the round");
                playerOne.score += 0;
                playerTwo.score += 1;
            }
            else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Lizard")
            {
                Console.WriteLine("The round is a tie");
                playerOne.score += 0;
                playerTwo.score += 0;
            }
            else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine(playerOne.name + " wins the round");
                playerOne.score += 1;
                playerTwo.score += 0;
            }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Rock")
            {
                Console.WriteLine(playerOne.name + " wins the round");
                playerOne.score += 1;
                playerTwo.score += 0;
            }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine(playerTwo.name + " wins the round");
                playerOne.score += 0;
                playerTwo.score += 1;
            }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Scissors")
            {
                Console.WriteLine(playerOne.name + " wins the round");
                playerOne.score += 1;
                playerTwo.score += 0;
            }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Lizard")
            {
                Console.WriteLine(playerTwo.name + " wins the round");
                playerOne.score += 0;
                playerTwo.score += 1;
            }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine("The round is a tie");
                playerOne.score += 0;
                playerTwo.score += 0;
            }
            else
            {
                Console.WriteLine("At least one player didn't pick a listed gesture, try again. (capitalization matter!)");
                playerOne.score += 0;
                playerTwo.score += 0;
            }
        }

        public void DisplayGameWinner()
        {
            if (playerOne.score >= 2)
            {
                Console.WriteLine("WINNER!!! \n" + playerOne.name + " wins the game");
            }
            else if (playerTwo.score >= 2)
            {
                Console.WriteLine("WINNER!!! \n" + playerTwo.name + " wins the game");
            }
            else
            {
                CompareGestures();
            }
        }

        public void RunGame()
        {
            WelcomeMessage();
            int humanPlayers = ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(humanPlayers);
           
            CompareGestures();
            DisplayGameWinner();
        }
    }
}
