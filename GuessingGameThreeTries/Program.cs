using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int gameNumber = rnd.Next(1, 11);
            int count = 1;
            Console.WriteLine("Game: Guess the number!");
            Console.WriteLine();
            Console.WriteLine("Computer guessed the number from 1 to 10. Try to guess this number!");
            Console.WriteLine("Enter your first number:");
            int i = Convert.ToInt32(Console.ReadLine());

            while (count <= 3)
            {
                if( gameNumber == i)
                {
                    Console.WriteLine("Yes! Computer guessed the number " + i + "!");
                    Console.WriteLine("You Win!");
                    break;
                }
                else
                {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine("You Loose! It was a number " + i + "!");
                        Console.WriteLine("Computer is Win!");
                        break; 

                    }
                    Console.WriteLine("No,it is not a number " + i + "! Attempt no " + count + ":");
                    i = Convert.ToInt32(Console.ReadLine());
                }
                



            }
        }
    }
}
