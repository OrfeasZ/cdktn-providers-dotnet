using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntime
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeFilesystemConfigurationEfsAccessPoint")]
    public class BedrockagentcoreAgentRuntimeFilesystemConfigurationEfsAccessPoint : aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeFilesystemConfigurationEfsAccessPoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_agent_runtime#access_point_arn BedrockagentcoreAgentRuntime#access_point_arn}.</summary>
        [JsiiProperty(name: "accessPointArn", typeJson: "{\"primitive\":\"string\"}")]
        public string AccessPointArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/bedrockagentcore_agent_runtime#mount_path BedrockagentcoreAgentRuntime#mount_path}.</summary>
        [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}")]
        public string MountPath
        {
            get;
            set;
        }
    }
}
