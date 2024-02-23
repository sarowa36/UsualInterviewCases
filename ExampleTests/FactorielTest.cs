using Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTests
{
    public class FactorielTest
    {
        [Fact]
        public void ValidValue()
        {
            var result = Factoriel.Calculate(8);
            Assert.Equal(40320, result);
        }
    }
}
