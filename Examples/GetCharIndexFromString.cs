using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public static class GetCharIndexFromString
    {
        /*public static int Get(string text,char ch)=>text.IndexOf(ch);*/
        public static int Get(string text, char ch)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ch)
                    return i;
            }
            return -1;
        }
    }
}
