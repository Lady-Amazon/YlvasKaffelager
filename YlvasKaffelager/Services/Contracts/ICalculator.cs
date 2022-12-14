namespace YlvasKaffelager.Services.Contracts
{
    public interface ICalculator
    {
        decimal CalculateTotalSum(int amount, decimal price);
    }
}
