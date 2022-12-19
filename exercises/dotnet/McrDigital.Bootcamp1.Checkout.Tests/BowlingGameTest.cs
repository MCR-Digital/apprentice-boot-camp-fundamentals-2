using Xunit;
using McrDigital.Bootcamp1.Checkout;


namespace McrDigital.Bootcamp1.Checkout.Tests
{
    public class BowlingGameTests
    {
        [Fact]
        public void WhenNotKnockingAnyRolls_ReturnsTotalScoreAsZero()
        {
            //arrange
            var bowlingGame = new BowlingGame();

            int[] rolls = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int totalScore = 0;

            //act
            bowlingGame.GetTotalScore(rolls);

            //assert
            Assert.Equal(totalScore, bowlingGame.GetTotalScore(rolls));
        }

        [Fact]
        public void WhenKnockingOneRoll_ReturnsTotalScoreAsOne()
        {
            //arrange
            var bowlingGame = new BowlingGame();

            int[] rolls = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
            int totalScore = 1;

            //act
            bowlingGame.GetTotalScore(rolls);

            //assert
            Assert.Equal(totalScore, bowlingGame.GetTotalScore(rolls));
        }

        [Fact]
        public void WhenKnockingOneRollInEachGame_ReturnsTotalScoreAsTwenty()
        {
            //arrange
            var bowlingGame = new BowlingGame();

            int[] rolls = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int totalScore = 20;

            //act
            bowlingGame.GetTotalScore(rolls);

            //assert
            Assert.Equal(totalScore, bowlingGame.GetTotalScore(rolls));
        }
    }
}