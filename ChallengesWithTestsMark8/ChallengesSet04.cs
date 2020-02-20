using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers.Length == 0)
                return 0;
            var total = 0;
            foreach(var num in numbers)
            {
                if (num % 2 == 0)
                    total += num;
                if (num % 2 != 0)
                    total -= num;
            }
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int>();
            list.Add(str1.Length);
            list.Add(str2.Length);
            list.Add(str3.Length);
            list.Add(str4.Length);
            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>();
            list.Add(number1);
            list.Add(number2);
            list.Add(number3);
            list.Add(number4);
            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var sideList = new List<int>();
            sideList.AddRange(new List<int>() {sideLength1, sideLength2, sideLength3});
            var orderedList = sideList.OrderByDescending(n => n).ToArray();
            if (orderedList[2] + orderedList[1] > orderedList[0])
                return true;
            else
                return false;
        }

        public bool IsStringANumber(string input)
        {
            return Double.TryParse(input, out Double result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nulls = objs.Where(n => n == null);
            if (nulls.Count() > (objs.Length / 2))
                return true;
            else
                return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;
            var evens = new List<int>();
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                    evens.Add(num);
            }
            if (evens.Count == 0 || evens == null)
                return 0;
            return evens.Average();
        }

        public int Factorial(int number)
        {
            if (number == 0)
                return 1;
            if (number < 0)
                throw new ArgumentOutOfRangeException();
            var fact = 1;
            while (number != 1)
            {
                fact = fact * number;
                number = number - 1;
            }
            return fact;
        }
    }
}
