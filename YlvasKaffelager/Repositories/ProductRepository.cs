using YlvasKaffelager.Context;
using YlvasKaffelager.DataModels;
using YlvasKaffelager.Repositories.Contracts;

namespace YlvasKaffelager.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly YlvasDbContext _dbContext;

    public ProductRepository(YlvasDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddOrder(Order order)
    {
        _dbContext.Orders.Add(order);
    }

    public Coffee GetCoffee(int id)
    {
        return _dbContext.Coffees
             .Where(c => c.Id == id)
             .FirstOrDefault()!;
    }
}
