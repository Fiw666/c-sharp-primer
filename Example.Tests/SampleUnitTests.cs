using System;
using Xunit;

using fizzy;

namespace Example.Tests
{
    public class SampleUnitTests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, 2 + 2);
            var fizz = new fizzbuzz();
            Assert.Equal("fizz", fizz.getname(3));
        }
        [Fact]
        public void Test1()
        {
            var fizz = new fizzbuzz();
            Assert.Equal("1", fizz.getname(1));
        }
        [Fact]
        public void Test2()
        {
            var fizz = new fizzbuzz();
            Assert.Equal("4", fizz.getname(4));
        }
        [Fact]
        public void Test3()
        {
            var fizz = new fizzbuzz();
            Assert.Equal("fizz", fizz.getname(6));
        }
        [Fact]
        public void Test4()
        {
            var fizz = new fizzbuzz();
            Assert.Equal("fizzbuzz", fizz.getname(15));
        }
        [Fact]
        public void Test12()
        {
            var fizz = new fizzbuzz();
            Assert.Equal("fizz", fizz.getname(12));
        }
        [Fact]
        public void FailingTest()
        {
            Assert.Equal(4, 2 + 2);
        }
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        [Theory]
        public void TestForFizz(int number)
        {
            var fizz = new fizzbuzz();
            Assert.Equal("fizz", fizz.getname(number));
        }
        [Fact]
        public void ListTest()
        {
            var fizz = new fizzbuzz();
            Assert.Equal("1,2,fizz", fizz.getlist(3));
        }
        [Fact]
        public void ListTest2()
        {
            var fizz = new fizzbuzz();
            Assert.Equal("1,2,fizz,4", fizz.getlist(4));
        }
    }
}
