using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationSessionStorage")]
    public class BedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationSessionStorage : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationSessionStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#mount_path BedrockagentcoreHarness#mount_path}.</summary>
        [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}")]
        public string MountPath
        {
            get;
            set;
        }
    }
}
