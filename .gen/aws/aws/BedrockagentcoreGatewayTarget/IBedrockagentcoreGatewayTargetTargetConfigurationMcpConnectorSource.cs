using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationMcpConnectorSource), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpConnectorSource")]
    public interface IBedrockagentcoreGatewayTargetTargetConfigurationMcpConnectorSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#connector_id BedrockagentcoreGatewayTarget#connector_id}.</summary>
        [JsiiProperty(name: "connectorId", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectorId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#version BedrockagentcoreGatewayTarget#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationMcpConnectorSource), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpConnectorSource")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationMcpConnectorSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#connector_id BedrockagentcoreGatewayTarget#connector_id}.</summary>
            [JsiiProperty(name: "connectorId", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectorId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#version BedrockagentcoreGatewayTarget#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
