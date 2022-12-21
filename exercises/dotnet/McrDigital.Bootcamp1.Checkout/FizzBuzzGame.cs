using System;

namespace apprentice_bootcamp_fundamentals_2
{
    public class FizzBuzzGame
    {
        const int ONE_HUNDRED = Byte.MaxValue - 155;
        const int THREE = 0b11;
        const string BUZZ_AS_HEX = "42757a7a";
        const string FIZZ_AS_HEX = "46697a7a";

        private int counter;
        private int FromThreeToZero;
        private int fromZeroToFive = new int[] { 0, 0, 0, 0, 0 }.Length;

        public string Spaces()
        {
            string stringOfNumbers = "";

            for (; counter < ONE_HUNDRED; counter++)
                stringOfNumbers += FizzBuzzChecker(counter) + " ";

            return RemovingEndSpace(stringOfNumbers);
        }

        private static string RemovingEndSpace(string stringOfNumbers)
        {
            return stringOfNumbers.Substring(0, stringOfNumbers.Length - 1);
        }

        private string FizzBuzzChecker(int counter)
        {
            FromThreeToZero++;
            fromZeroToFive--;

            var isFizz = FromThreeToZero == THREE;
            var isBuzz = fromZeroToFive == 0;
            var counterToString = (counter + 1).ToString();

            string stringOfNumbers = GetEmptyStringOrNumber(isFizz, isBuzz, counterToString);
            if (isFizz) stringOfNumbers += ResetFromThreeToZeroFizz();
            if (isBuzz) stringOfNumbers += ResetFromZeroToFiveBuzz();
            return stringOfNumbers;
        }

        private static string GetEmptyStringOrNumber(bool isFizz, bool isBuzz, string counterToString)
        {
            return isFizz || isBuzz ? "" : counterToString;
        }

        private string ResetFromZeroToFiveBuzz()
        {
            fromZeroToFive = new int[] { 0, 0, 0, 0, 0 }.Length;
            return DecodeHexString(BUZZ_AS_HEX);
        }

        private string ResetFromThreeToZeroFizz()
        {
            FromThreeToZero = 0;
            return DecodeHexString(FIZZ_AS_HEX);
        }

        private static string DecodeHexString(string hex)
        {
            return DataTypeConverter.ParseHexBinary(hex);
        }
    }
}
