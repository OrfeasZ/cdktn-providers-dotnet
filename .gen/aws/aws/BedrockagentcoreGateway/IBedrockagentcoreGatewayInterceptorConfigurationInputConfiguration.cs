using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGateway
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayInterceptorConfigurationInputConfiguration), fullyQualifiedName: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayInterceptorConfigurationInputConfiguration")]
    public interface IBedrockagentcoreGatewayInterceptorConfigurationInputConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway#pass_request_headers BedrockagentcoreGateway#pass_request_headers}.</summary>
        [JsiiProperty(name: "passRequestHeaders", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object PassRequestHeaders
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayInterceptorConfigurationInputConfiguration), fullyQualifiedName: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayInterceptorConfigurationInputConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayInterceptorConfigurationInputConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_gateway#pass_request_headers BedrockagentcoreGateway#pass_request_headers}.</summary>
            [JsiiProperty(name: "passRequestHeaders", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object PassRequestHeaders
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
