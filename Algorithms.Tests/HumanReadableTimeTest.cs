using System;
using Xunit;


namespace Algorithms.Tests
{
    public class HumanReadableTimeTest
    {
        [Fact]
        public void NegativeNumber_ThrowArgumentException()
        {
            var seconds = -1;

            Action act = () => Algorithms.Core.Algorithms.HumanReadableTime(seconds);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Переданное значение времени недопустимо", exception.Message);
        }

        [Fact]
        public void NumberAboveMax_ThrowArgumentException()
        {
            var seconds = 999999;

            Action act = () => Algorithms.Core.Algorithms.HumanReadableTime(seconds);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Переданное значение времени больше допустимого. Максимум: 359999", exception.Message);
        }

        // arrange - подготовка к запуску метода, который собираемся тестировать
        [Theory]
        [InlineData(0, "00:00:00")]
        [InlineData(1, "00:00:01")]
        [InlineData(59, "00:00:59")]
        [InlineData(60, "00:01:00")]
        [InlineData(119, "00:01:59")]
        [InlineData(600, "00:10:00")]
        [InlineData(3661, "01:01:01")]
        [InlineData(86399, "23:59:59")]
        [InlineData(86400, "24:00:00")]
        [InlineData(359999, "99:59:59")]
        public void HumanReadableTime_Theory(int seconds, string expected)
        {
            // act - выполнение метода, запись результата метода в перменные
            var humanReadableTime = Algorithms.Core.Algorithms.HumanReadableTime(seconds);

            // assert - проверка получившегося результата с ожидаемым
            Assert.Equal(expected, humanReadableTime);
        }
    }
} 

