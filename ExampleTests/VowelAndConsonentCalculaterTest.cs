using Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTests
{
    public class VowelAndConsonentCalculaterTest
    {
        [Fact]
        public void VowelCount()
        {
            var text = "ece";
            var result=VowelAndConsonentCalculater.VowelCount(text);
            Assert.Equal(2, result);
        }
        [Fact]
        public void ConsonentCount()
        {
            var text = "ece";
            var result = VowelAndConsonentCalculater.ConsonentCount(text);
            Assert.Equal(1, result);
        }
    }
}
