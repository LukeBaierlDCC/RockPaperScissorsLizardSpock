using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to rock, paper, scissors, lizard, spock.");

            Game game = new Game();
            game.RunGame();

            Console.ReadLine();
        }
    }
}