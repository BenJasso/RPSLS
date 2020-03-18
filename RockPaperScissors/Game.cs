using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        //member variables

        string gameTypeChoice;
        Player player1;
        Player player2;
        int player1Score;
        int player2Score;
      
        


        //constructor




        //methods

        public void RunGame()
        {
            Console.WriteLine("Welcome to RPSLS!!!\n\nThis game is a spin off of rock, paper, scissors.\nThe main objective is to win three rounds first.\n\nHere are the rules:\nRock crushes Scissors, Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock.\n\nThings to keep in mind:\nWhen selecting an option make sure it is spelt exactly the same and with the first letter capitalized.\n\nPress Enter to select game mode.");
            Console.ReadLine();
            while (player2Score == 0 && player1Score == 0)
            {

                
                AssignGameMode();
                while (player2.score == 0 && player1.score == 0)
                {



                    while (player1.score < 3 && player2.score < 3)
                    {

                        player1.PlayerDecideGesture();
                        player2.PlayerDecideGesture();
                        GainPointCheck();
                    }
                    if (player1.score == 3)
                    {
                        Console.WriteLine($"{player1.name} wins the game!!!!");
                        player1.score = 0;
                        player2.score = 0;
                        Console.WriteLine("Type 1 to play again. Type 2 to end");
                        string userInput = Console.ReadLine();
                        if (userInput == "1")
                        {
                            player1.score = 0;
                            player2.score = 0;
                        }
                        else if (userInput == "2")
                        {
                            Console.WriteLine("Hope you enjoyed playing!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{player2.name} wins the game!!!!");
                        player1.score = 0;
                        player2.score = 0;
                        Console.WriteLine("Type 1 to play again. Type 2 to end");
                        string userInput = Console.ReadLine();
                        if (userInput == "1")
                        {
                            player1.score = 0;
                            player2.score = 0;
                            player1Score = player1.score;
                            player2Score = player2.score;
                            break;
                        }
                        else if (userInput == "2")
                        {
                            Console.WriteLine("Hope you enjoyed playing!");
                            player1Score = player1.score;
                            player2Score = player2.score;
                            break;
                        }
                    }
                    break;
                }
            }
            }
            
        

        public void GainPointCheck()
        {
            if(player1.gestureChoice == "Rock")
            {
                if(player2.gestureChoice == "Rock")
                {
                    Console.WriteLine("Its a Tie! No points awarded!");
                }
                else if (player2.gestureChoice == "Paper")
                {
                    Console.WriteLine($"{player2.name} wins round!");
                    player2.score++;
                }
                else if (player2.gestureChoice == "Scissors")
                {
                    Console.WriteLine($"{player1.name} wins round!");
                    player1.score++;
                }
                else if (player2.gestureChoice == "Lizard")
                {
                    Console.WriteLine($"{player1.name} wins round!");
                    player1.score++;
                }
                else if (player2.gestureChoice == "Spock")
                {
                    Console.WriteLine($"{player2.name} wins round!");
                    player2.score++;
                }
            }
            else if(player1.gestureChoice == "Paper")
            {
                if (player2.gestureChoice == "Rock")
                {
                    Console.WriteLine($"{player2.name} wins round!");
                    player1.score++;
                }
                else if (player2.gestureChoice == "Paper")
                {
                    Console.WriteLine("Its a Tie! No points awarded!");
                    
                }
                else if (player2.gestureChoice == "Scissors")
                {
                    Console.WriteLine($"{player2.name} wins round!");
                    player2.score++;
                }
                else if (player2.gestureChoice == "Lizard")
                {
                    Console.WriteLine($"{player2.name} wins round!");
                    player2.score++;
                }
                else if (player2.gestureChoice == "Spock")
                {
                    Console.WriteLine($"{player1.name} wins round!");
                    player1.score++;
                }
            }
            else if(player1.gestureChoice == "Scissors")
            {
                if (player2.gestureChoice == "Rock")
                {
                    Console.WriteLine($"{player2.name} wins round!");
                    player2.score++;
                }
                else if (player2.gestureChoice == "Paper")
                {
                    Console.WriteLine($"{player1.name} wins round!");
                    player1.score++;

                }
                else if (player2.gestureChoice == "Scissors")
                {
                    Console.WriteLine("Its a Tie! No points awarded!");
                    
                }
                else if (player2.gestureChoice == "Lizard")
                {
                    Console.WriteLine($"{player1.name} wins round!");
                    player1.score++;

                }
                else if (player2.gestureChoice == "Spock")
                {
                    Console.WriteLine($"{player2.name} wins round!");
                    player2.score++;
                }
            }
            else if(player1.gestureChoice == "Lizard")
            {
                if (player2.gestureChoice == "Rock")
                {
                    Console.WriteLine($"{player2.name} wins round!");
                    player2.score++;
                }
                else if (player2.gestureChoice == "Paper")
                {
                    Console.WriteLine($"{player1.name} wins round!");
                    player1.score++;

                }
                else if (player2.gestureChoice == "Scissors")
                {
                    Console.WriteLine($"{player2.name} wins round!");
                    player2.score++;

                }
                else if (player2.gestureChoice == "Lizard")
                {
                    Console.WriteLine("Its a Tie! No points awarded!");

                }
                else if (player2.gestureChoice == "Spock")
                {
                    Console.WriteLine($"{player1.name} wins round!");
                    player1.score++;
                }

            }
            else if(player1.gestureChoice == "Spock")
            {
                if (player2.gestureChoice == "Rock")
                {
                    Console.WriteLine($"{player1.name} wins round!");
                    player1.score++;
                }
                else if (player2.gestureChoice == "Paper")
                {
                    Console.WriteLine($"{player2.name} wins round!");
                    player2.score++;

                }
                else if (player2.gestureChoice == "Scissors")
                {
                    Console.WriteLine($"{player1.name} wins round!");
                    player1.score++;

                }
                else if (player2.gestureChoice == "Lizard")
                {
                    Console.WriteLine($"{player2.name} wins round!");
                    player2.score++;

                }
                else if (player2.gestureChoice == "Spock")
                {
                    Console.WriteLine("Its a Tie! No points awarded!");
                }

            }
            else
            {
                Console.WriteLine("There was an invalid entry. Please make sure your choices start with a capital letter.");
            }

            Console.WriteLine($"{player1.name}:{player1.score}\n{player2.name}:{player2.score}");
            
        }
        public void AssignGameMode()
        {


            while (gameTypeChoice != "1" && gameTypeChoice != "2")
            {
                Console.WriteLine("\nPress 1 for Single Player Mode\nPress 2 for Multiplayer Mode");
                gameTypeChoice = Console.ReadLine();
                
                if (gameTypeChoice == "1")
                {
                    Console.WriteLine("Player 1 enter your name:");

                    player1 = new Human(Console.ReadLine());
                    player2 = new Computer("Computer");
                    Console.WriteLine($"\n{player1.name}:{player1.score}\n{player2.name}:{player2.score}");
                }
                else if (gameTypeChoice == "2")
                {
                    Console.WriteLine("Player 1 enter your name:");
                    player1 = new Human(Console.ReadLine());
                    Console.WriteLine("Player 2 enter your name:");
                    player2 = new Human(Console.ReadLine());
                    Console.WriteLine($"\n{player1.name}:{player1.score}\n{player2.name}:{player2.score}");

                }
                else
                {
                    Console.WriteLine("Invalid entry. Please enter again");
                }
            }
               

        }


    }
}
