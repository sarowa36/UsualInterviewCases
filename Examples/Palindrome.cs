using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public static class Palindrome
    {
        public static bool IsPalindrome(string text)=>text==StringReverser.Reverse(text);
    }
}
