using Moq;
using YlvasKaffelager.DataModels;
using YlvasKaffelager.Repositories.Contracts;

namespace YlvasKaffe.Test;

public class ProductRepositoryTest
{
    Mock<IProductRepository> _mockRepo { get; set; }
    IProductRepository _sut { get; set; }

    List<Coffee> coffees = new List<Coffee> {
            new Coffee {Id = 1,Brand = "Gevalia",Price = 29.90m},
            new Coffee {Id = 2,Brand = "Lavazza",Price = 49.90m},
            new Coffee {Id = 3, Brand = "Zoegas", Price = 59.90m },
            new Coffee {Id = 4, Brand = "Löfbergs", Price = 39.90m }
        };

    public ProductRepositoryTest()
    {
        _mockRepo = new Mock<IProductRepository>();

        //Arrange
        _mockRepo.Setup(call => call.GetCoffee(It.IsAny<int>()))
        .Returns((int i) => coffees.Where(p => p.Id == i).Single());

        _sut = _mockRepo.Object;
    }

    //Check if Coffe id exists
    [Fact]
    public void Should_Return_Coffee()
    {
        //Action
        var actual = _sut.GetCoffee(3);

        //Assertion
        Assert.NotNull(actual);

    }

}
