namespace CeTestApp.Web.Domain.Contracts;

/// <summary>
/// Command for set product stock size.
/// </summary>
public class SetProductStockCommand
{
    /// <summary>
    /// The unique product reference used by the Merchant (sku).
    /// </summary>
    public string MerchantProductNo { get; set; }
    
    /// <summary>
    /// The stock of the product. Should not be negative.
    /// </summary>
    public int Stock { get; set; }
}