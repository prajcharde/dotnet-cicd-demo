namespace DotnetCICDTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = 5;
            int b = 5;

            Assert.Equal(10, a + b);
        }
    }
}