using Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTests
{
    public class PerfectNumberTest
    {
        [Fact]
        public void ValidTest()
        {
            var result = PerfectNumber.Calculate(6);
            Assert.True(result);
        }
        [Fact]
        public void InvalidTest()
        {
            var result = PerfectNumber.Calculate(10);
            Assert.False(result);
        }
    }
}
