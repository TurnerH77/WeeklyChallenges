using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double subNum = (minuend - subtrahend);
            return subNum;
            throw new NotImplementedException();
        }

        public int Add(int number1, int number2)
        {
            int addedNum = (number1 + number2);
            return addedNum;
            throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if(number1 > number2)
            {
                return number2;
            }
            else if(number2 > number1)
            {
                return number1;
            }
            else if (number1 == number2)
            { return number1; }
            throw new NotImplementedException();
        }

        public long Multiply(long factor1, long factor2)
        {
            long multipNum = (factor1 * factor2);
            return multipNum;
            throw new NotImplementedException();
        }

        public string GetGreeting(string nameOfPerson)
        {
            string greeting = "";
            if (nameOfPerson == "")
            {
                 greeting = "Hello!";
            }
            else
            {
                greeting = "Hello, " + nameOfPerson + "!";
            }
            return greeting;
        }

        public string GetHey()
        {
            string hey = "HEY!";
            return hey;
            throw new NotImplementedException();
        }
    }
}
