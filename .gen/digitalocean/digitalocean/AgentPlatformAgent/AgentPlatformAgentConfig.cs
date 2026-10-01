using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.AgentPlatformAgent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.agentPlatformAgent.AgentPlatformAgentConfig")]
    public class AgentPlatformAgentConfig : digitalocean.AgentPlatformAgent.IAgentPlatformAgentConfig
    {
        /// <summary>Instruction for the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#instruction AgentPlatformAgent#instruction}
        /// </remarks>
        [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}")]
        public string Instruction
        {
            get;
            set;
        }

        /// <summary>Model UUID of the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#model_uuid AgentPlatformAgent#model_uuid}
        /// </remarks>
        [JsiiProperty(name: "modelUuid", typeJson: "{\"primitive\":\"string\"}")]
        public string ModelUuid
        {
            get;
            set;
        }

        /// <summary>Name of the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#name AgentPlatformAgent#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Project ID of the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#project_id AgentPlatformAgent#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public string ProjectId
        {
            get;
            set;
        }

        /// <summary>Region where the Agent is deployed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#region AgentPlatformAgent#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public string Region
        {
            get;
            set;
        }

        private object? _agentGuardrail;

        /// <summary>agent_guardrail block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#agent_guardrail AgentPlatformAgent#agent_guardrail}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentAgentGuardrail" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "agentGuardrail", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentAgentGuardrail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AgentGuardrail
        {
            get => _agentGuardrail;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformAgent.IAgentPlatformAgentAgentGuardrail[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentAgentGuardrail).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _agentGuardrail = value;
            }
        }

        private object? _anthropicApiKey;

        /// <summary>anthropic_api_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#anthropic_api_key AgentPlatformAgent#anthropic_api_key}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentAnthropicApiKey" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anthropicApiKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentAnthropicApiKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AnthropicApiKey
        {
            get => _anthropicApiKey;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformAgent.IAgentPlatformAgentAnthropicApiKey[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentAnthropicApiKey).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _anthropicApiKey = value;
            }
        }

        /// <summary>Optional Anthropic API key ID to use with Anthropic models.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#anthropic_key_uuid AgentPlatformAgent#anthropic_key_uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anthropicKeyUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AnthropicKeyUuid
        {
            get;
            set;
        }

        private object? _apiKeyInfos;

        /// <summary>api_key_infos block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#api_key_infos AgentPlatformAgent#api_key_infos}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentApiKeyInfos" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiKeyInfos", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentApiKeyInfos\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ApiKeyInfos
        {
            get => _apiKeyInfos;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformAgent.IAgentPlatformAgentApiKeyInfos[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentApiKeyInfos).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _apiKeyInfos = value;
            }
        }

        private object? _apiKeys;

        /// <summary>api_keys block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#api_keys AgentPlatformAgent#api_keys}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentApiKeys" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentApiKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ApiKeys
        {
            get => _apiKeys;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformAgent.IAgentPlatformAgentApiKeys[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentApiKeys).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _apiKeys = value;
            }
        }

        private object? _chatbot;

        /// <summary>chatbot block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#chatbot AgentPlatformAgent#chatbot}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChatbot" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "chatbot", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChatbot\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Chatbot
        {
            get => _chatbot;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformAgent.IAgentPlatformAgentChatbot[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentChatbot).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _chatbot = value;
            }
        }

        private object? _chatbotIdentifiers;

        /// <summary>chatbot_identifiers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#chatbot_identifiers AgentPlatformAgent#chatbot_identifiers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChatbotIdentifiers" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "chatbotIdentifiers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChatbotIdentifiers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ChatbotIdentifiers
        {
            get => _chatbotIdentifiers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformAgent.IAgentPlatformAgentChatbotIdentifiers[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentChatbotIdentifiers).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _chatbotIdentifiers = value;
            }
        }

        private object? _childAgents;

        /// <summary>child_agents block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#child_agents AgentPlatformAgent#child_agents}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgents" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "childAgents", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentChildAgents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ChildAgents
        {
            get => _childAgents;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgents[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentChildAgents).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _childAgents = value;
            }
        }

        /// <summary>Timestamp when the Agent was created.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#created_at AgentPlatformAgent#created_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CreatedAt
        {
            get;
            set;
        }

        private object? _deployment;

        /// <summary>deployment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#deployment AgentPlatformAgent#deployment}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentDeployment" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deployment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentDeployment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Deployment
        {
            get => _deployment;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformAgent.IAgentPlatformAgentDeployment[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentDeployment).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _deployment = value;
            }
        }

        /// <summary>Description for the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#description AgentPlatformAgent#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        private object? _functions;

        /// <summary>functions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#functions AgentPlatformAgent#functions}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentFunctions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "functions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentFunctions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Functions
        {
            get => _functions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformAgent.IAgentPlatformAgentFunctions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentFunctions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _functions = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#id AgentPlatformAgent#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>If case condition.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#if_case AgentPlatformAgent#if_case}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ifCase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IfCase
        {
            get;
            set;
        }

        /// <summary>K value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#k AgentPlatformAgent#k}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "k", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? K
        {
            get;
            set;
        }

        private object? _knowledgeBases;

        /// <summary>knowledge_bases block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#knowledge_bases AgentPlatformAgent#knowledge_bases}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentKnowledgeBases" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "knowledgeBases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentKnowledgeBases\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? KnowledgeBases
        {
            get => _knowledgeBases;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformAgent.IAgentPlatformAgentKnowledgeBases[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentKnowledgeBases).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _knowledgeBases = value;
            }
        }

        /// <summary>Ids of the knowledge base(s) to attach to the agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#knowledge_base_uuid AgentPlatformAgent#knowledge_base_uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "knowledgeBaseUuid", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? KnowledgeBaseUuid
        {
            get;
            set;
        }

        /// <summary>Maximum tokens allowed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#max_tokens AgentPlatformAgent#max_tokens}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxTokens", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxTokens
        {
            get;
            set;
        }

        private object? _model;

        /// <summary>model block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#model AgentPlatformAgent#model}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentModel" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "model", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentModel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Model
        {
            get => _model;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformAgent.IAgentPlatformAgentModel[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentModel).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _model = value;
            }
        }

        private object? _openAiApiKey;

        /// <summary>open_ai_api_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#open_ai_api_key AgentPlatformAgent#open_ai_api_key}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentOpenAiApiKey" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openAiApiKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentOpenAiApiKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OpenAiApiKey
        {
            get => _openAiApiKey;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformAgent.IAgentPlatformAgentOpenAiApiKey[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentOpenAiApiKey).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _openAiApiKey = value;
            }
        }

        /// <summary>Optional OpenAI API key ID to use with OpenAI models.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#open_ai_key_uuid AgentPlatformAgent#open_ai_key_uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openAiKeyUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OpenAiKeyUuid
        {
            get;
            set;
        }

        private object? _parentAgents;

        /// <summary>parent_agents block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#parent_agents AgentPlatformAgent#parent_agents}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentParentAgents" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parentAgents", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentParentAgents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ParentAgents
        {
            get => _parentAgents;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformAgent.IAgentPlatformAgentParentAgents[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentParentAgents).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parentAgents = value;
            }
        }

        private object? _provideCitations;

        /// <summary>Indicates if the agent should provide citations in responses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#provide_citations AgentPlatformAgent#provide_citations}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provideCitations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ProvideCitations
        {
            get => _provideCitations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _provideCitations = value;
            }
        }

        /// <summary>Retrieval method used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#retrieval_method AgentPlatformAgent#retrieval_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retrievalMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RetrievalMethod
        {
            get;
            set;
        }

        /// <summary>User who created the route.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#route_created_by AgentPlatformAgent#route_created_by}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "routeCreatedBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RouteCreatedBy
        {
            get;
            set;
        }

        /// <summary>Route name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#route_name AgentPlatformAgent#route_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "routeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RouteName
        {
            get;
            set;
        }

        /// <summary>Route UUID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#route_uuid AgentPlatformAgent#route_uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "routeUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RouteUuid
        {
            get;
            set;
        }

        /// <summary>List of Tags.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#tags AgentPlatformAgent#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Tags
        {
            get;
            set;
        }

        /// <summary>Agent temperature setting.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#temperature AgentPlatformAgent#temperature}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "temperature", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Temperature
        {
            get;
            set;
        }

        private object? _template;

        /// <summary>template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#template AgentPlatformAgent#template}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.AgentPlatformAgent.IAgentPlatformAgentTemplate" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "template", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.agentPlatformAgent.AgentPlatformAgentTemplate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Template
        {
            get => _template;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.AgentPlatformAgent.IAgentPlatformAgentTemplate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.AgentPlatformAgent.IAgentPlatformAgentTemplate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _template = value;
            }
        }

        /// <summary>Top P sampling parameter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#top_p AgentPlatformAgent#top_p}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "topP", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TopP
        {
            get;
            set;
        }

        /// <summary>URL for the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#url AgentPlatformAgent#url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Url
        {
            get;
            set;
        }

        /// <summary>User ID linked with the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#user_id AgentPlatformAgent#user_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserId
        {
            get;
            set;
        }

        /// <summary>Identifier for the workspace.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/resources/agent_platform_agent#workspace_uuid AgentPlatformAgent#workspace_uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workspaceUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WorkspaceUuid
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
