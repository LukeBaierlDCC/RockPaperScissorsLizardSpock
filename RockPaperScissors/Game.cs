using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        public Player playerOne;
        public Player playerTwo;
        
        public Rules rules;

        public Game()
        {
            rules = new Rules();
        }

        public void CreatePlayers()
        {
            Console.WriteLine("1 or 2 Players?");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
            playerOne = new Player();
            playerTwo = new CPUPlayer();
            }
            if (userInput == "2");
            {
            playerOne = new Player();
            playerTwo = new Player();
    }
}
        public void DetermineWinner()
        {

        }

        public void CheckScore()
        {

        }
        public void RunGame()
        {
            rules.DisplayRules();
            
            CreatePlayers();

            playerOne.PickGesture();

            playerTwo.PickGesture();

            DetermineWinner();
        }
    }
}
