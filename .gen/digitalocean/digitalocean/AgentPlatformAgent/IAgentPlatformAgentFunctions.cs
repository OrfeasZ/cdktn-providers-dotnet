using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.AgentPlatformAgent
{
    [JsiiInterface(nativeType: typeof(IAgentPlatformAgentFunctions), fullyQualifiedName: "digitalocean.agentPlatformAgent.AgentPlatformAgentFunctions")]
    public interface IAgentPlatformAgentFunctions
    {
        /// <summary>API Key value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#api_key AgentPlatformAgent#api_key}
        /// </remarks>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Description of the Function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#description AgentPlatformAgent#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#faasname AgentPlatformAgent#faasname}
        /// </remarks>
        [JsiiProperty(name: "faasname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Faasname
        {
            get
            {
                return null;
            }
        }

        /// <summary>Namespace of function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#faasnamespace AgentPlatformAgent#faasnamespace}
        /// </remarks>
        [JsiiProperty(name: "faasnamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Faasnamespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Guardrail UUID for the Function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#guardrail_uuid AgentPlatformAgent#guardrail_uuid}
        /// </remarks>
        [JsiiProperty(name: "guardrailUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GuardrailUuid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of function.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#name AgentPlatformAgent#name}
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

        /// <summary>Url of the Deployment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#url AgentPlatformAgent#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Url
        {
            get
            {
                return null;
            }
        }

        /// <summary>API Key value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#uuid AgentPlatformAgent#uuid}
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

        [JsiiTypeProxy(nativeType: typeof(IAgentPlatformAgentFunctions), fullyQualifiedName: "digitalocean.agentPlatformAgent.AgentPlatformAgentFunctions")]
        internal sealed class _Proxy : DeputyBase, digitalocean.AgentPlatformAgent.IAgentPlatformAgentFunctions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>API Key value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#api_key AgentPlatformAgent#api_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Description of the Function.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#description AgentPlatformAgent#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of function.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#faasname AgentPlatformAgent#faasname}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "faasname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Faasname
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Namespace of function.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#faasnamespace AgentPlatformAgent#faasnamespace}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "faasnamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Faasnamespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Guardrail UUID for the Function.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#guardrail_uuid AgentPlatformAgent#guardrail_uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "guardrailUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GuardrailUuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of function.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#name AgentPlatformAgent#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Url of the Deployment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#url AgentPlatformAgent#url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Url
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>API Key value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#uuid AgentPlatformAgent#uuid}
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
