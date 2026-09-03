using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSource), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSource")]
    public interface IBedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSource
    {
        /// <summary>inline_payload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#inline_payload BedrockagentcoreGatewayTarget#inline_payload}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSourceInlinePayload" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "inlinePayload", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSourceInlinePayload\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InlinePayload
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#s3 BedrockagentcoreGatewayTarget#s3}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSourceS3" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSourceS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSource), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSource")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>inline_payload block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#inline_payload BedrockagentcoreGatewayTarget#inline_payload}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSourceInlinePayload" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inlinePayload", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSourceInlinePayload\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InlinePayload
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#s3 BedrockagentcoreGatewayTarget#s3}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSourceS3" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSourceS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
