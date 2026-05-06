using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WafNetworkAddressList
{
    [JsiiByValue(fqn: "oci.wafNetworkAddressList.WafNetworkAddressListVcnAddresses")]
    public class WafNetworkAddressListVcnAddresses : oci.WafNetworkAddressList.IWafNetworkAddressListVcnAddresses
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_network_address_list#addresses WafNetworkAddressList#addresses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "addresses", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Addresses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_network_address_list#vcn_id WafNetworkAddressList#vcn_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VcnId
        {
            get;
            set;
        }
    }
}
