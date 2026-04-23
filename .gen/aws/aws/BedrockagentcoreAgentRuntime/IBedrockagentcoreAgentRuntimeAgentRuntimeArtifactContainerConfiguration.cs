using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntime
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfiguration), fullyQualifiedName: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfiguration")]
    public interface IBedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#container_uri BedrockagentcoreAgentRuntime#container_uri}.</summary>
        [JsiiProperty(name: "containerUri", typeJson: "{\"primitive\":\"string\"}")]
        string ContainerUri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfiguration), fullyQualifiedName: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAgentRuntimeArtifactContainerConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#container_uri BedrockagentcoreAgentRuntime#container_uri}.</summary>
            [JsiiProperty(name: "containerUri", typeJson: "{\"primitive\":\"string\"}")]
            public string ContainerUri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
