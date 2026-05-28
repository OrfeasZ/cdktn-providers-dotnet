using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntime
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeFilesystemConfigurationSessionStorage")]
    public class BedrockagentcoreAgentRuntimeFilesystemConfigurationSessionStorage : aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeFilesystemConfigurationSessionStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_agent_runtime#mount_path BedrockagentcoreAgentRuntime#mount_path}.</summary>
        [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}")]
        public string MountPath
        {
            get;
            set;
        }
    }
}
