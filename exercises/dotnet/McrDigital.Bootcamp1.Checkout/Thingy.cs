using System;

namespace apprentice_bootcamp_fundamentals_2
{
    public class Thingy
    {
        private int counter;
        private int number;
        private int fiveZerosLength = new int[] { 0, 0, 0, 0, 0 }.Length;

        public string AddNumbersToString()
        {
            string stringOfNumbers = "";
            for (; counter < Byte.MaxValue - 155; counter++) 
                stringOfNumbers += binary(counter) + " ";
            return stringOfNumbers.Substring(0, stringOfNumbers.Length - 1);
        }

        private string binary(int counter)
        {
            number++;
            fiveZerosLength--;

            string stringOfNumbers = number == 0b11 || fiveZerosLength == 0 ? "" : (counter + 1).ToString();
            if (number == 0b11) stringOfNumbers += ConvertHexBinaryToString();
            if (fiveZerosLength == 0) stringOfNumbers += ResetTheLengthOfZeros();
            return stringOfNumbers;
        }

        private string ResetTheLengthOfZeros()
        {
            fiveZerosLength = new int[] { 0, 0, 0, 0, 0 }.Length;
            return DataTypeConverter.ParseHexBinary("42757a7a");
        }

        private string ConvertHexBinaryToString()
        {
            number = 0;
            return DataTypeConverter.ParseHexBinary("46697a7a");
        }
    }
}
