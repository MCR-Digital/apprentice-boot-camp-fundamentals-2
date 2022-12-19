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
            return rolls.Sum();
        }
    }
}
