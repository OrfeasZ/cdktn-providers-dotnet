using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVirtualNetwork
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreVirtualNetwork.CoreVirtualNetworkByoipv6CidrDetails")]
    public class CoreVirtualNetworkByoipv6CidrDetails : oci.CoreVirtualNetwork.ICoreVirtualNetworkByoipv6CidrDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_network#byoipv6range_id CoreVirtualNetwork#byoipv6range_id}.</summary>
        [JsiiProperty(name: "byoipv6RangeId", typeJson: "{\"primitive\":\"string\"}")]
        public string Byoipv6RangeId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_network#ipv6cidr_block CoreVirtualNetwork#ipv6cidr_block}.</summary>
        [JsiiProperty(name: "ipv6CidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public string Ipv6CidrBlock
        {
            get;
            set;
        }
    }
}
