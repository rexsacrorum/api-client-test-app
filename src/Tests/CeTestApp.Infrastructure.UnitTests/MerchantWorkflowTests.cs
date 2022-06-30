using System.Text.Json;
using System.Text.Json.Serialization;
using AutoFixture.Xunit2;
using CeTestApp.Domain.Dto;
using CeTestApp.Infrastructure.UnitTests.Attributes;
using CeTestApp.Infrastructure.Workflows;
using CeTestApp.MerchantClient.Api;
using FluentAssertions;
using Moq;

namespace CeTestApp.Infrastructure.UnitTests;

public class MerchantWorkflowTests
{
    [Theory]
    [AutoMoqData]
    public async Task GetTop5ProductsAsync_DummyInput_WorksCorrectly([Frozen]Mock<IOrderApi> orderApi, MerchantWorkflow sut)
    {
        var ordersResponse = await ReadJsonFileAsync<CollectionOfOrdersResponse>("test_orders.json");

        orderApi.Setup(s => s.OrderGetByFilterAsync(It.IsAny<OrderGetByFilterRequest>()))
            .ReturnsAsync(ordersResponse);
        
        //
        var products = await sut.GetTop5ProductsAsync();

        var referenceProducts = await ReadJsonFileAsync<List<ProductDto>>("test_top5_products.json");

        //
        products.Should().BeEquivalentTo(referenceProducts);
    }

    private async Task<T> ReadJsonFileAsync<T>(string fileName)
    {
        var testFile = GetTestFile(fileName);
        var json = await File.ReadAllTextAsync(testFile);
        return JsonSerializer.Deserialize<T>(json);
    }
    
    private string GetTestFile(string testFile)
    {
        var fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Artifacts", testFile);
        if (!File.Exists(fullPath))
            throw new FileNotFoundException("File was not found", fullPath);

        return fullPath;
    }
}