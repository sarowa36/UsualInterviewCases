using Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTests
{
    public class PrimeTest
    {
        [Fact]
        public void ValidValue()
        {
            var result = Prime.Calculate(5);
            Assert.True(result);
        }
    }
}
