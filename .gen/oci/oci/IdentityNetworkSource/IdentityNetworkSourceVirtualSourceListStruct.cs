using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityNetworkSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityNetworkSource.IdentityNetworkSourceVirtualSourceListStruct")]
    public class IdentityNetworkSourceVirtualSourceListStruct : oci.IdentityNetworkSource.IIdentityNetworkSourceVirtualSourceListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_network_source#ip_ranges IdentityNetworkSource#ip_ranges}.</summary>
        [JsiiProperty(name: "ipRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] IpRanges
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_network_source#vcn_id IdentityNetworkSource#vcn_id}.</summary>
        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
        public string VcnId
        {
            get;
            set;
        }
    }
}
