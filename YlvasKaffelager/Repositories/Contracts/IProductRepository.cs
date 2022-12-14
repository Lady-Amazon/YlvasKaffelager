using YlvasKaffelager.DataModels;

namespace YlvasKaffelager.Repositories.Contracts
{
    public interface IProductRepository
    {
        Coffee GetCoffee(int id);
        void AddOrder(Order order);
    }
}
