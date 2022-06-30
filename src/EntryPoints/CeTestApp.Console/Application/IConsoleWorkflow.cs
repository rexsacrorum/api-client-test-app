namespace CeTestApp.Console.Application;

public interface IConsoleWorkflow
{
    Task<string> GetInProgressOrdersAsStringAsync();
    Task<string> GetTop5ProductsAsStringAsync();
    Task<SetProductStockResponse> SetStockTo25ToRandomProductAsync();
}