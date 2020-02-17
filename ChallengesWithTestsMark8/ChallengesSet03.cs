using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false))
                return true;
            else
                return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
                return false;
            var oddList = numbers.Where(n => n % 2 != 0);
            if (oddList.Sum() % 2 != 0)
                return true;
            else
                return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
                return true;
            else
                return false;
        }

        public bool PasswordContainsUpperLowerAndNumberNoLinq(string password)
        {
            var isLower = false;
            var isUpper = false;
            var isNumber = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                    isLower = true;
                if (char.IsUpper(password[i]))
                    isUpper = true;
                if (char.IsNumber(password[i]))
                    isNumber = true;
            }
            if (isLower && isUpper && isNumber)
                return true;
            else
                return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            var letters = new String(val.ToArray());
            return letters[0];
        }

        public char GetLastLetterOfString(string val)
        {
            var letters = new String(val.ToArray());
            return letters.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            else
                return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            var newList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                    newList.Add(i);
            }
            return newList.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
