using FluentAssertions;

namespace PerformanceModule.Tests;

public class FibonacciCalculatorTests
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(7, 13)]
    [InlineData(8, 21)]
    public void Test(int count, int expected)
    {
        var fibCalculator = new FibonacciCalculator();
        var result = fibCalculator.Calculate(count);
        result.Should().Be(expected);
    }
}