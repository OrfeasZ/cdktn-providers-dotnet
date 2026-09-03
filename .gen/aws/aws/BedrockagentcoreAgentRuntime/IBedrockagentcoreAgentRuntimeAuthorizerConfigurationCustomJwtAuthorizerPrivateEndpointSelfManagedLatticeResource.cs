using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntime
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource), fullyQualifiedName: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource")]
    public interface IBedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_agent_runtime#resource_configuration_identifier BedrockagentcoreAgentRuntime#resource_configuration_identifier}.</summary>
        [JsiiProperty(name: "resourceConfigurationIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceConfigurationIdentifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource), fullyQualifiedName: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointSelfManagedLatticeResource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_agent_runtime#resource_configuration_identifier BedrockagentcoreAgentRuntime#resource_configuration_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceConfigurationIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceConfigurationIdentifier
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
