using System.Runtime.Serialization;

namespace CeTestApp.MerchantClient.Api;

/// <summary>
/// MerchantStockPriceUpdateRequest
/// </summary>
[DataContract(Name = "MerchantStockPriceUpdateRequest")]
public class StockPriceUpdateRequest
{
    /// <summary>
    /// The unique product reference used by the Merchant (sku).
    /// </summary>
    /// <value>The unique product reference used by the Merchant (sku).</value>
    [DataMember(Name = "MerchantProductNo", IsRequired = true, EmitDefaultValue = false)]
    public string MerchantProductNo { get; set; }
    
    /// <summary>
    /// The stock of the product. Should not be negative.
    /// </summary>
    /// <value>The stock of the product. Should not be negative.</value>
    [DataMember(Name = "Stock", EmitDefaultValue = true)]
    public int? Stock { get; set; }
    
    /// <summary>
    /// The price of the product. Should not be negative.
    /// </summary>
    /// <value>The price of the product. Should not be negative.</value>
    [DataMember(Name = "Price", EmitDefaultValue = true)]
    public decimal? Price { get; set; }
}