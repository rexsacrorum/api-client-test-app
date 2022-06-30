using System.Runtime.Serialization;
using System.Text;
using CeTestApp.MerchantClient.Api;

namespace CeTestApp.MerchantClient.Model;

/// <summary>
///     MerchantOrderResponse
/// </summary>
[DataContract(Name = "MerchantOrderResponse")]
public class OrderResponse
{
    /// <summary>
    ///     Gets or Sets ChannelOrderSupport
    /// </summary>
    [DataMember(Name = "ChannelOrderSupport", EmitDefaultValue = false)]
    public OrderSupport? ChannelOrderSupport { get; set; }

    /// <summary>
    ///     Gets or Sets Status
    /// </summary>
    [DataMember(Name = "Status", EmitDefaultValue = false)]
    public OrderStatus? Status { get; set; }

    /// <summary>
    ///     The unique identifier used by ChannelEngine. This identifier does  not have to be saved. It should only be used in
    ///     a call to acknowledge the order.
    /// </summary>
    /// <value>
    ///     The unique identifier used by ChannelEngine. This identifier does  not have to be saved. It should only be used
    ///     in a call to acknowledge the order.
    /// </value>
    [DataMember(Name = "Id", EmitDefaultValue = false)]
    public int Id { get; set; }

    /// <summary>
    ///     The name of the channel for this specific environment/account.
    /// </summary>
    /// <value>The name of the channel for this specific environment/account.</value>
    [DataMember(Name = "ChannelName", EmitDefaultValue = true)]
    public string ChannelName { get; set; }

    /// <summary>
    ///     The unique ID of the channel for this specific environment/account.
    /// </summary>
    /// <value>The unique ID of the channel for this specific environment/account.</value>
    [DataMember(Name = "ChannelId", EmitDefaultValue = true)]
    public int? ChannelId { get; set; }

    /// <summary>
    ///     The name of the channel across all of ChannelEngine.
    /// </summary>
    /// <value>The name of the channel across all of ChannelEngine.</value>
    [DataMember(Name = "GlobalChannelName", EmitDefaultValue = true)]
    public string GlobalChannelName { get; set; }

    /// <summary>
    ///     The unique ID of the channel across all of ChannelEngine.
    /// </summary>
    /// <value>The unique ID of the channel across all of ChannelEngine.</value>
    [DataMember(Name = "GlobalChannelId", EmitDefaultValue = true)]
    public int? GlobalChannelId { get; set; }

    /// <summary>
    ///     The order reference used by the channel.  This number is not guaranteed to be unique accross all orders,  because
    ///     different channels can use the same order number format.
    /// </summary>
    /// <value>
    ///     The order reference used by the channel.  This number is not guaranteed to be unique accross all orders,
    ///     because different channels can use the same order number format.
    /// </value>
    [DataMember(Name = "ChannelOrderNo", EmitDefaultValue = true)]
    public string ChannelOrderNo { get; set; }

    /// <summary>
    ///     The unique order reference used by the Merchant
    /// </summary>
    /// <value>The unique order reference used by the Merchant</value>
    [DataMember(Name = "MerchantOrderNo", EmitDefaultValue = true)]
    public string MerchantOrderNo { get; set; }

    /// <summary>
    ///     Indicating whether the order is a business order.
    /// </summary>
    /// <value>Indicating whether the order is a business order.</value>
    [DataMember(Name = "IsBusinessOrder", EmitDefaultValue = true)]
    public bool IsBusinessOrder { get; set; }

    /// <summary>
    ///     The date the order was created in ChannelEngine.
    /// </summary>
    /// <value>The date the order was created in ChannelEngine.</value>
    [DataMember(Name = "CreatedAt", EmitDefaultValue = true)]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    ///     The date the order was last updated in ChannelEngine.
    /// </summary>
    /// <value>The date the order was last updated in ChannelEngine.</value>
    [DataMember(Name = "UpdatedAt", EmitDefaultValue = true)]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    ///     The optional comment a merchant can add to an order.
    /// </summary>
    /// <value>The optional comment a merchant can add to an order.</value>
    [DataMember(Name = "MerchantComment", EmitDefaultValue = true)]
    public string MerchantComment { get; set; }

