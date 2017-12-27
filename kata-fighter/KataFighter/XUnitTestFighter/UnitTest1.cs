using System;
using Xunit;
using KataFighter;

namespace XUnitTestFighter
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Lew", Program.DeclareWinner(new Fighter("Lew", 10, 2), new Fighter("Harry", 5, 4), "Lew"));
            Assert.Equal("Harry", Program.DeclareWinner(new Fighter("Lew", 10, 2), new Fighter("Harry", 5, 4), "Harry"));
            Assert.Equal("Harald", Program.DeclareWinner(new Fighter("Harald", 20, 5), new Fighter("Harry", 5, 4), "Harry"));
            Assert.Equal("Harald", Program.DeclareWinner(new Fighter("Harald", 20, 5), new Fighter("Harry", 5, 4), "Harald"));
            Assert.Equal("Harald", Program.DeclareWinner(new Fighter("Jerry", 30, 3), new Fighter("Harald", 20, 5), "Jerry"));
            Assert.Equal("Harald", Program.DeclareWinner(new Fighter("Jerry", 30, 3), new Fighter("Harald", 20, 5), "Harald"));
        }
    }
}
