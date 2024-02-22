using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Leetcode
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
    public class RemoveDuplicateFromArray2
    {
        public int RemoveDuplicates(int[] nums)
        {
            int i = 0;
            int removeCount = 0;
            while (i < nums.Length)
            {
                while (i - 2 >= 0 && i < nums.Length - removeCount && nums[i - 2] == nums[i])
                {
                    nums[i] = nums[0] - 1;
                    removeCount++;
                    for (int j = i; j < nums.Length - 1; j++)
                    {
                        int oldVal = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = oldVal;
                    }
                }
                i++;
            }
            return nums.Length - removeCount;
        }
    }
}
