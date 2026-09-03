using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSource")]
    public class BedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSource : aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSource
    {
        private object? _inlinePayload;

        /// <summary>inline_payload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#inline_payload BedrockagentcoreGatewayTarget#inline_payload}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSourceInlinePayload" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inlinePayload", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSourceInlinePayload\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InlinePayload
        {
            get => _inlinePayload;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSourceInlinePayload[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSourceInlinePayload).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inlinePayload = value;
            }
        }

        private object? _s3;

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#s3 BedrockagentcoreGatewayTarget#s3}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSourceS3" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSourceS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3
        {
            get => _s3;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSourceS3[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpAgentcoreRuntimeSchemaSourceS3).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3 = value;
            }
        }
    }
}
