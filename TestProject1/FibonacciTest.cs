using Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTests
{
    public class FibonacciTest
    {
        [Fact]
        public void ValidValue()
        {
            var result = Fibonacci.Calculate(20);
            Assert.Equal(6765, result);
        }
    }
}