    /// <summary>
    ///     Gets or Sets BillingAddress
    /// </summary>
    [DataMember(Name = "BillingAddress", EmitDefaultValue = false)]
    public AddressResponse BillingAddress { get; set; }

    /// <summary>
    ///     Gets or Sets ShippingAddress
    /// </summary>
    [DataMember(Name = "ShippingAddress", EmitDefaultValue = false)]
    public AddressResponse ShippingAddress { get; set; }

    /// <summary>
    ///     The total value of the order lines including VAT  (in the shop&#39;s base currency calculated using the exchange
    ///     rate at the time of ordering).
    /// </summary>
    /// <value>
    ///     The total value of the order lines including VAT  (in the shop&#39;s base currency calculated using the exchange
    ///     rate at the time of ordering).
    /// </value>
    [DataMember(Name = "SubTotalInclVat", EmitDefaultValue = true)]
    public decimal? SubTotalInclVat { get; set; }

    /// <summary>
    ///     The total amount of VAT charged over the order lines  (in the shop&#39;s base currency calculated using the
    ///     exchange rate at the time of ordering).
    /// </summary>
    /// <value>
    ///     The total amount of VAT charged over the order lines  (in the shop&#39;s base currency calculated using the
    ///     exchange rate at the time of ordering).
    /// </value>
    [DataMember(Name = "SubTotalVat", EmitDefaultValue = true)]
    public decimal? SubTotalVat { get; set; }

    /// <summary>
    ///     The total amount of VAT charged over the shipping fee  (in the shop&#39;s base currency calculated using the
    ///     exchange rate at the time of ordering).
    /// </summary>
    /// <value>
    ///     The total amount of VAT charged over the shipping fee  (in the shop&#39;s base currency calculated using the
    ///     exchange rate at the time of ordering).
    /// </value>
    [DataMember(Name = "ShippingCostsVat", EmitDefaultValue = true)]
    public decimal? ShippingCostsVat { get; set; }

    /// <summary>
    ///     The total value of the order including VAT  (in the shop&#39;s base currency calculated using the exchange rate at
    ///     the time of ordering).
    /// </summary>
    /// <value>
    ///     The total value of the order including VAT  (in the shop&#39;s base currency calculated using the exchange rate
    ///     at the time of ordering).
    /// </value>
    [DataMember(Name = "TotalInclVat", EmitDefaultValue = false)]
    public decimal TotalInclVat { get; set; }

    /// <summary>
    ///     The total amount of VAT charged over the total value of te order  (in the shop&#39;s base currency calculated using
    ///     the exchange rate at the time of ordering).
    /// </summary>
    /// <value>
    ///     The total amount of VAT charged over the total value of te order  (in the shop&#39;s base currency calculated
    ///     using the exchange rate at the time of ordering).
    /// </value>
    [DataMember(Name = "TotalVat", EmitDefaultValue = true)]
    public decimal? TotalVat { get; set; }

    /// <summary>
    ///     The total value of the order lines including VAT  (in the currency in which the order was paid for, see
    ///     CurrencyCode).
    /// </summary>
    /// <value>
    ///     The total value of the order lines including VAT  (in the currency in which the order was paid for, see
    ///     CurrencyCode).
    /// </value>
    [DataMember(Name = "OriginalSubTotalInclVat", EmitDefaultValue = true)]
    public decimal? OriginalSubTotalInclVat { get; set; }

    /// <summary>
    ///     The total amount of VAT charged over the order lines  (in the currency in which the order was paid for, see
    ///     CurrencyCode).
    /// </summary>
    /// <value>
    ///     The total amount of VAT charged over the order lines  (in the currency in which the order was paid for, see
    ///     CurrencyCode).
    /// </value>
    [DataMember(Name = "OriginalSubTotalVat", EmitDefaultValue = true)]
    public decimal? OriginalSubTotalVat { get; set; }

