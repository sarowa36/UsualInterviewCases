using Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTests
{
    public class BubbleSortTest
    {
        [Fact]
        public void IsValid() {
            int[] ary = { 0,3,5,2,1 };
            BubbleSort.Sort(ary);
            Assert.True(ary.SequenceEqual(new int[]{0,1,2,3,5 }));
        }
    }
}
