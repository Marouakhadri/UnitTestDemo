using Xunit;
using UnitTestDemo;

namespace xTestDemo
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Multiply(10, 10);
            Assert.Equal(100, res);
        }
        [Fact]
        public void Test_AddMethod()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Add(10, 10);
            Assert.Equal(20,res);
        }
    }
}