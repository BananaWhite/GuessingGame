using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int guesses = 1;
            Random random = new Random();

            Console.Write("Let's play a game.\nIt's number guessing game.\nGive us a number - the higher the better.\nFor optimal performance, suggested number should be higher than 100\n");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Let's start the game");

            while(true)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if(n == number)
                {
                    Console.WriteLine("Congratulations, you win");
                    Console.WriteLine("Number of tries you took: {0}", guesses);
                    break;
                }
                Console.WriteLine("We're sorry, you missed. Try as much as you want. There is no counter");
                ++guesses;
            }
        }
    }
}
