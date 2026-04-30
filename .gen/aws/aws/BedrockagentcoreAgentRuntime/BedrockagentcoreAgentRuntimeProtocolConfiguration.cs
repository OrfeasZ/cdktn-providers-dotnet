using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntime
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeProtocolConfiguration")]
    public class BedrockagentcoreAgentRuntimeProtocolConfiguration : aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeProtocolConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_agent_runtime#server_protocol BedrockagentcoreAgentRuntime#server_protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServerProtocol
        {
            get;
            set;
        }
    }
}
