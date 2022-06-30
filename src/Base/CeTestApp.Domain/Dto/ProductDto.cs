using System.Text;

namespace CeTestApp.Domain.Dto;

/// <summary>
/// Product dto.
/// </summary>
public class ProductDto
{
    /// <summary>
    /// The unique product reference used by the merchant.
    /// </summary>
    public string MerchantProductNo { get; set; }
    
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

    public override string ToString()
    {
        var sb = new StringBuilder();
        
        sb.Append(" Product {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Gtin: ").Append(Gtin).Append("\n");
        sb.Append("  Quantity: ").Append(Quantity).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}