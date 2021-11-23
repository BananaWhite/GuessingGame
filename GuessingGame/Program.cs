using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hi let's play a game.\nType 1 to go solo, against pseudo-number genernator");
            Console.WriteLine("Type 2 to play with you friend.");

            int chose = Convert.ToInt32(Console.ReadLine());

            switch(chose)
            {
                case 1:
                    SoloGame();
                    break;
                case 2:
                    TwoplayerGame();
                    break;
            }

            
        }

        static void SoloGame()
        {
            Console.WriteLine("Guess a number");
            Random r = new Random();
            int guesses = 1;
            int generated = r.Next(0, new Random().Next(100, 1000));

            while(true)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if(number == generated)
                {
                    Console.WriteLine("Congratulations, you win");
                    Console.WriteLine("Number of guesses: {0}", guesses);
                }
                Console.WriteLine("Oops, you missed. Try again");
                ++guesses;
            }
        }

        static void TwoplayerGame()
        {
            Console.WriteLine("2 player game, best way played with a number higher than 100\n");
            int number;
            int guesses = 1;
            string value = null;

            while (true)
            {
                var key = Console.ReadKey(true).KeyChar;
                if (key == 13)
                    break;
                value += key;
            }
            number = Convert.ToInt32(value);

            Console.WriteLine("Let's start the game");

            while (true)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if (n == number)
                {
                    Console.WriteLine("Congratulations, you win");
                    Console.WriteLine("Number of guesses: {0}", guesses);
                    break;
                }
                Console.WriteLine("We're sorry, you missed. Try again");
                ++guesses;
            }
        }
    }
}
