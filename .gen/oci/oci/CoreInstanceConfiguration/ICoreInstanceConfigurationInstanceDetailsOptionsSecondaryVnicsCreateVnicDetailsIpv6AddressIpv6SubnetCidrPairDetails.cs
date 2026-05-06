using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstanceConfiguration
{
    [JsiiInterface(nativeType: typeof(ICoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails")]
    public interface ICoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#ipv6address CoreInstanceConfiguration#ipv6address}.</summary>
        [JsiiProperty(name: "ipv6Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv6Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#ipv6subnet_cidr CoreInstanceConfiguration#ipv6subnet_cidr}.</summary>
        [JsiiProperty(name: "ipv6SubnetCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv6SubnetCidr
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails), fullyQualifiedName: "oci.coreInstanceConfiguration.CoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstanceConfiguration.ICoreInstanceConfigurationInstanceDetailsOptionsSecondaryVnicsCreateVnicDetailsIpv6AddressIpv6SubnetCidrPairDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#ipv6address CoreInstanceConfiguration#ipv6address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv6Address
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_instance_configuration#ipv6subnet_cidr CoreInstanceConfiguration#ipv6subnet_cidr}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6SubnetCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv6SubnetCidr
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
