using BaseLibrary;

namespace BaseLibTests;

public class BaseFunctionsTests
{
    [Fact]
    public void Add_WithPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int a = 5;
        int b = 3;

        // Act
        int result = BaseFunctions.Add(a, b);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void Add_WithNegativeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int a = -5;
        int b = -3;

        // Act
        int result = BaseFunctions.Add(a, b);

        // Assert
        Assert.Equal(-8, result);
    }

    [Fact]
    public void Add_WithZero_ReturnsCorrectSum()
    {
        // Arrange
        int a = 5;
        int b = 0;

        // Act
        int result = BaseFunctions.Add(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_WithPositiveNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        int a = 10;
        int b = 3;

        // Act
        int result = BaseFunctions.Subtract(a, b);

        // Assert
        Assert.Equal(7, result);
    }

    [Fact]
    public void Subtract_WithNegativeNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        int a = -5;
        int b = -3;

        // Act
        int result = BaseFunctions.Subtract(a, b);

        // Assert
        Assert.Equal(-2, result);
    }

    [Fact]
    public void Subtract_ResultingInNegative_ReturnsCorrectDifference()
    {
        // Arrange
        int a = 3;
        int b = 10;

        // Act
        int result = BaseFunctions.Subtract(a, b);

        // Assert
        Assert.Equal(-7, result);
    }

    [Fact]
    public void Multiply_WithPositiveNumbers_ReturnsCorrectProduct()
    {
        // Arrange
        int a = 5;
        int b = 3;

        // Act
        int result = BaseFunctions.Multiply(a, b);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void Multiply_WithNegativeNumbers_ReturnsCorrectProduct()
    {
        // Arrange
        int a = -5;
        int b = -3;

        // Act
        int result = BaseFunctions.Multiply(a, b);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void Multiply_WithZero_ReturnsZero()
    {
        // Arrange
        int a = 5;
        int b = 0;

        // Act
        int result = BaseFunctions.Multiply(a, b);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Multiply_WithOnePositiveOneNegative_ReturnsNegativeProduct()
    {
        // Arrange
        int a = 5;
        int b = -3;

        // Act
        int result = BaseFunctions.Multiply(a, b);

        // Assert
        Assert.Equal(-15, result);
    }

    [Fact]
    public void Divide_WithValidNumbers_ReturnsCorrectQuotient()
    {
        // Arrange
        int a = 10;
        int b = 2;

        // Act
        double result = BaseFunctions.Divide(a, b);

        // Assert
        Assert.Equal(5.0, result);
    }

    [Fact]
    public void Divide_WithNonDivisibleNumbers_ReturnsDecimalQuotient()
    {
        // Arrange
        int a = 10;
        int b = 3;

        // Act
        double result = BaseFunctions.Divide(a, b);

        // Assert
        Assert.Equal(3.333333333333333, result, 10);
    }

    [Fact]
    public void Divide_WithNegativeNumbers_ReturnsCorrectQuotient()
    {
        // Arrange
        int a = -10;
        int b = 2;

        // Act
        double result = BaseFunctions.Divide(a, b);

        // Assert
        Assert.Equal(-5.0, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int a = 10;
        int b = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => BaseFunctions.Divide(a, b));
    }

    [Fact]
    public void Divide_ByZero_ThrowsExceptionWithCorrectMessage()
    {
        // Arrange
        int a = 10;
        int b = 0;

        // Act & Assert
        var exception = Assert.Throws<DivideByZeroException>(() => BaseFunctions.Divide(a, b));
        Assert.Equal("Denominator cannot be zero.", exception.Message);
    }
}
