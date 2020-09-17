using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if(c.ToString().Length == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public bool CharacterIsNotALetter(char c)
        {
            if (c >= 'A' && c <= 'Z') 
            {
                return true;
            }
            else if(c >= 'a' && c <= 'z')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int temp1 = 0;
            int temp = numbers.Count();
            numbers.DefaultIfEmpty(temp1);
            if (temp > 0)
            {
                double sum = numbers.Max() + numbers.Min();
                return sum;
            }
            else if(temp == 0)
            {
                return 0;
            }
            
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length >= str2.Length)
            {
                return str2.Length;
            }
            else if(str1.Length <= str2.Length)
            {
                return str1.Length;
            }
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            int num = 0;
            if(numbers == null)
            {
                return 0;
            }
            foreach (var item in numbers)
            {
                num += item;
            }
                return num;

            throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            foreach (var item in numbers)
            {
                if(item % 2 == 0)
                {
                    sum += item;
                }
            }
            return sum;

            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if(numbers == null)
            {
                return false;
            }
            foreach (var item in numbers)
            {
                sum += item;
            }
            if(sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if(number < 0)
            {
                return 0;
            }

            //why this no work?
            //----------------------------
            /*long count = 0;
            for (long i = 1; i < number; i++)
            {
                number -= i;
                if (number >= 0 && number % 2 != 0)
                {
                    count += 1;
                }
            }
            return count;*/

            return number / 2;

            throw new NotImplementedException();
        }
    }
}
