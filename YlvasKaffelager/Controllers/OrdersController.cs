using Microsoft.AspNetCore.Mvc;
using YlvasKaffelager.Context;
using YlvasKaffelager.DataModels;
using YlvasKaffelager.Repositories;
using YlvasKaffelager.Repositories.Contracts;
using YlvasKaffelager.Services;
using YlvasKaffelager.Services.Contracts;
using YlvasKaffelager.ViewModels;

namespace YlvasKaffelager.Controllers;

public class OrdersController : Controller
{
    private readonly IProductRepository _productRepository;

    public int NumberOfOrders { get; set; }

    private ICalculator _calculator;
    private DecoratedCalculator decoratedCalculator;

    public OrdersController()
    {
        _productRepository = new ProductRepository(new YlvasDbContext());

        _calculator = new Calculator();
        decoratedCalculator = new DecoratedCalculator(_calculator);

        NumberOfOrders = 0;
    }

    public IActionResult Index()
    {
        var model = new OrderViewModel();

        return View(model);
    }

    [HttpPost]
    public IActionResult Orders(OrderViewModel model)
    {
        //Adding validation to let the user know if a field is missing information
        //Ordering will not proceed while fileds are empty
        if (ModelState.IsValid)
        {
            var coffee = _productRepository.GetCoffee(model.CoffeeId);
            int amount = model.Amount;

            //Decorated calculator, calculates total sum rounded to 2 decimals
            var totalPrice = decoratedCalculator.CalculateTotalSum(amount, coffee.Price); 
            
            var viewModel = new ViewOrderModel
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Brand = coffee.Brand,
                Amount = amount,
                Total = totalPrice
            };
            return View("ViewOrder", viewModel);
        }
        return View(model);
    }

    public IActionResult ViewOrder()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Confirm(ViewOrderModel model)
    {
        NumberOfOrders++;

        var order = new Order()
        {
            Id = NumberOfOrders,
            FirstName = model.FirstName,
            LastName = model.LastName,
            Email = model.Email,
            Brand = model.Brand,
            Amount = model.Amount,
            Total = model.Total,
        };

        _productRepository.AddOrder(order);

        return View("Completed");
    }

    public IActionResult Completed()
    {
        return View();
    }
}