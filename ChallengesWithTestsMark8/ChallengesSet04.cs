using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers) //Done
        {
            int x = 0;
            foreach (var numb in numbers)
            {
                if (numb % 2 == 0)
                {
                    x += numb;
                }
                else if (numb % 2 != 0)
                {
                    x -= numb;
                }
            }
            return x;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4) //Done
        {
            string[] strings = { str1, str2, str3, str4 };
            return strings.Min(y => y.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4) // Done
        {
            int[] nums = { number1, number2, number3, number4 };
            return nums.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3) //Done
        {
            return (sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 && 
                sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input) // done
        {
            double i = 0;
            return double.TryParse(input, out i);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            List<object> nullList = new List<object>();
            List<object> notNullList = new List<object>();
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    nullList.Add(objs[i]);
                }
                else
                {
                    notNullList.Add(objs[i]);
                }
            }
            if (nullList.Count > notNullList.Count)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers) //Done
        {
            if ((numbers == null) || (!numbers.Any()))
            {
                return 0;
            }
            List<int> Evens = new List<int>();
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    Evens.Add(num);
                }
            }
            if ((Evens == null) || (!Evens.Any()))
            {
                return 0;
            }
            else return Evens.Average();
        }

        public int Factorial(int number) //Done
        {

            if (number == 1 || number == 0)
            {
                return 1;
            }
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = (number - 1); i > 0; i--)
            {
                number = number * i;
            }
            return number;
        }
    }
}
