using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Leetcode
{
    //https://leetcode.com/problems/remove-element/
    public  class RemoveElementFromArray
    {
        public  int RemoveElement(int[] nums, int val)
        {
            int totalRemoveCount = nums.Count(x => x != val);
            nums.Where(x => x != val).ToArray().CopyTo(nums, 0);
            return totalRemoveCount;
        }
    }
}
