using System;

namespace apprentice_bootcamp_fundamentals_2
{
    public class FizzBuzzGame
    {
        const int ONE_HUNDRED = Byte.MaxValue - 155;
        const int THREE = 0b11;
        const string BUZZ = "42757a7a";
        const string FIZZ = "46697a7a";

        private int counter;
        private int FromThreeToZero;
        private int fromZeroToFive = new int[] { 0, 0, 0, 0, 0 }.Length;

        public string FizzBuzz()
        {
            string stringOfNumbers = "";
            for (; counter < ONE_HUNDRED; counter++) 
                stringOfNumbers += FizzBuzzChecker(counter) + " ";
            return stringOfNumbers.Substring(0, stringOfNumbers.Length - 1);
        }

        private string FizzBuzzChecker(int counter)
        {
            FromThreeToZero++;
            fromZeroToFive--;

            var isFizz = FromThreeToZero == THREE;
            var isBuzz = fromZeroToFive == 0;
            var counterToString = (counter + 1).ToString();

            string stringOfNumbers = isFizz || isBuzz ? "" : counterToString;
            if (isFizz) stringOfNumbers += ResetFromThreeToZeroFizz();
            if (isBuzz) stringOfNumbers += ResetFromZeroToFiveBuzz();
            return stringOfNumbers;
        }

        private string ResetFromZeroToFiveBuzz()
        {
            fromZeroToFive = new int[] { 0, 0, 0, 0, 0 }.Length;
            return DataTypeConverter.ParseHexBinary(BUZZ);
        }

        private string ResetFromThreeToZeroFizz()
        {
            FromThreeToZero = 0;
            return DataTypeConverter.ParseHexBinary(FIZZ);
        }
    }
}
