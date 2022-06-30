using CeTestApp.Web.Domain.Contracts;

namespace CeTestApp.Web.Models;

public class Home
{
    public List<OrderContract> OrdersInProgress { get; set; }
    
    public List<ProductContract> Top5Products { get; set; }
    
    public SetProductStockCommand SetProductStockCommand { get; set; }
}
