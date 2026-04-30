using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayTargetMetadataConfiguration), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetMetadataConfiguration")]
    public interface IBedrockagentcoreGatewayTargetMetadataConfiguration
    {
        /// <summary>A list of URL query parameters that are allowed to be propagated from incoming gateway URL to the target.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#allowed_query_parameters BedrockagentcoreGatewayTarget#allowed_query_parameters}
        /// </remarks>
        [JsiiProperty(name: "allowedQueryParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedQueryParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of HTTP headers that are allowed to be propagated from incoming client requests to the target.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#allowed_request_headers BedrockagentcoreGatewayTarget#allowed_request_headers}
        /// </remarks>
        [JsiiProperty(name: "allowedRequestHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedRequestHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of HTTP headers that are allowed to be propagated from the target response back to the client.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#allowed_response_headers BedrockagentcoreGatewayTarget#allowed_response_headers}
        /// </remarks>
        [JsiiProperty(name: "allowedResponseHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedResponseHeaders
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayTargetMetadataConfiguration), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetMetadataConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetMetadataConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A list of URL query parameters that are allowed to be propagated from incoming gateway URL to the target.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#allowed_query_parameters BedrockagentcoreGatewayTarget#allowed_query_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedQueryParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedQueryParameters
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A list of HTTP headers that are allowed to be propagated from incoming client requests to the target.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#allowed_request_headers BedrockagentcoreGatewayTarget#allowed_request_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedRequestHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedRequestHeaders
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A list of HTTP headers that are allowed to be propagated from the target response back to the client.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway_target#allowed_response_headers BedrockagentcoreGatewayTarget#allowed_response_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedResponseHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedResponseHeaders
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
