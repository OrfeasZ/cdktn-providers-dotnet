using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthrough")]
    public class BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthrough : aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthrough
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#endpoint BedrockagentcoreGatewayTarget#endpoint}.</summary>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string Endpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#protocol_type BedrockagentcoreGatewayTarget#protocol_type}.</summary>
        [JsiiProperty(name: "protocolType", typeJson: "{\"primitive\":\"string\"}")]
        public string ProtocolType
        {
            get;
            set;
        }

        private object? _schema;

        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#schema BedrockagentcoreGatewayTarget#schema}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchema" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Schema
        {
            get => _schema;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchema[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchema).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _schema = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#static_query_parameter_conflict_resolution BedrockagentcoreGatewayTarget#static_query_parameter_conflict_resolution}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "staticQueryParameterConflictResolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StaticQueryParameterConflictResolution
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#static_query_parameters BedrockagentcoreGatewayTarget#static_query_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "staticQueryParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? StaticQueryParameters
        {
            get;
            set;
        }

        private object? _stickinessConfiguration;

        /// <summary>stickiness_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#stickiness_configuration BedrockagentcoreGatewayTarget#stickiness_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughStickinessConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stickinessConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughStickinessConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StickinessConfiguration
        {
            get => _stickinessConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughStickinessConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughStickinessConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stickinessConfiguration = value;
            }
        }
    }
}
