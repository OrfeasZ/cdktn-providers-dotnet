using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPoint")]
    public class BedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPoint : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#access_point_arn BedrockagentcoreHarness#access_point_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessPointArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessPointArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#mount_path BedrockagentcoreHarness#mount_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MountPath
        {
            get;
            set;
        }
    }
}
