using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntime
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfiguration")]
    public class BedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfiguration : aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#container_uri BedrockagentcoreAgentRuntime#container_uri}.</summary>
        [JsiiProperty(name: "containerUri", typeJson: "{\"primitive\":\"string\"}")]
        public string ContainerUri
        {
            get;
            set;
        }
    }
}
