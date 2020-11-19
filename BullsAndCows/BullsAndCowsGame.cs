using System;
using System.Linq;

namespace BullsAndCows
{
    public class BullsAndCowsGame
    {
        private readonly SecretGenerator secretGenerator;
        private readonly string secret = string.Empty;
        public BullsAndCowsGame(SecretGenerator secretGenerator)
        {
            this.secretGenerator = secretGenerator;
            this.secret = this.secretGenerator.GenerateSecret();
        }

        public bool CanContinue => true;

        public string Guess(string guess)
        {
            var guessWithoutSpace = guess.Replace(" ", string.Empty);
            return Compare(this.secret, guessWithoutSpace);
        }

        private string Compare(string secret, string guess)
        {
            int equalNumber = 0;
            int position = 0;
            int cows = 0;
            int bulls = 0;

            foreach (var digital in secret)
            {
                if (guess.Contains(digital))
                {
                    equalNumber++;
                }
            }

            for (position = 0; position < 4; position++)
            {
                if (guess[position] == secret[position])
                {
                    bulls++;
                }
            }

            cows = equalNumber - bulls;
            return bulls.ToString() + "A" + cows.ToString() + "B";
        }
    }
}