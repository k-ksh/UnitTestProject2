using System;

namespace UnitTestProject
{
    class Calculator
    {
        public static int SumTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int DivideTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
        public static int MultiplyTwoNumbers(int firstNumber, int secondNumber)
        {
            if (!IsValidNumber(firstNumber) || !IsValidNumber(secondNumber))
            {
                throw new ArgumentException("Invalid input: numbers should be between -1000 and 1000 inclusive.");
            }
            return firstNumber * secondNumber;
        }

        private static bool IsValidNumber(int num)
        {
            return num >= -1000 && num <= 1000;
        }

    }
}