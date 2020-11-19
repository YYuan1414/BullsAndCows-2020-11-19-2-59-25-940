using System;

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
            return Compare(this.secret, guess);
        }

        private string Compare(string secret, string guess)
        {
            //int equalNumber = 0;
            //
            //foreach (var digital in secret)
            //{
            //    if (guess.Contains(digital))
            //    {
            //        equalNumber++;
            //    }
            //}
            //for (position=0;p)
            if (secret == guess)
            {
                return "4A0B";
            }

            return "0A0B";
        }
    }
}