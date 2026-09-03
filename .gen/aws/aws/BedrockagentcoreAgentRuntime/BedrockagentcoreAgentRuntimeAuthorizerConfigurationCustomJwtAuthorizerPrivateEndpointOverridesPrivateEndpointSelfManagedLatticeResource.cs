using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntime
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointSelfManagedLatticeResource")]
    public class BedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointSelfManagedLatticeResource : aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverridesPrivateEndpointSelfManagedLatticeResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_agent_runtime#resource_configuration_identifier BedrockagentcoreAgentRuntime#resource_configuration_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceConfigurationIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceConfigurationIdentifier
        {
            get;
            set;
        }
    }
}
