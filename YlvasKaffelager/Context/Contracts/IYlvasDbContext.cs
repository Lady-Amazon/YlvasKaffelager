using YlvasKaffelager.DataModels;

namespace YlvasKaffelager.Context.Contracts;

public interface IYlvasDbContext
{
    List<Coffee> Coffees { get; set; }
    List<Order> Orders { get; set; }


}
