using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationInferenceConnectorSource), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationInferenceConnectorSource")]
    public interface IBedrockagentcoreGatewayTargetTargetConfigurationInferenceConnectorSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#connector_id BedrockagentcoreGatewayTarget#connector_id}.</summary>
        [JsiiProperty(name: "connectorId", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectorId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreGatewayTargetTargetConfigurationInferenceConnectorSource), fullyQualifiedName: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationInferenceConnectorSource")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationInferenceConnectorSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#connector_id BedrockagentcoreGatewayTarget#connector_id}.</summary>
            [JsiiProperty(name: "connectorId", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectorId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
