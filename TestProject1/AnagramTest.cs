using Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTests
{
    public class AnagramTest
    {
        [Fact]
        public void ControlValidValue()
        {
            string text1 = "silent";
            string text2 = "listen";
            var result=Anagram.Check(text1, text2);
            Assert.True(result);
        }
        [Fact]
        public void ControlInValidValue()
        {
            string text1 = "talent";
            string text2 = "listen";
            var result = Anagram.Check(text1, text2);
            var result2= Anagram.Check("123"+text1, text2);
            Assert.False(result);
            Assert.False(result2);
        }
    }
}
