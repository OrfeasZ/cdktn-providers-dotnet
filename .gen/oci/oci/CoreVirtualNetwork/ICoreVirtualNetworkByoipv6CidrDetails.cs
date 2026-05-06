using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVirtualNetwork
{
    [JsiiInterface(nativeType: typeof(ICoreVirtualNetworkByoipv6CidrDetails), fullyQualifiedName: "oci.coreVirtualNetwork.CoreVirtualNetworkByoipv6CidrDetails")]
    public interface ICoreVirtualNetworkByoipv6CidrDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_network#byoipv6range_id CoreVirtualNetwork#byoipv6range_id}.</summary>
        [JsiiProperty(name: "byoipv6RangeId", typeJson: "{\"primitive\":\"string\"}")]
        string Byoipv6RangeId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_network#ipv6cidr_block CoreVirtualNetwork#ipv6cidr_block}.</summary>
        [JsiiProperty(name: "ipv6CidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        string Ipv6CidrBlock
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreVirtualNetworkByoipv6CidrDetails), fullyQualifiedName: "oci.coreVirtualNetwork.CoreVirtualNetworkByoipv6CidrDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CoreVirtualNetwork.ICoreVirtualNetworkByoipv6CidrDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_network#byoipv6range_id CoreVirtualNetwork#byoipv6range_id}.</summary>
            [JsiiProperty(name: "byoipv6RangeId", typeJson: "{\"primitive\":\"string\"}")]
            public string Byoipv6RangeId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_virtual_network#ipv6cidr_block CoreVirtualNetwork#ipv6cidr_block}.</summary>
            [JsiiProperty(name: "ipv6CidrBlock", typeJson: "{\"primitive\":\"string\"}")]
            public string Ipv6CidrBlock
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
