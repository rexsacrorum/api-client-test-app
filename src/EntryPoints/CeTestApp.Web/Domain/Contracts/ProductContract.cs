namespace CeTestApp.Web.Domain.Contracts;

/// <summary>
/// Product contract.
/// </summary>
public class ProductContract
{
    /// <summary>
    /// Either the GTIN (EAN, ISBN, UPC etc) provided by the channel, or the the GTIN belonging to the MerchantProductNo in ChannelEngine.
    /// </summary>
    public string Gtin { get; set; }
    
    /// <summary>
    /// Product name.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// The number of items of the product.
    /// </summary>
    public decimal? Quantity { get; set; }
}