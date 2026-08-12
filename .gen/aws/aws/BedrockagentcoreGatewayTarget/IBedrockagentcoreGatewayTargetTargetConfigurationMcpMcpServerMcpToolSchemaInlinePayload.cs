using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationMcpMcpServerMcpToolSchemaInlinePayload), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpMcpServerMcpToolSchemaInlinePayload")]
    public interface IBedrockagentcoreGatewayTargetTargetConfigurationMcpMcpServerMcpToolSchemaInlinePayload
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_gateway_target#payload BedrockagentcoreGatewayTarget#payload}.</summary>
        [JsiiProperty(name: "payload", typeJson: "{\"primitive\":\"string\"}")]
        string Payload
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationMcpMcpServerMcpToolSchemaInlinePayload), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpMcpServerMcpToolSchemaInlinePayload")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationMcpMcpServerMcpToolSchemaInlinePayload
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_gateway_target#payload BedrockagentcoreGatewayTarget#payload}.</summary>
            [JsiiProperty(name: "payload", typeJson: "{\"primitive\":\"string\"}")]
            public string Payload
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
