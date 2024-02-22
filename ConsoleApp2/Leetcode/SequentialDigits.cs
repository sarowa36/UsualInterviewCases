using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Leetcode
{
    //https://leetcode.com/problems/sequential-digits/
    public class SequentialDigitsCalculator
    {
        public IList<int> SequentialDigits(int low, int high)
        {
            List<int> returnValue = new();
            for (int i = 1; i < 9; i++)
            {
                int num = i;
                int nextNum = i + 1;
                while (num <= high && nextNum <= 9)
                {
                    num = (num * 10) + nextNum;
                    if (num >= low && num <= high)
                        returnValue.Add(num);
                    nextNum++;
                }
            }
            returnValue.Sort();
            return returnValue;
        }
    }
}
