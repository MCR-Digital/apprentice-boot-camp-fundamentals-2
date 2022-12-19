using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout
{
    public class BowlingGame
    {
        public BowlingGame() { }

        public int GetTotalScore(int[] rolls)
        {
            int totalScore = 0;
            int[] frameScore = new int[10];
            

            for (int frame = 0; frame < 20; frame+=2)
            {
                frameScore[frame/2] = rolls[frame] + rolls[frame + 1];
                totalScore += frameScore[frame / 2];
            }

            return totalScore;
        }
    }
}
