using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRockPaperScissors
{
    internal class Gameplay
    {
        public Gameplay(string User1, string User2)
        {
            int pointUser1 = 0;
            int pointUser2 = 0;

            if (User1 == "paper" && User2 == "rock" || User1 == "scissors" && User2 == "paper" || User1 == "rock" && User2 == "scissors")
            {
                Console.WriteLine("User1 WIN!");
                pointUser1++;
            }
            else if (User2 == "paper" && User1 == "rock" || User2 == "scissors" && User1 == "paper" || User2 == "rock" && User1 == "scissors")
            {
                Console.WriteLine("User2 WIN!");
                pointUser2++;
            }
            else
            {
                Console.WriteLine("remis!");
            }

        }
    }
}
