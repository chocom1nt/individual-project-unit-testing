using System;
using Xunit;

namespace Algorithms.Tests
{
    public class SumOfNumbersTests
    {
        [Fact]
        public void NegativeNumber_ThrowArgumentException()
        {
            // arrange - подготовка к запуску метода, который собираемся тестировать
            int number = -1;

            // act - выполнение метода, запись результата метода в перменные
            Action act = () => Algorithms.Core.Algorithms.SumOfNumbers(number);

            // assert - проверка получившегося результата с ожидаемым
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Переданное число меньше 0", exception.Message);
        }

        [Fact]
        public void Pass_Zero_Sum_Zero()
        {
            // arrange - подготовка к запуску метода, который собираемся тестировать
            int number = 0;

            // act - выполнение метода, запись результата метода в перменные
            int sumOfNumbers = Algorithms.Core.Algorithms.SumOfNumbers(number);

            // assert - проверка получившегося результата с ожидаемым
            Assert.Equal(0, sumOfNumbers);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(5, 5)]
        [InlineData(9, 9)]
        [InlineData(10, 1)]
        [InlineData(11, 2)]
        [InlineData(20, 2)]
        [InlineData(21, 3)]
        [InlineData(1111, 4)]
        [InlineData(2222, 8)]
        [InlineData(1234, 10)]
        [InlineData(9876, 30)]
        public void SumOfNumbers_Theory(int number, int expected)
        {
            // act - выполнение метода, запись результата метода в перменные
            int sumOfNumbers = Algorithms.Core.Algorithms.SumOfNumbers(number);

            // assert - проверка получившегося результата с ожидаемым
            Assert.Equal(expected, sumOfNumbers);
        }
    }
}
