using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGateway
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayInterceptorConfigurationInterceptorLambda), fullyQualifiedName: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayInterceptorConfigurationInterceptorLambda")]
    public interface IBedrockagentcoreGatewayInterceptorConfigurationInterceptorLambda
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway#arn BedrockagentcoreGateway#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayInterceptorConfigurationInterceptorLambda), fullyQualifiedName: "aws.bedrockagentcoreGateway.BedrockagentcoreGatewayInterceptorConfigurationInterceptorLambda")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGateway.IBedrockagentcoreGatewayInterceptorConfigurationInterceptorLambda
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_gateway#arn BedrockagentcoreGateway#arn}.</summary>
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
