using System;
using Xunit;
using FunctionsLibrary;

namespace FuncLibTests;

public class FactorialTests
{
    [Fact]
    public void Factorial_ZeroAndOne_ReturnsOne()
    {
        Assert.Equal(1, ComplexFunctions.Factorial(0));
        Assert.Equal(1, ComplexFunctions.Factorial(1));
    }

    [Fact]
    public void Factorial_Positive_ReturnsCorrect()
    {
        Assert.Equal(2, ComplexFunctions.Factorial(2));
        Assert.Equal(6, ComplexFunctions.Factorial(3));
        Assert.Equal(120, ComplexFunctions.Factorial(5));
        Assert.Equal(2432902008176640000L, ComplexFunctions.Factorial(20));
    }

    [Fact]
    public void Factorial_Negative_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => ComplexFunctions.Factorial(-1));
    }

    [Fact]
    public void Factorial_Overflow_ThrowsOverflowException()
    {
        Assert.Throws<OverflowException>(() => ComplexFunctions.Factorial(21));
    }
}

