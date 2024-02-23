using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public static class Prime
    {
        public static bool Calculate(int num)
        {
            if(num == 0 || num==1) return false;
            for (int i = 2; i < num/2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
