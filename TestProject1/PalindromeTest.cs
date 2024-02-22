using Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTests
{
    public class PalindromeTest
    {
        [Fact]
        public void SendingPalindromeValue()
        {
            var text = "ece";

            var result=Palindrome.IsPalindrome(text);

            Assert.True(result);
        }
        [Fact]
        public void SendingNotPalindromeValue()
        {
            var text = "123456";

            var result = Palindrome.IsPalindrome(text);

            Assert.False(result);
        }
    }
}