    /// <summary>
    ///     The shipping fee including VAT  (in the currency in which the order was paid for, see CurrencyCode).
    /// </summary>
    /// <value>The shipping fee including VAT  (in the currency in which the order was paid for, see CurrencyCode).</value>
    [DataMember(Name = "OriginalShippingCostsInclVat", EmitDefaultValue = true)]
    public decimal? OriginalShippingCostsInclVat { get; set; }

    /// <summary>
    ///     The total amount of VAT charged over the shipping fee  (in the currency in which the order was paid for, see
    ///     CurrencyCode).
    /// </summary>
    /// <value>
    ///     The total amount of VAT charged over the shipping fee  (in the currency in which the order was paid for, see
    ///     CurrencyCode).
    /// </value>
    [DataMember(Name = "OriginalShippingCostsVat", EmitDefaultValue = true)]
    public decimal? OriginalShippingCostsVat { get; set; }

    /// <summary>
    ///     The total value of the order including VAT  (in the currency in which the order was paid for, see CurrencyCode).
    /// </summary>
    /// <value>The total value of the order including VAT  (in the currency in which the order was paid for, see CurrencyCode).</value>
    [DataMember(Name = "OriginalTotalInclVat", EmitDefaultValue = true)]
    public decimal? OriginalTotalInclVat { get; set; }

    /// <summary>
    ///     The total amount of VAT charged over the total value of te order  (in the currency in which the order was paid for,
    ///     see CurrencyCode).
    /// </summary>
    /// <value>
    ///     The total amount of VAT charged over the total value of te order  (in the currency in which the order was paid
    ///     for, see CurrencyCode).
    /// </value>
    [DataMember(Name = "OriginalTotalVat", EmitDefaultValue = true)]
    public decimal? OriginalTotalVat { get; set; }

    /// <summary>
    ///     Gets or Sets Lines
    /// </summary>
    [DataMember(Name = "Lines", EmitDefaultValue = true)]
    public List<OrderLineResponse> Lines { get; set; }

    /// <summary>
    ///     Gets or Sets ShippingCostsInclVat
    /// </summary>
    [DataMember(Name = "ShippingCostsInclVat", EmitDefaultValue = false)]
    public decimal ShippingCostsInclVat { get; set; }

    /// <summary>
    ///     The customer&#39;s telephone number.
    /// </summary>
    /// <value>The customer&#39;s telephone number.</value>
    [DataMember(Name = "Phone", EmitDefaultValue = true)]
    public string Phone { get; set; }

    /// <summary>
    ///     The customer&#39;s email.
    /// </summary>
    /// <value>The customer&#39;s email.</value>
    [DataMember(Name = "Email", IsRequired = true, EmitDefaultValue = false)]
    public string Email { get; set; }

    /// <summary>
    ///     Optional. A company&#39;s chamber of commerce number.
    /// </summary>
    /// <value>Optional. A company&#39;s chamber of commerce number.</value>
    [DataMember(Name = "CompanyRegistrationNo", EmitDefaultValue = true)]
    public string CompanyRegistrationNo { get; set; }

    /// <summary>
    ///     Optional. A company&#39;s VAT number.
    /// </summary>
    /// <value>Optional. A company&#39;s VAT number.</value>
    [DataMember(Name = "VatNo", EmitDefaultValue = true)]
    public string VatNo { get; set; }

    /// <summary>
    ///     The payment method used on the order.
    /// </summary>
    /// <value>The payment method used on the order.</value>
    [DataMember(Name = "PaymentMethod", EmitDefaultValue = true)]
    public string PaymentMethod { get; set; }

