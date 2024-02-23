using Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace ExampleTests
{
    public class StringReverserTest
    {
        private readonly ITestOutputHelper output;

        public StringReverserTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void ValidValue()
        {
            var text = "deneme";
            var result=StringReverser.Reverse(text);
            output.WriteLine(result);
            Assert.Equal("emened", result);
        }
    }
}
