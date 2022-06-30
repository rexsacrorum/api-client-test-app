using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace CeTestApp.MerchantClient.Model;

/// <summary>
///     MerchantAddressResponse
/// </summary>
[DataContract(Name = "MerchantAddressResponse")]
public class AddressResponse
{
    /// <summary>
    ///     Gets or Sets Gender
    /// </summary>
    [DataMember(Name = "Gender", EmitDefaultValue = false)]
    public Gender? Gender { get; set; }

    /// <summary>
    ///     The first address line, use this field if address validation is disabled in ChannelEngine.
    /// </summary>
    /// <value>The first address line, use this field if address validation is disabled in ChannelEngine.</value>
    [DataMember(Name = "Line1", EmitDefaultValue = true)]
    public string Line1 { get; set; }

    /// <summary>
    ///     The second address line, use this field if address validation is disabled in ChannelEngine.
    /// </summary>
    /// <value>The second address line, use this field if address validation is disabled in ChannelEngine.</value>
    [DataMember(Name = "Line2", EmitDefaultValue = true)]
    public string Line2 { get; set; }

    /// <summary>
    ///     The third address line, use this field if address validation is disabled in ChannelEngine.
    /// </summary>
    /// <value>The third address line, use this field if address validation is disabled in ChannelEngine.</value>
    [DataMember(Name = "Line3", EmitDefaultValue = true)]
    public string Line3 { get; set; }

    /// <summary>
    ///     Optional. Company addressed too.
    /// </summary>
    /// <value>Optional. Company addressed too.</value>
    [DataMember(Name = "CompanyName", EmitDefaultValue = true)]
    public string CompanyName { get; set; }

    /// <summary>
    ///     The first name of the customer.
    /// </summary>
    /// <value>The first name of the customer.</value>
    [DataMember(Name = "FirstName", EmitDefaultValue = true)]
    public string FirstName { get; set; }

    /// <summary>
    ///     The last name of the customer (includes the surname prefix [tussenvoegsel] like &#39;de&#39;, &#39;van&#39;, &#39;
    ///     du&#39;).
    /// </summary>
    /// <value>
    ///     The last name of the customer (includes the surname prefix [tussenvoegsel] like &#39;de&#39;, &#39;van&#39;,
    ///     &#39;du&#39;).
    /// </value>
    [DataMember(Name = "LastName", EmitDefaultValue = true)]
    public string LastName { get; set; }

    /// <summary>
    ///     The name of the street (without house number information)  This field might be empty if address validation is
    ///     disabled in ChannelEngine.
    /// </summary>
    /// <value>
    ///     The name of the street (without house number information)  This field might be empty if address validation is
    ///     disabled in ChannelEngine.
    /// </value>
    [DataMember(Name = "StreetName", EmitDefaultValue = true)]
    public string StreetName { get; set; }

    /// <summary>
    ///     The house number  This field might be empty if address validation is disabled in ChannelEngine.
    /// </summary>
    /// <value>The house number  This field might be empty if address validation is disabled in ChannelEngine.</value>
    [DataMember(Name = "HouseNr", EmitDefaultValue = true)]
    public string HouseNr { get; set; }

    /// <summary>
    ///     Optional. Addition to the house number  If the address is: Groenhazengracht 2c, the address will be:  StreetName:
    ///     Groenhazengracht  HouseNo: 2  HouseNrAddition: c  This field might be empty if address validation is disabled in
    ///     ChannelEngine.
    /// </summary>
    /// <value>
    ///     Optional. Addition to the house number  If the address is: Groenhazengracht 2c, the address will be:
    ///     StreetName: Groenhazengracht  HouseNo: 2  HouseNrAddition: c  This field might be empty if address validation is
    ///     disabled in ChannelEngine.
    /// </value>
    [DataMember(Name = "HouseNrAddition", EmitDefaultValue = true)]
    public string HouseNrAddition { get; set; }

    /// <summary>
    ///     The zip or postal code.
    /// </summary>
    /// <value>The zip or postal code.</value>
    [DataMember(Name = "ZipCode", EmitDefaultValue = true)]
    public string ZipCode { get; set; }

    /// <summary>
    ///     The name of the city.
    /// </summary>
    /// <value>The name of the city.</value>
    [DataMember(Name = "City", EmitDefaultValue = true)]
    public string City { get; set; }

    /// <summary>
    ///     Optional. State/province/region.
    /// </summary>
    /// <value>Optional. State/province/region.</value>
    [DataMember(Name = "Region", EmitDefaultValue = true)]
    public string Region { get; set; }

    /// <summary>
    ///     For example: NL, BE, FR.
    /// </summary>
    /// <value>For example: NL, BE, FR.</value>
    [DataMember(Name = "CountryIso", EmitDefaultValue = true)]
    public string CountryIso { get; set; }

    /// <summary>
    ///     Optional. The address as a single string: use in case the address lines are entered  as single lines and later
    ///     parsed into street, house number and house number addition.
    /// </summary>
    /// <value>
    ///     Optional. The address as a single string: use in case the address lines are entered  as single lines and later
    ///     parsed into street, house number and house number addition.
    /// </value>
    [DataMember(Name = "Original", EmitDefaultValue = true)]
    public string Original { get; set; }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MerchantAddressResponse {\n");
        sb.Append("  Line1: ").Append(Line1).Append("\n");
        sb.Append("  Line2: ").Append(Line2).Append("\n");
        sb.Append("  Line3: ").Append(Line3).Append("\n");
        sb.Append("  Gender: ").Append(Gender).Append("\n");
        sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
        sb.Append("  FirstName: ").Append(FirstName).Append("\n");
        sb.Append("  LastName: ").Append(LastName).Append("\n");
        sb.Append("  StreetName: ").Append(StreetName).Append("\n");
        sb.Append("  HouseNr: ").Append(HouseNr).Append("\n");
        sb.Append("  HouseNrAddition: ").Append(HouseNrAddition).Append("\n");
        sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
        sb.Append("  City: ").Append(City).Append("\n");
        sb.Append("  Region: ").Append(Region).Append("\n");
        sb.Append("  CountryIso: ").Append(CountryIso).Append("\n");
        sb.Append("  Original: ").Append(Original).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}