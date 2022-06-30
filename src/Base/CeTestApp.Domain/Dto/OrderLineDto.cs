using System.Text;

namespace CeTestApp.Domain.Dto;

/// <summary>
/// Order line.
/// </summary>
public class OrderLineDto
{
    /// <summary>
    ///     Either the GTIN (EAN, ISBN, UPC etc) provided by the channel, or the the GTIN belonging to the MerchantProductNo in
    ///     ChannelEngine.
    /// </summary>
    public string Gtin { get; set; }

    /// <summary>
    ///     The product description (or title) provided by the channel.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    ///     The number of items of the product.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    ///     The unique product reference used by the merchant.
    /// </summary>
    public string MerchantProductNo { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(" OrderLine {");
        sb.Append("  Gtin: ").Append(Gtin);
        sb.Append("  Description: ").Append(Description);
        sb.Append("  MerchantProductNo: ").Append(MerchantProductNo);
        sb.Append("  Quantity: ").Append(Quantity);
        sb.Append("}");
        return sb.ToString();
    }
}
