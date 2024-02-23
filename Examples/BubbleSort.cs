using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public static class BubbleSort
    {
        public static void Sort(int[] ary)
        {//0,2, 6,5,3
            for (int i = 0; i < ary.Length; i++)
            {
                for(int j = 0; j < ary.Length - i - 1; j++)
               {
                   if (ary[j] > ary[j+1]) { 
                    var a = ary[j];
                        ary[j] = ary[j+1];
                        ary[j+1] = a;
                    }
                }
            }
        }
    }
}
