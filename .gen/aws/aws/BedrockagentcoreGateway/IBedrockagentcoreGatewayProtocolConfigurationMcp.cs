using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGateway
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayProtocolConfigurationMcp), fullyQualifiedName: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcp")]
    public interface IBedrockagentcoreGatewayProtocolConfigurationMcp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway#instructions BedrockagentcoreGateway#instructions}.</summary>
        [JsiiProperty(name: "instructions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Instructions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway#search_type BedrockagentcoreGateway#search_type}.</summary>
        [JsiiProperty(name: "searchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SearchType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway#supported_versions BedrockagentcoreGateway#supported_versions}.</summary>
        [JsiiProperty(name: "supportedVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SupportedVersions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayProtocolConfigurationMcp), fullyQualifiedName: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayProtocolConfigurationMcp")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayProtocolConfigurationMcp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway#instructions BedrockagentcoreGateway#instructions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instructions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Instructions
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway#search_type BedrockagentcoreGateway#search_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "searchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SearchType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway#supported_versions BedrockagentcoreGateway#supported_versions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "supportedVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SupportedVersions
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
