using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPoint), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPoint")]
    public interface IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#access_point_arn BedrockagentcoreHarness#access_point_arn}.</summary>
        [JsiiProperty(name: "accessPointArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessPointArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#mount_path BedrockagentcoreHarness#mount_path}.</summary>
        [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MountPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPoint), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPoint")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentFilesystemConfigurationEfsAccessPoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#access_point_arn BedrockagentcoreHarness#access_point_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessPointArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessPointArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_harness#mount_path BedrockagentcoreHarness#mount_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MountPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
