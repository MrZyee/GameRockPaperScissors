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

            while (pointUser1 != 3 && pointUser2 != 3)
            {
                Console.WriteLine("Selection of player number 1: ");
                string User1 = Console.ReadLine();
                Console.WriteLine("Selection of player number 2: ");
                string User2 = Console.ReadLine();

                if (User1 == "paper" && User2 == "rock" || 
                    User1 == "scissors" && User2 == "paper" || 
                    User1 == "rock" && User2 == "scissors")
                {
                    Console.WriteLine("User1 WIN!");
                    pointUser1++;
                }
                else if (User2 == "paper" && User1 == "rock" || 
                    User2 == "scissors" && User1 == "paper" || 
                    User2 == "rock" && User1 == "scissors")
                {
                    Console.WriteLine("User2 WIN!");
                    pointUser2++;
                }
                else
                {
                    Console.WriteLine("remis!");
                }
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