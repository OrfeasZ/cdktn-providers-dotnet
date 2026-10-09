using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.AgentPlatformAgent
{
    [JsiiInterface(nativeType: typeof(IAgentPlatformAgentChildAgents), fullyQualifiedName: "digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgents")]
    public interface IAgentPlatformAgentChildAgents
    {
        /// <summary>Instruction for the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#instruction AgentPlatformAgent#instruction}
        /// </remarks>
        [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}")]
        string Instruction
        {
            get;
        }

        /// <summary>Model UUID of the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#model_uuid AgentPlatformAgent#model_uuid}
        /// </remarks>
        [JsiiProperty(name: "modelUuid", typeJson: "{\"primitive\":\"string\"}")]
        string ModelUuid
        {
            get;
        }

        /// <summary>Name of the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#name AgentPlatformAgent#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Project ID of the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#project_id AgentPlatformAgent#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectId
        {
            get;
        }

        /// <summary>Region where the Agent is deployed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#region AgentPlatformAgent#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        /// <summary>anthropic_api_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#anthropic_api_key AgentPlatformAgent#anthropic_api_key}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsAnthropicApiKey" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "anthropicApiKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsAnthropicApiKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AnthropicApiKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>api_key_infos block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#api_key_infos AgentPlatformAgent#api_key_infos}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsApiKeyInfos" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "apiKeyInfos", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsApiKeyInfos\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApiKeyInfos
        {
            get
            {
                return null;
            }
        }

        /// <summary>api_keys block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#api_keys AgentPlatformAgent#api_keys}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsApiKeys" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "apiKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsApiKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApiKeys
        {
            get
            {
                return null;
            }
        }

        /// <summary>chatbot block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#chatbot AgentPlatformAgent#chatbot}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsChatbot" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "chatbot", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsChatbot\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Chatbot
        {
            get
            {
                return null;
            }
        }

        /// <summary>chatbot_identifiers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#chatbot_identifiers AgentPlatformAgent#chatbot_identifiers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsChatbotIdentifiers" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "chatbotIdentifiers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsChatbotIdentifiers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ChatbotIdentifiers
        {
            get
            {
                return null;
            }
        }

        /// <summary>deployment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#deployment AgentPlatformAgent#deployment}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsDeployment" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "deployment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsDeployment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Deployment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Description for the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#description AgentPlatformAgent#description}
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

        [JsiiTypeProxy(nativeType: typeof(IAgentPlatformAgentChildAgents), fullyQualifiedName: "digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgents")]
        internal sealed class _Proxy : DeputyBase, digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgents
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Instruction for the Agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#instruction AgentPlatformAgent#instruction}
            /// </remarks>
            [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}")]
            public string Instruction
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Model UUID of the Agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#model_uuid AgentPlatformAgent#model_uuid}
            /// </remarks>
            [JsiiProperty(name: "modelUuid", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelUuid
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name of the Agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#name AgentPlatformAgent#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Project ID of the Agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#project_id AgentPlatformAgent#project_id}
            /// </remarks>
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Region where the Agent is deployed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#region AgentPlatformAgent#region}
            /// </remarks>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>anthropic_api_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#anthropic_api_key AgentPlatformAgent#anthropic_api_key}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsAnthropicApiKey" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "anthropicApiKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsAnthropicApiKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AnthropicApiKey
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>api_key_infos block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#api_key_infos AgentPlatformAgent#api_key_infos}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsApiKeyInfos" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiKeyInfos", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsApiKeyInfos\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ApiKeyInfos
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>api_keys block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#api_keys AgentPlatformAgent#api_keys}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsApiKeys" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsApiKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ApiKeys
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>chatbot block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#chatbot AgentPlatformAgent#chatbot}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsChatbot" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "chatbot", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsChatbot\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Chatbot
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>chatbot_identifiers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#chatbot_identifiers AgentPlatformAgent#chatbot_identifiers}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsChatbotIdentifiers" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "chatbotIdentifiers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsChatbotIdentifiers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ChatbotIdentifiers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>deployment block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#deployment AgentPlatformAgent#deployment}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgentsDeployment" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deployment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgentsDeployment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Deployment
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Description for the Agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_agent#description AgentPlatformAgent#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
