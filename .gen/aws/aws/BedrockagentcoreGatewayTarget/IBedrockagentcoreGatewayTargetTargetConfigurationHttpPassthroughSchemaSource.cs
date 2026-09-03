using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchemaSource), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchemaSource")]
    public interface IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchemaSource
    {
        /// <summary>inline_payload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#inline_payload BedrockagentcoreGatewayTarget#inline_payload}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchemaSourceInlinePayload" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "inlinePayload", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchemaSourceInlinePayload\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchemaSourceS3" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchemaSourceS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchemaSource), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchemaSource")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchemaSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>inline_payload block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#inline_payload BedrockagentcoreGatewayTarget#inline_payload}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchemaSourceInlinePayload" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inlinePayload", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchemaSourceInlinePayload\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InlinePayload
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#s3 BedrockagentcoreGatewayTarget#s3}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchemaSourceS3" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchemaSourceS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
