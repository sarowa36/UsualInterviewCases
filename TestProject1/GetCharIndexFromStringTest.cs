using Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTests
{
    public class GetCharIndexFromStringTest
    {
        [Fact]
        public void ValidTest()
        {
            var text = "silent";
            var ch = 'l';
            var result=GetCharIndexFromString.Get(text, ch);
            Assert.Equal(2,result);
        }
    }
}
