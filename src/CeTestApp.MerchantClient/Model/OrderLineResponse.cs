using System.Runtime.Serialization;
using System.Text;
using CeTestApp.MerchantClient.Api;

namespace CeTestApp.MerchantClient.Model;

/// <summary>
/// MerchantOrderLineResponse
/// </summary>
[DataContract(Name = "MerchantOrderLineResponse")]
public class OrderLineResponse
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name = "Status", EmitDefaultValue = false)]
    public OrderStatus? Status { get; set; }
    
    /// <summary>
    /// Gets or Sets Condition
    /// </summary>
    [DataMember(Name = "Condition", EmitDefaultValue = false)]
    public Condition? Condition { get; set; }
    
    /// <summary>
        /// Is the order fulfilled by the marketplace (amazon: FBA, bol: LVB, etc.)?.
        /// </summary>
        /// <value>Is the order fulfilled by the marketplace (amazon: FBA, bol: LVB, etc.)?.</value>
        [DataMember(Name = "IsFulfillmentByMarketplace", EmitDefaultValue = true)]
        public bool IsFulfillmentByMarketplace { get; set; }

        /// <summary>
        /// Either the GTIN (EAN, ISBN, UPC etc) provided by the channel, or the the GTIN belonging to the MerchantProductNo in ChannelEngine.
        /// </summary>
        /// <value>Either the GTIN (EAN, ISBN, UPC etc) provided by the channel, or the the GTIN belonging to the MerchantProductNo in ChannelEngine.</value>
        [DataMember(Name = "Gtin", EmitDefaultValue = true)]
        public string Gtin { get; set; }

        /// <summary>
        /// The product description (or title) provided by the channel.
        /// </summary>
        /// <value>The product description (or title) provided by the channel.</value>
        [DataMember(Name = "Description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets StockLocation
        /// </summary>
        [DataMember(Name = "StockLocation", EmitDefaultValue = false)]
        public MerchantStockLocationResponse StockLocation { get; set; }

        /// <summary>
        /// The total amount of VAT charged over the value of a single unit of the ordered product  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The total amount of VAT charged over the value of a single unit of the ordered product  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name = "UnitVat", EmitDefaultValue = true)]
        public decimal? UnitVat { get; set; }

        /// <summary>
        /// The total value of the order line (quantity * unit price) including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The total value of the order line (quantity * unit price) including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name = "LineTotalInclVat", EmitDefaultValue = true)]
        public decimal? LineTotalInclVat { get; set; }

        /// <summary>
        /// The total amount of VAT charged over the total value of the order line (quantity * unit price)  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The total amount of VAT charged over the total value of the order line (quantity * unit price)  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name = "LineVat", EmitDefaultValue = true)]
        public decimal? LineVat { get; set; }

        /// <summary>
        /// The value of a single unit of the ordered product including VAT  (in the currency in which the order was paid for, see CurrencyCode).
        /// </summary>
        /// <value>The value of a single unit of the ordered product including VAT  (in the currency in which the order was paid for, see CurrencyCode).</value>
        [DataMember(Name = "OriginalUnitPriceInclVat", EmitDefaultValue = true)]
        public decimal? OriginalUnitPriceInclVat { get; set; }

        /// <summary>
        /// The total amount of VAT charged over the value of a single unit of the ordered product  (in the currency in which the order was paid for, see CurrencyCode).
        /// </summary>
        /// <value>The total amount of VAT charged over the value of a single unit of the ordered product  (in the currency in which the order was paid for, see CurrencyCode).</value>
        [DataMember(Name = "OriginalUnitVat", EmitDefaultValue = true)]
        public decimal? OriginalUnitVat { get; set; }

        /// <summary>
        /// The total value of the order line (quantity * unit price) including VAT  (in the currency in which the order was paid for, see CurrencyCode).
        /// </summary>
        /// <value>The total value of the order line (quantity * unit price) including VAT  (in the currency in which the order was paid for, see CurrencyCode).</value>
        [DataMember(Name = "OriginalLineTotalInclVat", EmitDefaultValue = true)]
        public decimal? OriginalLineTotalInclVat { get; set; }

        /// <summary>
        /// The total amount of VAT charged over the total value of the order line (quantity * unit price)  (in the currency in which the order was paid for, see CurrencyCode).
        /// </summary>
        /// <value>The total amount of VAT charged over the total value of the order line (quantity * unit price)  (in the currency in which the order was paid for, see CurrencyCode).</value>
        [DataMember(Name = "OriginalLineVat", EmitDefaultValue = true)]
        public decimal? OriginalLineVat { get; set; }

        /// <summary>
        /// A percentage fee that is charged by the Channel for this orderline.  This fee rate is based on the currency of client  This field is optional, send 0 if not applicable.
        /// </summary>
        /// <value>A percentage fee that is charged by the Channel for this orderline.  This fee rate is based on the currency of client  This field is optional, send 0 if not applicable.</value>
        [DataMember(Name = "OriginalFeeFixed", EmitDefaultValue = false)]
        public decimal OriginalFeeFixed { get; set; }

        /// <summary>
        /// If the product is ordered part of a bundle, this field contains the MerchantProductNo of  the product bundle.
        /// </summary>
        /// <value>If the product is ordered part of a bundle, this field contains the MerchantProductNo of  the product bundle.</value>
        [DataMember(Name = "BundleProductMerchantProductNo", EmitDefaultValue = true)]
        public string BundleProductMerchantProductNo { get; set; }

        /// <summary>
        /// State assigned code identifying the jurisdiction.
        /// </summary>
        /// <value>State assigned code identifying the jurisdiction.</value>
        [DataMember(Name = "JurisCode", EmitDefaultValue = true)]
        public string JurisCode { get; set; }

        /// <summary>
        /// Name of a tax jurisdiction.
        /// </summary>
        /// <value>Name of a tax jurisdiction.</value>
        [DataMember(Name = "JurisName", EmitDefaultValue = true)]
        public string JurisName { get; set; }

        /// <summary>
        /// VAT rate of the orderline.
        /// </summary>
        /// <value>VAT rate of the orderline.</value>
        [DataMember(Name = "VatRate", EmitDefaultValue = false)]
        public decimal VatRate { get; set; }

        /// <summary>
        /// Gets or Sets ExtraData
        /// </summary>
        [DataMember(Name = "ExtraData", EmitDefaultValue = true)]
        public List<MerchantOrderLineExtraDataResponse> ExtraData { get; set; }

        /// <summary>
        /// The unique product reference used by the channel.
        /// </summary>
        /// <value>The unique product reference used by the channel.</value>
        [DataMember(Name = "ChannelProductNo", IsRequired = true, EmitDefaultValue = false)]
        public string ChannelProductNo { get; set; }

        /// <summary>
        /// The unique product reference used by the merchant.
        /// </summary>
        /// <value>The unique product reference used by the merchant.</value>
        [DataMember(Name = "MerchantProductNo", EmitDefaultValue = true)]
        public string MerchantProductNo { get; set; }

        /// <summary>
        /// The number of items of the product.
        /// </summary>
        /// <value>The number of items of the product.</value>
        [DataMember(Name = "Quantity", IsRequired = true, EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// The number of items for which cancellation was requested by the customer.  Some channels allow a customer to cancel an order until it has been shipped.  When an order has already been acknowledged in ChannelEngine, it can only be cancelled by creating a cancellation.  Use this field to check whether it is still possible to cancel the order. If this is the case, submit a cancellation to ChannelEngine.
        /// </summary>
        /// <value>The number of items for which cancellation was requested by the customer.  Some channels allow a customer to cancel an order until it has been shipped.  When an order has already been acknowledged in ChannelEngine, it can only be cancelled by creating a cancellation.  Use this field to check whether it is still possible to cancel the order. If this is the case, submit a cancellation to ChannelEngine.</value>
        [DataMember(Name = "CancellationRequestedQuantity", EmitDefaultValue = false)]
        public int CancellationRequestedQuantity { get; set; }

        /// <summary>
        /// The value of a single unit of the ordered product including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The value of a single unit of the ordered product including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name = "UnitPriceInclVat", IsRequired = true, EmitDefaultValue = false)]
        public decimal UnitPriceInclVat { get; set; }

        /// <summary>
        /// A fixed fee that is charged by the Channel for this orderline.  This fee rate is based on the currency of the Channel  This field is optional, send 0 if not applicable.
        /// </summary>
        /// <value>A fixed fee that is charged by the Channel for this orderline.  This fee rate is based on the currency of the Channel  This field is optional, send 0 if not applicable.</value>
        [DataMember(Name = "FeeFixed", EmitDefaultValue = false)]
        public decimal FeeFixed { get; set; }

        /// <summary>
        /// A percentage fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable.
        /// </summary>
        /// <value>A percentage fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable.</value>
        [DataMember(Name = "FeeRate", EmitDefaultValue = false)]
        public decimal FeeRate { get; set; }

        /// <summary>
        /// Expected delivery date from channels, empty if channels not support this value
        /// </summary>
        /// <value>Expected delivery date from channels, empty if channels not support this value</value>
        [DataMember(Name = "ExpectedDeliveryDate", EmitDefaultValue = true)]
        public DateTime? ExpectedDeliveryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantOrderLineResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IsFulfillmentByMarketplace: ").Append(IsFulfillmentByMarketplace).Append("\n");
            sb.Append("  Gtin: ").Append(Gtin).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  StockLocation: ").Append(StockLocation).Append("\n");
            sb.Append("  UnitVat: ").Append(UnitVat).Append("\n");
            sb.Append("  LineTotalInclVat: ").Append(LineTotalInclVat).Append("\n");
            sb.Append("  LineVat: ").Append(LineVat).Append("\n");
            sb.Append("  OriginalUnitPriceInclVat: ").Append(OriginalUnitPriceInclVat).Append("\n");
            sb.Append("  OriginalUnitVat: ").Append(OriginalUnitVat).Append("\n");
            sb.Append("  OriginalLineTotalInclVat: ").Append(OriginalLineTotalInclVat).Append("\n");
            sb.Append("  OriginalLineVat: ").Append(OriginalLineVat).Append("\n");
            sb.Append("  OriginalFeeFixed: ").Append(OriginalFeeFixed).Append("\n");
            sb.Append("  BundleProductMerchantProductNo: ").Append(BundleProductMerchantProductNo).Append("\n");
            sb.Append("  JurisCode: ").Append(JurisCode).Append("\n");
            sb.Append("  JurisName: ").Append(JurisName).Append("\n");
            sb.Append("  VatRate: ").Append(VatRate).Append("\n");
            sb.Append("  ExtraData: ").Append(ExtraData).Append("\n");
            sb.Append("  ChannelProductNo: ").Append(ChannelProductNo).Append("\n");
            sb.Append("  MerchantProductNo: ").Append(MerchantProductNo).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  CancellationRequestedQuantity: ").Append(CancellationRequestedQuantity).Append("\n");
            sb.Append("  UnitPriceInclVat: ").Append(UnitPriceInclVat).Append("\n");
            sb.Append("  FeeFixed: ").Append(FeeFixed).Append("\n");
            sb.Append("  FeeRate: ").Append(FeeRate).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  ExpectedDeliveryDate: ").Append(ExpectedDeliveryDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    
}