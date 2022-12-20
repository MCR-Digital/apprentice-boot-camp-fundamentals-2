using System;

namespace apprentice_bootcamp_fundamentals_2
{
    public class FizzBuzzGame
    {
        private int counter;
        private int FromThreeToZero;
        private int fromZeroToFive = new int[] { 0, 0, 0, 0, 0 }.Length;

        public string FizzBuzz()
        {
            string stringOfNumbers = "";
            for (; counter < Byte.MaxValue - 155; counter++) 
                stringOfNumbers += FizzBuzzChecker(counter) + " ";
            return stringOfNumbers.Substring(0, stringOfNumbers.Length - 1);
        }

        private string FizzBuzzChecker(int counter)
        {
            FromThreeToZero++;
            fromZeroToFive--;

            var isFizz = FromThreeToZero == 0b11;
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
            return DataTypeConverter.ParseHexBinary("42757a7a");
        }

        private string ResetFromThreeToZeroFizz()
        {
            FromThreeToZero = 0;
            return DataTypeConverter.ParseHexBinary("46697a7a");
        }
    }
}
