using RomanToInteger;
using System;
using Xunit;

namespace Tests
{
    public class Test
    {
        private Solution s = new Solution();

        [Fact]
        public void Test1()
        {
            Assert.Equal(0, s.RomanToInt(String.Empty));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(14, s.RomanToInt("XIV"));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(5, s.RomanToInt("V"));
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal(2017, s.RomanToInt("MMXVII"));
        }

        [Fact]
        public void Test5()
        {
            Assert.Equal(3499, s.RomanToInt("MMMCDXCIX"));
        }
    }
}
