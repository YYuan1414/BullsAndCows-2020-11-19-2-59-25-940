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
                if (checkValid.IsValid(input))
                {
                    var output = game.Guess(input);
                    Console.WriteLine(output);
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("Game Over");
        }
    }
}