using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WafNetworkAddressList
{
    [JsiiInterface(nativeType: typeof(IWafNetworkAddressListVcnAddresses), fullyQualifiedName: "oci.wafNetworkAddressList.WafNetworkAddressListVcnAddresses")]
    public interface IWafNetworkAddressListVcnAddresses
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_network_address_list#addresses WafNetworkAddressList#addresses}.</summary>
        [JsiiProperty(name: "addresses", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Addresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_network_address_list#vcn_id WafNetworkAddressList#vcn_id}.</summary>
        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VcnId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafNetworkAddressListVcnAddresses), fullyQualifiedName: "oci.wafNetworkAddressList.WafNetworkAddressListVcnAddresses")]
        internal sealed class _Proxy : DeputyBase, oci.WafNetworkAddressList.IWafNetworkAddressListVcnAddresses
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_network_address_list#addresses WafNetworkAddressList#addresses}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "addresses", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Addresses
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_network_address_list#vcn_id WafNetworkAddressList#vcn_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VcnId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
