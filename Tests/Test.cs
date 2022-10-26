using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PetersTests.Solutions;

namespace PetersTests.Tests
{
    public class Test
    {
        
        [Fact]
        public void normalSequence()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            int expected = 6;
            int actual = Test1.Solution(values);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void brokenSequence()
        {
            int[] values = { 1, 2, 4, 5, 10 };
            int expected = 3;
            int actual = Test1.Solution(values);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void brokenSequence2()
        {
            int[] values = { 3, 4, 5, 6 };
            int expected = 1;
            int actual = Test1.Solution(values);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void zerosAndNegatives()
        {
            int[] values = { 0, 0 , 0, -1, -2};
            int expected = 1;
            int actual = Test1.Solution(values);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void empty()
        {
            int[] values = { };
            int expected = 1;
            int actual = Test1.Solution(values);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void bigNumbers()
        {
            long[] values = { 2147483645, 2147483646, 2147483647 };
            long expected = 1;
            long actual = Test1.Solution(values);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void smallNumbers()
        {
            long[] values = { 2147483645, 2147483646, 2147483647, -9999999 };
            long expected = 1;
            long actual = Test1.Solution(values);
            Assert.Equal(expected, actual);
        }
    }
}
