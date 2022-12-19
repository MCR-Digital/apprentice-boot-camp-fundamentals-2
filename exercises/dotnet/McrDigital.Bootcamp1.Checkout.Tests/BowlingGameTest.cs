using Xunit;
using McrDigital.Bootcamp1.Checkout;


namespace McrDigital.Bootcamp1.Checkout.Tests
{
    public class BowlingGameTests
    {
        int expectedTotalScore = 0;
        [Fact]
        public void WhenKnockingNoPins_ReturnTotalScore()
        {
            //arrange
            var bowlingGame = new BowlingGame();

            int[] rolls = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            expectedTotalScore = 0;

            //act
            var getTotalScore = bowlingGame.GetTotalScore(rolls);

            //assert
            Assert.Equal(expectedTotalScore, getTotalScore);
        }

        [Fact]
        public void WhenKnockingOnePin_ReturnTotalScore()
        {
            //arrange
            var bowlingGame = new BowlingGame();

            int[] rolls = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
            expectedTotalScore = 1;

            //act
            var getTotalScore = bowlingGame.GetTotalScore(rolls);

            //assert
            Assert.Equal(expectedTotalScore, getTotalScore);
        }

        [Fact]
        public void WhenKnockingOnePinInEachRoll_ReturnTotalScore()
        {
            //arrange
            var bowlingGame = new BowlingGame();

            int[] rolls = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            expectedTotalScore = 20;

            //act
            var getTotalScore = bowlingGame.GetTotalScore(rolls);

            //assert
            Assert.Equal(expectedTotalScore, getTotalScore);
        }

        [Fact]
        public void WhenKnockingDifferentPinsInEachRoll_ReturnTotalScore()
        {
            //arrange
            var bowlingGame = new BowlingGame();
            int[] rolls = { 5, 5, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            expectedTotalScore = 12;

            //act
            var getTotalScore = bowlingGame.GetTotalScore(rolls);

            //assert
            Assert.Equal(expectedTotalScore, getTotalScore);
        }
    }
}