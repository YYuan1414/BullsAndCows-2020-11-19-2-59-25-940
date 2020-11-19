using BullsAndCows;
using Moq;
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

        [Theory]
        [InlineData("1 2 3 4", "1234")]
        [InlineData("5 6 7 8", "5678")]
        public void Should_create_4A0B_When_Digital_Right_But_Position_Wrong(string guess, string secret)
        {
            var mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(mock => mock.GenerateSecret()).Returns(secret);
            //var testSecretGenerator = new TestSecretGernerate();
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            string answer = game.Guess(guess);

            Assert.Equal($"4A0B", answer);
        }

        [Theory]
        [InlineData("1 4 2 3", "1234")]
        [InlineData("7 5 6 8", "5678")]
        public void Should_create_2A2B_When_Digital_Right_But_Position_Are_Not_all_Wrong(string guess, string secret)
        {
            var mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(mock => mock.GenerateSecret()).Returns(secret);
            //var testSecretGenerator = new TestSecretGernerate();
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            string answer = game.Guess(guess);

            Assert.Equal($"1A3B", answer);
        }

        [Theory]
        [InlineData("1 4 2 3")]
        public void Should_Return_True_For_Valid_Guess(string guess)
        {
            var checkValid = new CheckValid();
            Assert.True(checkValid.IsValid(guess));
        }

        [Theory]
        [InlineData("1 2 3")]
        [InlineData("a 2 3")]
        [InlineData("123")]
        [InlineData("1 1 3")]
        public void Should_Return_False_For_Valid_Guess(string guess)
        {
            var checkValid = new CheckValid();
            Assert.False(checkValid.IsValid(guess));
        }

        [Theory]
        [InlineData("1 5 2 3", "1234")]
        [InlineData("7 8 6 8", "5678")]
        public void Should_create_1A2B_When_Digital_And_Position_Are_Not_all_Wrong(string guess, string secret)
        {
            var mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(mock => mock.GenerateSecret()).Returns(secret);
            //var testSecretGenerator = new TestSecretGernerate();
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            string answer = game.Guess(guess);

            Assert.Equal($"1A2B", answer);
        }

        [Theory]
        [InlineData("6 5 2 3", "1234")]
        [InlineData("7 1 4 5", "5678")]
        public void Should_create_1A2B_When_Digital_Not_All_Right_And_Position_Are_all_Wrong(string guess, string secret)
        {
            var mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(mock => mock.GenerateSecret()).Returns(secret);
            //var testSecretGenerator = new TestSecretGernerate();
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            string answer = game.Guess(guess);

            Assert.Equal($"0A2B", answer);
        }

        [Theory]
        [InlineData("4 3 2 1")]
        [InlineData("4 3 1 2")]
        public void Should_create_0A4B_When_Digital_Right_But_Position_Wrong(string guess)
        {
            var testSecretGenerator = new TestSecretGernerate();
            var game = new BullsAndCowsGame(testSecretGenerator);
            string answer = game.Guess(guess);

            Assert.Equal($"0A4B", answer);
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
