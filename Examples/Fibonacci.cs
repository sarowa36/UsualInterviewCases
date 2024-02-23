using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public static class Fibonacci
    {
        public static int Calculate(int num)
        {
            if (num <= 1)
                return num;
            return Calculate(num - 1)+Calculate(num-2);
        }
    }
}
