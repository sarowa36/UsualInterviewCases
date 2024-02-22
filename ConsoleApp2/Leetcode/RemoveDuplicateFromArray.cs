using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Leetcode
{
    // https://leetcode.com/problems/remove-duplicates-from-sorted-array
    public  class RemoveDuplicateFromArray
    {
        public  int RemoveDuplicates(int[] nums)
        {
            int[] noDups = nums.Distinct().ToArray();
            noDups.CopyTo(nums, 0);
            return noDups.Length;
        }
    }
}
