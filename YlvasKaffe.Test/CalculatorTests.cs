using YlvasKaffelager.Services;
using YlvasKaffelager.Services.Contracts;

namespace YlvasKaffe.Test;

public class CalculatorTests
{
    private ICalculator _sut { get; set; }

    public CalculatorTests()
    {
        _sut = new Calculator();
    }

    //Test to calculate 4*29,90, calculator rounds to even
    [Fact]
    public void Should_Return_Correct_Sum_Of_Four_Coffees()
    {
        decimal expected = 120m;
        decimal actual = _sut.CalculateTotalSum(4, 29.90m);

        Assert.Equal(expected, actual);
    }

    //Test to calculate the total price for 2 Coffees, calculator rounds to even
    [Fact]
    public void Should_Return_Correct_Sum_Of_Two_Coffees()
    {
        decimal expected = 100m;
        decimal actual = _sut.CalculateTotalSum(2, 49.90m);

        Assert.Equal(expected, actual);
    }
    //Test to get correct price from 1 product, calculator rounds to even
    [Fact]
    public void Should_Return_Correct_Price()
    {
        decimal expected = 50m;
        decimal actual = _sut.CalculateTotalSum(1, 49.90m);

        Assert.Equal(expected, actual);
    }
}
