﻿namespace YlvasKaffelager.ViewModels;

public class OrderViewModel
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int CoffeeId { get; set; }
    public int Amount { get; set; }

    //Created a new class for coffeItems
    public List<CoffeeItem> CoffeeItems { get; set; }

    public OrderViewModel()
    {
        CoffeeItems = new List<CoffeeItem>
                {
                    new CoffeeItem
                    {
                        Value = 1,
                        Text = "Gevalia"
                    },
                    new CoffeeItem
                    {
                        Value = 2,
                        Text = "Lavazza"
                    },
                    new CoffeeItem
                    {
                        Value = 3,
                        Text = "Zoegas"
                    },
                    new CoffeeItem
                    {
                        Value = 4,
                        Text = "Löfbergs"
                    }
                };
    }

}