using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public static class StringReverser
    {
        /*
        public static string Reverse(string text) => string.Join("", text.ToArray().Reverse());
        */
        public static string Reverse(string text)
        {
            var sb=new StringBuilder(text);
            for (int i = 0; i < text.Length; i++)
            {
                sb[i] = text[text.Length-1-i];
            }
            return sb.ToString();
        }
    }
}
