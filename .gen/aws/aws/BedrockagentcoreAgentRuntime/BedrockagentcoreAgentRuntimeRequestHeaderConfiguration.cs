using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntime
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeRequestHeaderConfiguration")]
    public class BedrockagentcoreAgentRuntimeRequestHeaderConfiguration : aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeRequestHeaderConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagentcore_agent_runtime#request_header_allowlist BedrockagentcoreAgentRuntime#request_header_allowlist}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requestHeaderAllowlist", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RequestHeaderAllowlist
        {
            get;
            set;
        }
    }
}
