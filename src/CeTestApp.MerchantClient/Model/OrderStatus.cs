using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CeTestApp.MerchantClient.Api;

[JsonConverter(typeof (JsonStringEnumConverter))]
public enum OrderStatus
{
    // None = 0,
    /// <summary>
    /// Enum INPROGRESS for value: IN_PROGRESS
    /// </summary>
    [EnumMember(Value = "IN_PROGRESS")] 
    IN_PROGRESS = 1,
    /// <summary>Enum SHIPPED for value: SHIPPED</summary>
    [EnumMember(Value = "SHIPPED")]
    SHIPPED = 2,
    /// <summary>Enum INBACKORDER for value: IN_BACKORDER</summary>
    [EnumMember(Value = "IN_BACKORDER")]
    IN_BACKORDER = 3,
    /// <summary>Enum MANCO for value: MANCO</summary>
    [EnumMember(Value = "MANCO")]
    MANCO = 4,
    /// <summary>Enum CANCELED for value: CANCELED</summary>
    [EnumMember(Value = "CANCELED")]
    CANCELED = 5,
    /// <summary>Enum INCOMBI for value: IN_COMBI</summary>
    [EnumMember(Value = "IN_COMBI")]
    IN_COMBI = 6,
    /// <summary>Enum CLOSED for value: CLOSED</summary>
    [EnumMember(Value = "CLOSED")]
    CLOSED = 7,
    /// <summary>Enum NEW for value: NEW</summary>
    [EnumMember(Value = "NEW")]
    NEW = 8,
    /// <summary>Enum RETURNED for value: RETURNED</summary>
    [EnumMember(Value = "RETURNED")]
    RETURNED = 9,
    /// <summary>
    /// Enum REQUIRESCORRECTION for value: REQUIRES_CORRECTION
    /// </summary>
    [EnumMember(Value = "REQUIRES_CORRECTION")]
    REQUIRES_CORRECTION = 10, // 0x0000000A
    /// <summary>Enum AWAITINGPAYMENT for value: AWAITING_PAYMENT</summary>
    [EnumMember(Value = "AWAITING_PAYMENT")]
    AWAITING_PAYMENT = 11, // 0x0000000B
}