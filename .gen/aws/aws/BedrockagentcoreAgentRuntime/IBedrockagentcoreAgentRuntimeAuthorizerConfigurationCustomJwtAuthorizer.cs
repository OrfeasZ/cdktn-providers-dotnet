using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntime
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizer), fullyQualifiedName: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizer")]
    public interface IBedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#discovery_url BedrockagentcoreAgentRuntime#discovery_url}.</summary>
        [JsiiProperty(name: "discoveryUrl", typeJson: "{\"primitive\":\"string\"}")]
        string DiscoveryUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#allowed_audience BedrockagentcoreAgentRuntime#allowed_audience}.</summary>
        [JsiiProperty(name: "allowedAudience", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedAudience
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#allowed_clients BedrockagentcoreAgentRuntime#allowed_clients}.</summary>
        [JsiiProperty(name: "allowedClients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedClients
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#allowed_scopes BedrockagentcoreAgentRuntime#allowed_scopes}.</summary>
        [JsiiProperty(name: "allowedScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedScopes
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_claim block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#custom_claim BedrockagentcoreAgentRuntime#custom_claim}
        /// </remarks>
        [JsiiProperty(name: "customClaim", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizerCustomClaim\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomClaim
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizer), fullyQualifiedName: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizer")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#discovery_url BedrockagentcoreAgentRuntime#discovery_url}.</summary>
            [JsiiProperty(name: "discoveryUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string DiscoveryUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#allowed_audience BedrockagentcoreAgentRuntime#allowed_audience}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedAudience", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedAudience
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#allowed_clients BedrockagentcoreAgentRuntime#allowed_clients}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedClients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedClients
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#allowed_scopes BedrockagentcoreAgentRuntime#allowed_scopes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedScopes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>custom_claim block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_agent_runtime#custom_claim BedrockagentcoreAgentRuntime#custom_claim}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customClaim", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeAuthorizerConfigurationCustomJwtAuthorizerCustomClaim\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomClaim
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
