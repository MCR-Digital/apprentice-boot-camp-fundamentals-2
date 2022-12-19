using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout
{
    public class BowlingGame
    {
        public BowlingGame() { }

        public int GetTotalScore(int[] rolls)
        {
            int totalScore = 0;

            foreach (int roll in rolls)
            {
                totalScore += roll;
            }

            return totalScore;
        }
    }
}
