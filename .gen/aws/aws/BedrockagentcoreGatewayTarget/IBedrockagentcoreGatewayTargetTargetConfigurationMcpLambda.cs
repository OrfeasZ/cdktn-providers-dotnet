using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationMcpLambda), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpLambda")]
    public interface IBedrockagentcoreGatewayTargetTargetConfigurationMcpLambda
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#lambda_arn BedrockagentcoreGatewayTarget#lambda_arn}.</summary>
        [JsiiProperty(name: "lambdaArn", typeJson: "{\"primitive\":\"string\"}")]
        string LambdaArn
        {
            get;
        }

        /// <summary>tool_schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#tool_schema BedrockagentcoreGatewayTarget#tool_schema}
        /// </remarks>
        [JsiiProperty(name: "toolSchema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpLambdaToolSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ToolSchema
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationMcpLambda), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpLambda")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationMcpLambda
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#lambda_arn BedrockagentcoreGatewayTarget#lambda_arn}.</summary>
            [JsiiProperty(name: "lambdaArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LambdaArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>tool_schema block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#tool_schema BedrockagentcoreGatewayTarget#tool_schema}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "toolSchema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpLambdaToolSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ToolSchema
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
