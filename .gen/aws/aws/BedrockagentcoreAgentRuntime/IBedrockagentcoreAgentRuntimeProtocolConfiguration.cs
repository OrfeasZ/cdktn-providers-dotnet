using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntime
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreAgentRuntimeProtocolConfiguration), fullyQualifiedName: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeProtocolConfiguration")]
    public interface IBedrockagentcoreAgentRuntimeProtocolConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#server_protocol BedrockagentcoreAgentRuntime#server_protocol}.</summary>
        [JsiiProperty(name: "serverProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServerProtocol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreAgentRuntimeProtocolConfiguration), fullyQualifiedName: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeProtocolConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeProtocolConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#server_protocol BedrockagentcoreAgentRuntime#server_protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serverProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServerProtocol
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
