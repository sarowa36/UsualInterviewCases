using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class Anagram
    {
       /* public static bool Check(string text1, string text2)=> text1 == text2 ? true : 
                text1.Length==text2.Length ? text1.ToArray().Order().SequenceEqual(text2.ToArray().Order()) : 
                false;*/
        public static bool Check(string text1, string text2)
        {
            text1 = OrderText(text1);
            text2 = OrderText(text2);
            return text1== text2;
        }
        public static string OrderText(string text)
        {
            StringBuilder sb = new StringBuilder(text);
            for (int i = 0; i < sb.Length; i++)
            {
                for (int j = 0; j < sb.Length-i-1; j++)
                {
                    if (sb[j] > sb[j + 1])
                    {
                        var temp = sb[j];
                        sb[j] = sb[j + 1];
                        sb[j + 1] = temp;
                    }
                }
            }
            return sb.ToString();
        }

    }
}
