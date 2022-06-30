namespace CeTestApp.MerchantClient.Api;

public class OrderGetByFilterRequest
{
    public List<OrderStatus> Statuses { get; set; }
}