using System;
using Xunit;

public class CalculatorTests
{
    private readonly Calculator _calculator = new();

    [Fact]
    public void Add_ValidNumbers_ReturnsCorrectSum()
    {
        var result = Calculator.Add(10, 5);
        Assert.Equal(15, result);
    }

    [Fact]
    public void Subtract_ValidNumbers_ReturnsCorrectDifference()
    {
        var result = Calculator.Subtract(10, 5);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Multiply_ValidNumbers_ReturnsCorrectProduct()
    {
        var result = Calculator.Multiply(10, 5);
        Assert.Equal(50, result);
    }

    [Fact]
    public void Divide_ValidNumbers_ReturnsCorrectQuotient()
    {
        var result = Calculator.Divide(10, 5);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Divide_ByZero_ReturnsZero()
    {
        var result = Calculator.Divide(10, 0);
        Assert.Equal(0, result);
    }

    [Fact]
    public void Square_ValidNumber_ReturnsCorrectSquare()
    {
        var result = Calculator.Square(5);
        Assert.Equal(25, result);
    }

    [Fact]
    public void SquareRoot_ValidNumber_ReturnsCorrectRoot()
    {
        var result = Calculator.SquareRoot(25);
        Assert.Equal(5, result);
    }
}
