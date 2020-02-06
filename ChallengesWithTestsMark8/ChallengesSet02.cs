﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
                return true;
            else
                return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
                return true;
            else
                return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
                return 0;
            else
                return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length || str1.Length == str2.Length)
                return str1.Length;
            else
                return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
                return 0;
            else
                return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
                return 0;
            var evens = numbers.Where(item => item % 2 == 0);
                return evens.Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;
            else if (numbers.Sum() % 2 != 0) 
                return true;
            else
                return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number > 0)
                return number / 2;
            else
                return 0;
        }
    }
}
