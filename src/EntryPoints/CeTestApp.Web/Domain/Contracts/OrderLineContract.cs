namespace CeTestApp.Web.Domain.Contracts;

/// <summary>
/// Order line contract.
/// </summary>
public class OrderLineContract
{
    /// <summary>
    /// The product description (or title) provided by the channel.
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Either the GTIN (EAN, ISBN, UPC etc) provided by the channel, or the the GTIN belonging to the MerchantProductNo in ChannelEngine.
    /// </summary>
    public string Gtin { get; set; }

    /// <summary>
    /// The number of items of the product.
    /// </summary>
    public int Quantity { get; set; }
}