    /// <summary>
    ///     Reference or transaction id for the payment
    /// </summary>
    /// <value>Reference or transaction id for the payment</value>
    [DataMember(Name = "PaymentReferenceNo", EmitDefaultValue = true)]
    public string PaymentReferenceNo { get; set; }

    /// <summary>
    ///     The currency code for the amounts of the order.
    /// </summary>
    /// <value>The currency code for the amounts of the order.</value>
    [DataMember(Name = "CurrencyCode", IsRequired = true, EmitDefaultValue = false)]
    public string CurrencyCode { get; set; }

    /// <summary>
    ///     The date the order was created at the channel.
    /// </summary>
    /// <value>The date the order was created at the channel.</value>
    [DataMember(Name = "OrderDate", IsRequired = true, EmitDefaultValue = false)]
    public DateTime OrderDate { get; set; }

    /// <summary>
    ///     The unique customer reference used by the channel.
    /// </summary>
    /// <value>The unique customer reference used by the channel.</value>
    [DataMember(Name = "ChannelCustomerNo", EmitDefaultValue = true)]
    public string ChannelCustomerNo { get; set; }

    /// <summary>
    ///     Extra data on the order.
    /// </summary>
    /// <value>Extra data on the order.</value>
    [DataMember(Name = "ExtraData", EmitDefaultValue = true)]
    public Dictionary<string, string> ExtraData { get; set; }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MerchantOrderResponse {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ChannelName: ").Append(ChannelName).Append("\n");
        sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
        sb.Append("  GlobalChannelName: ").Append(GlobalChannelName).Append("\n");
        sb.Append("  GlobalChannelId: ").Append(GlobalChannelId).Append("\n");
        sb.Append("  ChannelOrderSupport: ").Append(ChannelOrderSupport).Append("\n");
        sb.Append("  ChannelOrderNo: ").Append(ChannelOrderNo).Append("\n");
        sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  IsBusinessOrder: ").Append(IsBusinessOrder).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
        sb.Append("  MerchantComment: ").Append(MerchantComment).Append("\n");
        sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
        sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
        sb.Append("  SubTotalInclVat: ").Append(SubTotalInclVat).Append("\n");
        sb.Append("  SubTotalVat: ").Append(SubTotalVat).Append("\n");
        sb.Append("  ShippingCostsVat: ").Append(ShippingCostsVat).Append("\n");
        sb.Append("  TotalInclVat: ").Append(TotalInclVat).Append("\n");
        sb.Append("  TotalVat: ").Append(TotalVat).Append("\n");
        sb.Append("  OriginalSubTotalInclVat: ").Append(OriginalSubTotalInclVat).Append("\n");
        sb.Append("  OriginalSubTotalVat: ").Append(OriginalSubTotalVat).Append("\n");
        sb.Append("  OriginalShippingCostsInclVat: ").Append(OriginalShippingCostsInclVat).Append("\n");
        sb.Append("  OriginalShippingCostsVat: ").Append(OriginalShippingCostsVat).Append("\n");
        sb.Append("  OriginalTotalInclVat: ").Append(OriginalTotalInclVat).Append("\n");
        sb.Append("  OriginalTotalVat: ").Append(OriginalTotalVat).Append("\n");
        sb.Append("  Lines: ").Append(Lines).Append("\n");
        sb.Append("  ShippingCostsInclVat: ").Append(ShippingCostsInclVat).Append("\n");
        sb.Append("  Phone: ").Append(Phone).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  CompanyRegistrationNo: ").Append(CompanyRegistrationNo).Append("\n");
        sb.Append("  VatNo: ").Append(VatNo).Append("\n");
        sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
        sb.Append("  PaymentReferenceNo: ").Append(PaymentReferenceNo).Append("\n");
        sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
        sb.Append("  OrderDate: ").Append(OrderDate).Append("\n");
        sb.Append("  ChannelCustomerNo: ").Append(ChannelCustomerNo).Append("\n");
        sb.Append("  ExtraData: ").Append(ExtraData).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}