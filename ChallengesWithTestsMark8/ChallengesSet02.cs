using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c) // done
        {
            if (Char.IsLetter(c))
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals) //done
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

        public bool IsNumberEven(int number) //done
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num) //done
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
            throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double.Max(numbers)
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
