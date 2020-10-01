using System;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int num = 0;
            
            foreach (var item in numbers)
            {
                if(item % 2 == 0)
                {
                    num += item;
                }
                else
                {
                    num -= item;
                }
            }
            return num;
            
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            foreach (var item in str1)
            {
                num1++;
            }
            foreach (var item in str2)
            {
                num2++;
            }
            foreach (var item in str3)
            {
                num3++;
            }
            foreach (var item in str4)
            {
                num4++;
            }
            int max1 = Math.Min(num1, num2);
            int max2 = Math.Min(num3, num4);
            return Math.Min(max1, max2);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int max1 = Math.Min(number1, number2);
            int max2 = Math.Min(number3, number4);
            return Math.Min(max1, max2);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool a = sideLength1 + sideLength2 > sideLength3;
            bool b = sideLength1 + sideLength3 > sideLength2;
            bool c = sideLength2 + sideLength3 > sideLength1;

            return a && b && c;

        }

        public bool IsStringANumber(string input)
        {
            if(input == null || input == "")
            {
                return false;
            }
            else if(input.Any(x => char.IsLetter(x)) || input.Contains('*') || input.Contains('#'))
            {
                return false;
            }
            else
            {
            return (input.Any(x => char.IsSymbol(x)) || input.Any(x => char.IsNumber(x)));
            }
            
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullNum = 0;
            int notNull = 0;
            foreach (var item in objs)
            {
                if(item == null)
                {
                    nullNum++;
                }
                else
                {
                    notNull++;
                }
            }

            if(nullNum > notNull)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            double evens = 0;
            int count = 0;

            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            foreach (var item in numbers)
            {
                if(item % 2 == 0)
                {
                    evens += item;
                    count++;
                }
            }
            if(count <= 0)
            {
                return 0;
            }
            else if (numbers == null)
            {
                return 0;
            }
            else
            {
            return evens / count;
            }
        }

        public int Factorial(int number)
        {
            int res = 1;
            if (number == 0)
            {
                return 1;
            }
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            while(number != 1)
            {
                res = res * number;
                number = number - 1;
            }
            return res;
        }
    }
}
