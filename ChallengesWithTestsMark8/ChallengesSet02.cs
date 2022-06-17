using System;
using System.Collections.Generic;
using System.Linq;

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

        }

        public double SumOfMinAndMax(IEnumerable<double> numbers) //done
        {
            if ((numbers == null) || (!numbers.Any()))
            {
                return 0;
            }
            else
            {
                return (numbers.Min() + numbers.Max());
            }
            
        }

        public int GetLengthOfShortestString(string str1, string str2) //done
        {
            var answer = (str1.Length > str2.Length) ? str2.Length : str1.Length;
            return answer;
        }

        public int Sum(int[] numbers)
        {
            if ((numbers == null) || (!numbers.Any()))
            {
                return 0;
            }

            int sum = 0;
            foreach (int num in numbers)
            {
               sum += num;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if ((numbers == null) || (!numbers.Any()))
            {
                return 0;
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if ((numbers == null) || (!numbers.Any()))
            {
                return false;
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
            }
            if (sum % 2 != 0)
            {
                return true;
            } else return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            List<long> numbers = new List<long>();
            for (int i = 1; i < number; i += 2)
            {
                numbers.Add(i);
            }
            return numbers.Count;
        }
    }
}
