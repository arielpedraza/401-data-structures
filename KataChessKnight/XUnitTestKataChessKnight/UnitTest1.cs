using System;
using Xunit;
using KataChessKnight;

namespace XUnitTestKataChessKnight
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(2, Program.ChessKnight("a1"));
            Assert.Equal(6, Program.ChessKnight("c2"));
            Assert.Equal(8, Program.ChessKnight("d4"));
            Assert.Equal(6, Program.ChessKnight("g6"));
        }
    }
}
