using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n) //done
        {
            //var i = startNumber;
            //do
            //{
            //    i++;
            //}
            //while (i % n != 0);
            //return i;        

            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses) //Done
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers) //done
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;

        }

        public int SumElementsThatFollowAnEven(int[] numbers) // Done
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var sum = 0;
            for (int n = 1; n < numbers.Length; n++)
            {
                if (numbers[n - 1] % 2 == 0)
                {
                    sum += numbers[n];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words) //Done
        {
            var sentence = "";
            if (words == null || words.Length == 0)
            {
                return "";
            }

            foreach (var word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }

            if (sentence.Length == 0)
            {
                return "";
            }

            sentence = sentence.Trim();
            sentence += ".";
            return sentence;

        }

        public double[] GetEveryFourthElement(List<double> elements) //Done
        {
            List<double> result = new List<double>();

            if (elements == null || elements.Count == 0)
            {
                return result.ToArray();
            }

            foreach (var element in elements)
            {
                if (element % 4 == 0)
                {
                    result.Add(element);
                }
            }
            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
