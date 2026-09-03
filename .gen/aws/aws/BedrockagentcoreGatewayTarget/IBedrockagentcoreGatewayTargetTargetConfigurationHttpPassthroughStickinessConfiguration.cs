using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughStickinessConfiguration), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughStickinessConfiguration")]
    public interface IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughStickinessConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#identifier BedrockagentcoreGatewayTarget#identifier}.</summary>
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
        string Identifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#composite_identifier BedrockagentcoreGatewayTarget#composite_identifier}.</summary>
        [JsiiProperty(name: "compositeIdentifier", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CompositeIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#timeout BedrockagentcoreGatewayTarget#timeout}.</summary>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Timeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughStickinessConfiguration), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughStickinessConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationHttpPassthroughStickinessConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#identifier BedrockagentcoreGatewayTarget#identifier}.</summary>
            [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
            public string Identifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#composite_identifier BedrockagentcoreGatewayTarget#composite_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compositeIdentifier", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CompositeIdentifier
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#timeout BedrockagentcoreGatewayTarget#timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Timeout
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
