using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthrough), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthrough")]
    public interface IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthrough
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#endpoint BedrockagentcoreGatewayTarget#endpoint}.</summary>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        string Endpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#protocol_type BedrockagentcoreGatewayTarget#protocol_type}.</summary>
        [JsiiProperty(name: "protocolType", typeJson: "{\"primitive\":\"string\"}")]
        string ProtocolType
        {
            get;
        }

        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#schema BedrockagentcoreGatewayTarget#schema}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchema" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "schema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Schema
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#static_query_parameter_conflict_resolution BedrockagentcoreGatewayTarget#static_query_parameter_conflict_resolution}.</summary>
        [JsiiProperty(name: "staticQueryParameterConflictResolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StaticQueryParameterConflictResolution
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#static_query_parameters BedrockagentcoreGatewayTarget#static_query_parameters}.</summary>
        [JsiiProperty(name: "staticQueryParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? StaticQueryParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>stickiness_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#stickiness_configuration BedrockagentcoreGatewayTarget#stickiness_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughStickinessConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "stickinessConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughStickinessConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StickinessConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthrough), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthrough")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthrough
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#endpoint BedrockagentcoreGatewayTarget#endpoint}.</summary>
            [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string Endpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#protocol_type BedrockagentcoreGatewayTarget#protocol_type}.</summary>
            [JsiiProperty(name: "protocolType", typeJson: "{\"primitive\":\"string\"}")]
            public string ProtocolType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>schema block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#schema BedrockagentcoreGatewayTarget#schema}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchema" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Schema
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#static_query_parameter_conflict_resolution BedrockagentcoreGatewayTarget#static_query_parameter_conflict_resolution}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "staticQueryParameterConflictResolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StaticQueryParameterConflictResolution
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#static_query_parameters BedrockagentcoreGatewayTarget#static_query_parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "staticQueryParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? StaticQueryParameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>stickiness_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#stickiness_configuration BedrockagentcoreGatewayTarget#stickiness_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughStickinessConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stickinessConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughStickinessConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StickinessConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
