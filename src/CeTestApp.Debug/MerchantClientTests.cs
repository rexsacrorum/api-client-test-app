using AutoFixture.Xunit2;
using ChannelEngine.Merchant.ApiClient.Model;
using FluentAssertions;
using Xunit.Abstractions;

namespace CeTestApp.Debug;

public class MerchantClientTests
{
    private ITestOutputHelper Output { get; }

    public MerchantClientTests(ITestOutputHelper output)
    {
        Output = output;
    }
    
    [Theory]
    [AutoData]
    public async Task GetInProgressOrdersAsync_Ok(MerchantClientAdapter client)
    {
        var orders = await client.GetInProgressOrdersAsync();

        //
        orders.Should().NotBeNull();
        orders.Count.Should().Be(6);
        orders.Should()
            .AllSatisfy(e => e.Status.Should().Be(OrderStatusView.IN_PROGRESS));
    }

    [Theory]
    [AutoData]
    public async Task GetTop5ProductsAsync_Ok(MerchantClientAdapter client)
    {
        //
        var products = await client.GetTop5ProductsAsync();

        //
        products.Count.Should().BeLessOrEqualTo(5);

        foreach (var product in products)
        {
            Output.WriteLine(product.ToString());
        }
    }

    [Theory]
    [AutoData]
    public async Task SetProductStockAsync_Ok(MerchantClientAdapter client)
    {
        //
        var topProducts = await client.GetTop5ProductsAsync();

        var product = topProducts.First();

        client.SetProductStockAsync(product.MerchantProductNo, 25);
    }

    [Theory]
    [AutoData]
    public async Task SaveOrdersToFile(MerchantClientAdapter client)
    {
        var orders = await client.GetAllOrdersAsJsonAsync();
        
        var file = Path.Combine(Directory.GetCurrentDirectory(), "test_orders.json");
        if (File.Exists(file))
            File.Delete(file);
        
        await File.WriteAllTextAsync(file,orders);
    }
}