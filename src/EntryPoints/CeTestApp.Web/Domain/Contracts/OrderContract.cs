namespace CeTestApp.Web.Domain.Contracts;

/// <summary>
/// Order contract.
/// </summary>
public class OrderContract
{
    /// <summary>
    /// The unique identifier used by ChannelEngine.
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// The name of the channel for this specific environment/account.
    /// </summary>
    public string ChannelName { get; set; }
    
    /// <summary>
    /// Order lines.
    /// </summary>
    public List<OrderLineContract> Lines { get; set; }
}