

namespace YlvasKaffelager.DataModels;

public class Coffee : Product
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Type { get; set; }
    public decimal Price { get; set; }

}