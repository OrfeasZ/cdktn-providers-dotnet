using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGateway
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayInterceptorConfigurationInterceptor), fullyQualifiedName: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayInterceptorConfigurationInterceptor")]
    public interface IBedrockagentcoreGatewayInterceptorConfigurationInterceptor
    {
        /// <summary>lambda block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway#lambda BedrockagentcoreGateway#lambda}
        /// </remarks>
        [JsiiProperty(name: "lambda", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayInterceptorConfigurationInterceptorLambda\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Lambda
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayInterceptorConfigurationInterceptor), fullyQualifiedName: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayInterceptorConfigurationInterceptor")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayInterceptorConfigurationInterceptor
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>lambda block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway#lambda BedrockagentcoreGateway#lambda}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambda", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreGateway.BedrockagentcoreGatewayInterceptorConfigurationInterceptorLambda\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Lambda
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
