using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource")]
    public class BedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#resource_configuration_identifier BedrockagentcoreHarness#resource_configuration_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceConfigurationIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceConfigurationIdentifier
        {
            get;
            set;
        }
    }
}
