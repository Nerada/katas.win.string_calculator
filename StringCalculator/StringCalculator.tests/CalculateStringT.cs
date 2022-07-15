using FluentAssertions;

namespace StringCalculator.tests;

public class CalculateStringT
{
    [Theory]
    [InlineData("0",        0)]
    [InlineData("1",        1)]
    [InlineData("1,2",      3)]
    [InlineData("1\n2,3",   6)]
    [InlineData("//;\n1;2", 3)]
    public void TestAdd(string input, int expected) => CalculateString.Add(input).Should().Be(expected);
}