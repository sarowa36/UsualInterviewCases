using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public static class InsertionSort
    {
        public static void Sort(int[] ary)
        {
            for (int i = 1; i < ary.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (ary[j] < ary[j - 1])
                    {
                        var a = ary[j - 1];
                        ary[j - 1] = ary[j];
                        ary[j] = a;
                    }
                }
            }
        }
    }
}
