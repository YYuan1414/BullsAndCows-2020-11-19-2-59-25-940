using BullsAndCows;
using Xunit;

namespace BullsAndCowsTest
{
    public class BullsAndCowsGameTest
    {
        [Fact]
        public void Should_create_BullsAndCowsGame()
        {
            var testSecretGenerator = new TestSecretGernerate();
            var game = new BullsAndCowsGame(testSecretGenerator);
            Assert.NotNull(game);
            Assert.True(game.CanContinue);
        }

        [Fact]
        public void Should_create_0A0B_When_All_Digital_And_Position_Wrong()
        {
            var testSecretGenerator = new TestSecretGernerate();
            var game = new BullsAndCowsGame(testSecretGenerator);
            string answer = game.Guess("5678");

            Assert.Equal($"0A0B", answer);
        }

        [Fact]
        public void Should_create_4A0B_When_Digital_Right_But_Position_Wrong()
        {
            var testSecretGenerator = new TestSecretGernerate();
            var game = new BullsAndCowsGame(testSecretGenerator);
            string answer = game.Guess("1234");

            Assert.Equal($"4A0B", answer);
        }
    }

    public class TestSecretGernerate : SecretGenerator
    {
        public override string GenerateSecret()
        {
            return "1234";
        }
    }
}
