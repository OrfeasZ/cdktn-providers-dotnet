using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentNetworkConfigurationNetworkModeConfig), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentNetworkConfigurationNetworkModeConfig")]
    public interface IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentNetworkConfigurationNetworkModeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#security_groups BedrockagentcoreHarness#security_groups}.</summary>
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SecurityGroups
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#subnets BedrockagentcoreHarness#subnets}.</summary>
        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Subnets
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentNetworkConfigurationNetworkModeConfig), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentNetworkConfigurationNetworkModeConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentAgentcoreRuntimeEnvironmentNetworkConfigurationNetworkModeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#security_groups BedrockagentcoreHarness#security_groups}.</summary>
            [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SecurityGroups
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#subnets BedrockagentcoreHarness#subnets}.</summary>
            [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Subnets
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
