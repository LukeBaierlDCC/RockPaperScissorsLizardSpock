using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player
    {
        public int score;
        public string gesture;
        public string playerName;
        

        public Player()
        {
            
        }
        public void PickGesture()
        {
            string inputPlayer, inputCPU;
            int randomInt;
            
                Console.WriteLine("Welcome to rock, paper, scissors, lizard, spock. Press 1 to start game.");

                Game game = new Game();
              //  game.RunGame();

                Console.ReadLine();
            
            bool playAgain = true;
            
            while (playAgain)
            {

                int scorePlayer = 0;
                int scoreCPU = 0;
            

            while (scorePlayer < 3 && scoreCPU < 3)
            {


                Console.Write("Choose between ROCK, PAPER, SCISSORS, LIZARD and SPOCK:     ");
                inputPlayer = Console.ReadLine();
                inputPlayer = inputPlayer.ToUpper();

                Random rnd = new Random();

                randomInt = rnd.Next(1, 4);

                switch (randomInt)
                {
                    case 1:
                        inputCPU = "ROCK";
                        Console.WriteLine("Computer chose ROCK");
                        if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("It's a draw.\n\n");
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("Nice! Paper covers rock!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("Shame. Rock crushes scissors!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "LIZARD")
                        {
                            Console.WriteLine("OUCH! Rock crushes lizard!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "SPOCK")
                        {
                            Console.WriteLine("Nice! Spock vaporizes rock!\n\n");
                            scorePlayer++;
                        }
                        break;
                    case 2:
                        inputCPU = "PAPER";
                        Console.WriteLine("Computer chose PAPER");
                        if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("Draw. Try again?\n\n");
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("Bummer. Paper covers rock.\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("Nice! Scissors cuts paper.\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "LIZARD")
                        {
                            Console.WriteLine("Nice! Lizard eats paper.\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "SPOCK")
                        {
                            Console.WriteLine("DOH! Paper disproves Spock.\n\n");
                            scoreCPU++;
                        }
                        break;
                    case 3:
                        inputCPU = "SCISSORS";
                        Console.WriteLine("Computer chose SCISSORS");
                        if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("Tie! The scissors have each other in a headlock.\n\n");
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("Your rock smashed the scissors!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("Scissors cuts through your paper.\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "LIZARD")
                        {
                            Console.WriteLine("Your lizard gets decapitated by the scissors.\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "SPOCK")
                        {
                            Console.WriteLine("You smash those scissors!\n\n");
                            scorePlayer++;
                        }
                        break;
                    case 4:
                        inputCPU = "LIZARD";
                        Console.WriteLine("Computer chose LIZARD");
                        if (inputPlayer == "LIZARD")
                        {
                            Console.WriteLine("The lizards make friends. Try again.\n\n");
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("You got vaporized by Spock!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("Paper gets eaten by lizard! Oh well.\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("Good job! You decapitated the lizard.\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "SPOCK")
                        {
                            Console.WriteLine("Oh no! Lizard poisons Spock! Captain, I don't feel so good.\n\n");
                            scoreCPU++;
                        }
                        break;
                    case 5:
                        inputCPU = "SPOCK";
                        Console.WriteLine("Computer chose SPOCK");
                        if (inputPlayer == "SPOCK")
                        {
                            Console.WriteLine("Time paradox! Spock meets Spock!\n\n");
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("You got vaporized by Spock!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("Paper disproves Spock's research! Good job!\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("Tough luck. Spock just smashes the scissors.\n\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "LIZARD")
                        {
                            Console.WriteLine("Nice! Lizard poisons Spock! Captain, I don't feel so good.\n\n");
                            scorePlayer++;
                        }
                        break;

                    default:
                        Console.WriteLine("For shame. Not the gesture we're looking for!");
                        break;
                    }
                }

                Console.WriteLine("\n\nSCORE:\tPLAYER:\t{0}\tCPU:\t{1}",scorePlayer, scoreCPU);

            

            if (scorePlayer == 3)
               {
                    Console.WriteLine("Player 1 WINS!");
               }
                    else if (scoreCPU == 3)
               {
                    Console.WriteLine("AI CHEATED ITS WAY TO VICTORY!");
               }
                   
              Console.WriteLine("Play again? (Yes/No)");
              string loop = Console.ReadLine();
               if (loop == "yes")
               {
                 playAgain = true;
                 Console.Clear();
               }
               else if (loop == "no")
               {
                 playAgain = false;
               }
            }
        } 
    }
}
