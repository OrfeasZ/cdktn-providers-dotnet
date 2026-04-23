using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationMcpApiGatewayApiGatewayToolConfiguration), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpApiGatewayApiGatewayToolConfiguration")]
    public interface IBedrockagentcoreGatewayTargetTargetConfigurationMcpApiGatewayApiGatewayToolConfiguration
    {
        /// <summary>tool_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#tool_filter BedrockagentcoreGatewayTarget#tool_filter}
        /// </remarks>
        [JsiiProperty(name: "toolFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpApiGatewayApiGatewayToolConfigurationToolFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ToolFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>tool_override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#tool_override BedrockagentcoreGatewayTarget#tool_override}
        /// </remarks>
        [JsiiProperty(name: "toolOverride", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpApiGatewayApiGatewayToolConfigurationToolOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ToolOverride
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationMcpApiGatewayApiGatewayToolConfiguration), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpApiGatewayApiGatewayToolConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationMcpApiGatewayApiGatewayToolConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>tool_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#tool_filter BedrockagentcoreGatewayTarget#tool_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "toolFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpApiGatewayApiGatewayToolConfigurationToolFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ToolFilter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tool_override block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#tool_override BedrockagentcoreGatewayTarget#tool_override}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "toolOverride", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpApiGatewayApiGatewayToolConfigurationToolOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ToolOverride
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
