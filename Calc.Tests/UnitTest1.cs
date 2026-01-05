using Xunit;
using CalcApp;

public class CalcTests
{
    [Fact]
    public void ShouldSumTwoNumbersCorrectly()
    {
        // Arrange
        var calc = new Calc();

        // Act
        var result = calc.Sum(2, 2);

        // Assert
        Assert.Equal(4, result);
    }
}
