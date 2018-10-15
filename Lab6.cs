using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoll();
            Exit();
        }

        static void DiceRoll()
        {
            Console.Write("Welcome to the Grand Circus Casino! Roll the dice? (y/n)  ");
            bool retry = Retry();
            if (retry)
            {
                Console.Write("\nHow many sides should each die have?  ");
                if (int.TryParse(Console.ReadLine(), out int sides))
                {
                    int count = 1;
                    while (retry)
                    {
                        Random random = new Random();
                        Console.WriteLine("\nRoll {0}:\n{1}\n{2}", count, random.Next(1, sides), random.Next(1, sides));
                        count = count + 1;
                        Console.Write("\n\nRoll Again? (y/n)  ");
                        retry = Retry();
                    }
                }
            }
        }

        static bool Retry()
        {
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.Y)
            {
                return true;
            }
            else if (key == ConsoleKey.N)
            {
                Console.WriteLine("\nGoodbye! Press ESCAPE to exit.");
                return false;
            }
            else
            {
                Console.WriteLine("\nEntry Invalid, Try Again...");
                bool retry = Retry();
                return retry;
            }
        }

        static void Exit()
        {
            while(Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Exit();
            }
        }
    }
}//October 15, 2018
