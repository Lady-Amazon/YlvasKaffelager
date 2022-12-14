using YlvasKaffelager.Services.Contracts;

namespace YlvasKaffelager.Services;

public class Calculator : ICalculator
{
    //Calculate the total price and rounds the price
    public decimal CalculateTotalSum(int amount, decimal price)
    {
        return Math.Round((amount * price), 2, MidpointRounding.AwayFromZero);

    }
}

