using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals) //done
        {
            foreach (var val in vals)

                if (val == false)
                {
                    return true;
                }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers) //done
        {
            List<int> oddCategory = new List<int>();

            if ((numbers == null) || (!numbers.Any()))
            {
                return false;
            }

            foreach (int num in numbers)
            {
                if (num % 2 != 0)
                {
                    oddCategory.Add(num);
                }
            }

            if (oddCategory.Sum() % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password) //done
        {
            //for (int i = 0; i < password.Length; i++)
            foreach (char c in password)
            {
                if ((password.Any(char.IsDigit) && (password.Any(char.IsUpper)) && (password.Any(char.IsLower))))
                    {
                    return true;
                }
                
            }
            return false;
        }

        public char GetFirstLetterOfString(string val) //done
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)//done
        {
            int lastChar = val.Length - 1;
            return val[lastChar];
        }

        public decimal Divide(decimal dividend, decimal divisor) //done
        {
            if (dividend == 0||divisor == 0)
            {
                return 0;
            } else 
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums) //done
        {
            int lastNum = nums.Length - 1;
            return nums[lastNum] - nums[0];
        }

        public int[] GetOddsBelow100() //done
        {
            List<int> odds = new List<int>();
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words) //done
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
