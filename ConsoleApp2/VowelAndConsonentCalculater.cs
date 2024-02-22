using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public static class VowelAndConsonentCalculater
    {
        public static char[] Vowels = { 'u','ü','i','ı','o','ö','a','e' };
        public static int VowelCount(string text) => text.ToArray().Count(x => Vowels.Contains(x));
        public static int ConsonentCount(string text) => text.ToArray().Count(x => !Vowels.Contains(x));
    }
}
