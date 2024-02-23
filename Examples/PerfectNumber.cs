using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public static class PerfectNumber
    {
        public static bool Calculate(int num)
        {
            var dividers = new List<int>();
            for (int i = 1; i <= num/2; i++)
            {
                if(num%i==0)
                    dividers.Add(i);
            }
            return dividers.Sum()==num ;
        }
    }
}
