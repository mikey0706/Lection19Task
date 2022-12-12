using Lection19Task;

namespace UnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, 2, '+')]
        public void AdditionTest(int x, int y, char op)
        {
            var calc = new ConcreteCalculator();
            Assert.Equal(x + y, calc.CalcData(x, y, op));
        }

        [Theory]
        [InlineData(3, 2, '-')]
        public void SubstractionTest(int x, int y, char op)
        {
            var calc = new ConcreteCalculator();
            Assert.Equal(x - y, calc.CalcData(x, y, op));
        }


        [Theory]
        [InlineData(3, 2, '*')]
        public void MultiplicationTest(int x, int y, char op)
        {
            var calc = new ConcreteCalculator();
            Assert.Equal(x * y, calc.CalcData(x, y, op));
        }

        [Theory]
        [InlineData(3, 0, '/')]
        public void DivisionNegativeTest(int x, int y, char op)
        {
            var calc = new ConcreteCalculator();

            var exception = Assert.Throws<DivideByZeroException>(() => calc.CalcData(x, y, op));

            Assert.Equal("Attempted to divide by zero.", exception.Message);
        }

        [Theory]
        [InlineData(3, 2, '/')]
        public void DivisionPositiveTest(int x, int y, char op)
        {
            var calc = new ConcreteCalculator();
            Assert.Equal(x / y, calc.CalcData(x, y, op));
        }
    }
}