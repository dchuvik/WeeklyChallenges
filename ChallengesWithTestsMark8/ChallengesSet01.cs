using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {       
        public bool AreTwoNumbersTheSame(int num1, int num2) //done
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

        public double Subtract(double minuend, double subtrahend) //done
        {
            return minuend - subtrahend;
            throw new NotImplementedException();
        }

        public int Add(int number1, int number2)//done
        {
            return number1 + number2;
            throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2) //done
        {
            if (number1 > number2)
            {
                return number2;
            }
            else return number1;
            throw new NotImplementedException();
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
            throw new NotImplementedException();
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return $"Hello!";
            }
            else
            {
                return $"Hello, {nameOfPerson}!";
            }           
            throw new NotImplementedException();
        }

        public string GetHey()
        {
            return "HEY!";
            throw new NotImplementedException();
        }
    }
}
