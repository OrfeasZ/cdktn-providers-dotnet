using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayTargetPrivateEndpointSelfManagedLatticeResource), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetPrivateEndpointSelfManagedLatticeResource")]
    public interface IBedrockagentcoreGatewayTargetPrivateEndpointSelfManagedLatticeResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrockagentcore_gateway_target#resource_configuration_identifier BedrockagentcoreGatewayTarget#resource_configuration_identifier}.</summary>
        [JsiiProperty(name: "resourceConfigurationIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceConfigurationIdentifier
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayTargetPrivateEndpointSelfManagedLatticeResource), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetPrivateEndpointSelfManagedLatticeResource")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetPrivateEndpointSelfManagedLatticeResource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrockagentcore_gateway_target#resource_configuration_identifier BedrockagentcoreGatewayTarget#resource_configuration_identifier}.</summary>
            [JsiiProperty(name: "resourceConfigurationIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceConfigurationIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
