using YlvasKaffelager.Context.Contracts;
using YlvasKaffelager.DataModels;

namespace YlvasKaffelager.Context;

public class YlvasDbContext : IYlvasDbContext
{
    public List<Coffee> Coffees { get; set; } = new List<Coffee>
    {
        new Coffee
        {
            Id = 1,
            Brand = "Gevalia",
            Price = 29.90m
        },
        new Coffee
        {
            Id = 2,
            Brand = "Lavazza",
            Price = 49.90m
        },
        new Coffee
        {
            Id = 3,
            Brand = "Zoegas",
            Price = 59.90m
        },
        new Coffee
        {
            Id = 4,
            Brand = "Löfbergs",
            Price = 39.90m
        }
    };

    public List<Order> Orders { get; set; } = new List<Order>();

    //public YlvasDbContext()
    //{
    //    Orders = new List<Order>();
    //}

    //public void AddOrder(Order order)
    //{
    //    Orders.Add(order);
    //}

}
