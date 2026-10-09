using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.AgentPlatformAgent
{
    [JsiiInterface(nativeType: typeof(IAgentPlatformAgentParentAgentsApiKeyInfos), fullyQualifiedName: "digitalocean.agentPlatformAgent.AgentPlatformAgentParentAgentsApiKeyInfos")]
    public interface IAgentPlatformAgentParentAgentsApiKeyInfos
    {
        /// <summary>Created By user ID for the API Key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#created_by AgentPlatformAgent#created_by}
        /// </remarks>
        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreatedBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the API Key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#name AgentPlatformAgent#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Updated At timestamp for the API Key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#secret_key AgentPlatformAgent#secret_key}
        /// </remarks>
        [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>API Key value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#uuid AgentPlatformAgent#uuid}
        /// </remarks>
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uuid
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAgentPlatformAgentParentAgentsApiKeyInfos), fullyQualifiedName: "digitalocean.agentPlatformAgent.AgentPlatformAgentParentAgentsApiKeyInfos")]
        internal sealed class _Proxy : DeputyBase, digitalocean.AgentPlatformAgent.IAgentPlatformAgentParentAgentsApiKeyInfos
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Created By user ID for the API Key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#created_by AgentPlatformAgent#created_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreatedBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the API Key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#name AgentPlatformAgent#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Updated At timestamp for the API Key.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#secret_key AgentPlatformAgent#secret_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>API Key value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#uuid AgentPlatformAgent#uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uuid
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
