using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeResourceConfiguration
{
    [JsiiInterface(nativeType: typeof(IVpclatticeResourceConfigurationResourceConfigurationDefinitionCidrResource), fullyQualifiedName: "aws.vpclatticeResourceConfiguration.VpclatticeResourceConfigurationResourceConfigurationDefinitionCidrResource")]
    public interface IVpclatticeResourceConfigurationResourceConfigurationDefinitionCidrResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/vpclattice_resource_configuration#cidr_ranges VpclatticeResourceConfiguration#cidr_ranges}.</summary>
        [JsiiProperty(name: "cidrRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] CidrRanges
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpclatticeResourceConfigurationResourceConfigurationDefinitionCidrResource), fullyQualifiedName: "aws.vpclatticeResourceConfiguration.VpclatticeResourceConfigurationResourceConfigurationDefinitionCidrResource")]
        internal sealed class _Proxy : DeputyBase, aws.VpclatticeResourceConfiguration.IVpclatticeResourceConfigurationResourceConfigurationDefinitionCidrResource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/vpclattice_resource_configuration#cidr_ranges VpclatticeResourceConfiguration#cidr_ranges}.</summary>
            [JsiiProperty(name: "cidrRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] CidrRanges
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
