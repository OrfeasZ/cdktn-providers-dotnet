using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityNetworkSource
{
    [JsiiInterface(nativeType: typeof(IIdentityNetworkSourceVirtualSourceListStruct), fullyQualifiedName: "oci.identityNetworkSource.IdentityNetworkSourceVirtualSourceListStruct")]
    public interface IIdentityNetworkSourceVirtualSourceListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_network_source#ip_ranges IdentityNetworkSource#ip_ranges}.</summary>
        [JsiiProperty(name: "ipRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] IpRanges
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_network_source#vcn_id IdentityNetworkSource#vcn_id}.</summary>
        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
        string VcnId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityNetworkSourceVirtualSourceListStruct), fullyQualifiedName: "oci.identityNetworkSource.IdentityNetworkSourceVirtualSourceListStruct")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityNetworkSource.IIdentityNetworkSourceVirtualSourceListStruct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_network_source#ip_ranges IdentityNetworkSource#ip_ranges}.</summary>
            [JsiiProperty(name: "ipRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] IpRanges
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_network_source#vcn_id IdentityNetworkSource#vcn_id}.</summary>
            [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
            public string VcnId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
