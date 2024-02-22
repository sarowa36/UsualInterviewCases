using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Leetcode
{
    // https://leetcode.com/problems/merge-sorted-array/
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m; i < m + n; i++)
            {
                nums1[i] = nums2[i - m];
            }
            nums1.Order().ToArray().CopyTo(nums1, 0);

            var orderedValues = nums1.Order().ToList();
            for (int i = 0; i < orderedValues.Count(); i++)
                nums1[i] = orderedValues[i];
        }
    }
}
