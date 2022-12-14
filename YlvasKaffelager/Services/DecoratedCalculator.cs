using YlvasKaffelager.Services.Contracts;

namespace YlvasKaffelager.Services;

public class DecoratedCalculator : ICalculator
{
    ICalculator _calculator { get; set; }

    public DecoratedCalculator(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public decimal CalculateTotalSum(int amount, decimal price)
    {
        return _calculator.CalculateTotalSum(amount, price);
    }
}
