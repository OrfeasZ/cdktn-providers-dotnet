using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderOperationModel), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderOperationModel")]
    public interface IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderOperationModel
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#model BedrockagentcoreGatewayTarget#model}.</summary>
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}")]
        string Model
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderOperationModel), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderOperationModel")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationInferenceProviderOperationModel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#model BedrockagentcoreGatewayTarget#model}.</summary>
            [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}")]
            public string Model
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
