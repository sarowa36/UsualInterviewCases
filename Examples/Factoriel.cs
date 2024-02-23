using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public static class Factoriel
    {
        public static int Calculate(int num)
        {
            if(num == 1) return 1;
            return num*Calculate(num-1);
        }
    }
}
