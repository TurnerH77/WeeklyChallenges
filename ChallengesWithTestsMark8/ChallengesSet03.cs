using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if(vals[i] == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int sum = numbers.Sum(x => Convert.ToInt32(x));
            
            if(sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if(password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            char l = Convert.ToChar(val.Substring(0, 1));
            return l;
        }

        public char GetLastLetterOfString(string val)
        {
            char l = Convert.ToChar(val.Substring(val.Length - 1, 1));
            return l;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }    
            decimal div = dividend / divisor;
            return div;
        }

        public int LastMinusFirst(int[] nums)
        {
            int x = nums[nums.Length - 1] - nums[0];
            return x;
        }

        public int[] GetOddsBelow100()
        {
            List<int> l = Enumerable.Range(1, 100).ToList();

            var oddNums = l.Where(num => num % 2 != 0);
            return oddNums.ToArray();
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
