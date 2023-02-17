using GameRockPaperScissors;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class GameRockPaperScissors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of rock, paper, scissors!");

            int pointUser1 = 0;
            int pointUser2 = 0;

            while (pointUser1 != 3 || pointUser2 !=3)
            {
                Console.WriteLine("Selection of player number 1: ");
                string User1 = Console.ReadLine();
                Console.WriteLine("Selection of player number 2: ");
                string User2 = Console.ReadLine();

                Gameplay win = new Gameplay(User1, User2);
            }

            if (pointUser1 > pointUser2)
            {
                Console.WriteLine("The winner is User1");
            }
            else
            {
                Console.WriteLine("The winner is User2");
            }
            
        }
    }
}