using System;
using BullsAndCows;

namespace BullsAndCowsRunner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SecretGenerator secretGenerator = new SecretGenerator();
            CheckValid checkValid = new CheckValid();
            BullsAndCowsGame game = new BullsAndCowsGame(secretGenerator);
            while (game.CanContinue)
            {
                var input = Console.ReadLine();
                while (!checkValid.IsValid(input))
                {
                    Console.WriteLine("Wrong Input, input again");
                    input = Console.ReadLine();
                }

                var output = game.Guess(input);
                Console.WriteLine(output);
            }

            Console.WriteLine("Game Over");
        }
    }
}