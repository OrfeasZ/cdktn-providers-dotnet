using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetPrivateEndpointSelfManagedLatticeResource")]
    public class BedrockagentcoreGatewayTargetPrivateEndpointSelfManagedLatticeResource : aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetPrivateEndpointSelfManagedLatticeResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_gateway_target#resource_configuration_identifier BedrockagentcoreGatewayTarget#resource_configuration_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceConfigurationIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceConfigurationIdentifier
        {
            get;
            set;
        }
    }
}
