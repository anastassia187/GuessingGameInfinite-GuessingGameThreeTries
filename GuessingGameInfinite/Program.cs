using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int i  = rnd.Next(1, 11);
            bool LoopActive = true;

            Console.WriteLine("Game: Guess the number!");
            Console.WriteLine();
            Console.WriteLine("Computer guessed the number from 1 to 10. Try to guess this number!");
            Console.WriteLine("Enter correct number:");
           
            while (LoopActive)
            {
                int gameNumber = Convert.ToInt32(Console.ReadLine());

                if (gameNumber == i)
                {
                    Console.WriteLine("You Win! Computer guessed the number " + i + "!");
                    LoopActive = false;
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            

            }

        }
    }
}
