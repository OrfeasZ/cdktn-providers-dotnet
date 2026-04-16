using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiAgent
{
    [JsiiInterface(nativeType: typeof(IGradientaiAgentConfig), fullyQualifiedName: "digitalocean.gradientaiAgent.GradientaiAgentConfig")]
    public interface IGradientaiAgentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Instruction for the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#instruction GradientaiAgent#instruction}
        /// </remarks>
        [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}")]
        string Instruction
        {
            get;
        }

        /// <summary>Model UUID of the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#model_uuid GradientaiAgent#model_uuid}
        /// </remarks>
        [JsiiProperty(name: "modelUuid", typeJson: "{\"primitive\":\"string\"}")]
        string ModelUuid
        {
            get;
        }

        /// <summary>Name of the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#name GradientaiAgent#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Project ID of the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#project_id GradientaiAgent#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectId
        {
            get;
        }

        /// <summary>Region where the Agent is deployed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#region GradientaiAgent#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        /// <summary>agent_guardrail block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#agent_guardrail GradientaiAgent#agent_guardrail}
        /// </remarks>
        [JsiiProperty(name: "agentGuardrail", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentAgentGuardrail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AgentGuardrail
        {
            get
            {
                return null;
            }
        }

        /// <summary>anthropic_api_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#anthropic_api_key GradientaiAgent#anthropic_api_key}
        /// </remarks>
        [JsiiProperty(name: "anthropicApiKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentAnthropicApiKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AnthropicApiKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Optional Anthropic API key ID to use with Anthropic models.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#anthropic_key_uuid GradientaiAgent#anthropic_key_uuid}
        /// </remarks>
        [JsiiProperty(name: "anthropicKeyUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AnthropicKeyUuid
        {
            get
            {
                return null;
            }
        }

        /// <summary>api_key_infos block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#api_key_infos GradientaiAgent#api_key_infos}
        /// </remarks>
        [JsiiProperty(name: "apiKeyInfos", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentApiKeyInfos\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#api_keys GradientaiAgent#api_keys}
        /// </remarks>
        [JsiiProperty(name: "apiKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentApiKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#chatbot GradientaiAgent#chatbot}
        /// </remarks>
        [JsiiProperty(name: "chatbot", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentChatbot\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#chatbot_identifiers GradientaiAgent#chatbot_identifiers}
        /// </remarks>
        [JsiiProperty(name: "chatbotIdentifiers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentChatbotIdentifiers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ChatbotIdentifiers
        {
            get
            {
                return null;
            }
        }

        /// <summary>child_agents block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#child_agents GradientaiAgent#child_agents}
        /// </remarks>
        [JsiiProperty(name: "childAgents", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentChildAgents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ChildAgents
        {
            get
            {
                return null;
            }
        }

        /// <summary>Timestamp when the Agent was created.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#created_at GradientaiAgent#created_at}
        /// </remarks>
        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreatedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>deployment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#deployment GradientaiAgent#deployment}
        /// </remarks>
        [JsiiProperty(name: "deployment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentDeployment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#description GradientaiAgent#description}
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

        /// <summary>functions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#functions GradientaiAgent#functions}
        /// </remarks>
        [JsiiProperty(name: "functions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentFunctions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Functions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#id GradientaiAgent#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>If case condition.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#if_case GradientaiAgent#if_case}
        /// </remarks>
        [JsiiProperty(name: "ifCase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IfCase
        {
            get
            {
                return null;
            }
        }

        /// <summary>K value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#k GradientaiAgent#k}
        /// </remarks>
        [JsiiProperty(name: "k", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? K
        {
            get
            {
                return null;
            }
        }

        /// <summary>knowledge_bases block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#knowledge_bases GradientaiAgent#knowledge_bases}
        /// </remarks>
        [JsiiProperty(name: "knowledgeBases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentKnowledgeBases\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KnowledgeBases
        {
            get
            {
                return null;
            }
        }

        /// <summary>Ids of the knowledge base(s) to attach to the agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#knowledge_base_uuid GradientaiAgent#knowledge_base_uuid}
        /// </remarks>
        [JsiiProperty(name: "knowledgeBaseUuid", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? KnowledgeBaseUuid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum tokens allowed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#max_tokens GradientaiAgent#max_tokens}
        /// </remarks>
        [JsiiProperty(name: "maxTokens", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxTokens
        {
            get
            {
                return null;
            }
        }

        /// <summary>model block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#model GradientaiAgent#model}
        /// </remarks>
        [JsiiProperty(name: "model", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentModel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Model
        {
            get
            {
                return null;
            }
        }

        /// <summary>open_ai_api_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#open_ai_api_key GradientaiAgent#open_ai_api_key}
        /// </remarks>
        [JsiiProperty(name: "openAiApiKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentOpenAiApiKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OpenAiApiKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Optional OpenAI API key ID to use with OpenAI models.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#open_ai_key_uuid GradientaiAgent#open_ai_key_uuid}
        /// </remarks>
        [JsiiProperty(name: "openAiKeyUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OpenAiKeyUuid
        {
            get
            {
                return null;
            }
        }

        /// <summary>parent_agents block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#parent_agents GradientaiAgent#parent_agents}
        /// </remarks>
        [JsiiProperty(name: "parentAgents", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentParentAgents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ParentAgents
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates if the agent should provide citations in responses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#provide_citations GradientaiAgent#provide_citations}
        /// </remarks>
        [JsiiProperty(name: "provideCitations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProvideCitations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Retrieval method used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#retrieval_method GradientaiAgent#retrieval_method}
        /// </remarks>
        [JsiiProperty(name: "retrievalMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RetrievalMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>User who created the route.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#route_created_by GradientaiAgent#route_created_by}
        /// </remarks>
        [JsiiProperty(name: "routeCreatedBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RouteCreatedBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Route name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#route_name GradientaiAgent#route_name}
        /// </remarks>
        [JsiiProperty(name: "routeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RouteName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Route UUID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#route_uuid GradientaiAgent#route_uuid}
        /// </remarks>
        [JsiiProperty(name: "routeUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RouteUuid
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of Tags.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#tags GradientaiAgent#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Agent temperature setting.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#temperature GradientaiAgent#temperature}
        /// </remarks>
        [JsiiProperty(name: "temperature", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Temperature
        {
            get
            {
                return null;
            }
        }

        /// <summary>template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#template GradientaiAgent#template}
        /// </remarks>
        [JsiiProperty(name: "template", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentTemplate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Template
        {
            get
            {
                return null;
            }
        }

        /// <summary>Top P sampling parameter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#top_p GradientaiAgent#top_p}
        /// </remarks>
        [JsiiProperty(name: "topP", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TopP
        {
            get
            {
                return null;
            }
        }

        /// <summary>URL for the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#url GradientaiAgent#url}
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

        /// <summary>User ID linked with the Agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#user_id GradientaiAgent#user_id}
        /// </remarks>
        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Identifier for the workspace.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#workspace_uuid GradientaiAgent#workspace_uuid}
        /// </remarks>
        [JsiiProperty(name: "workspaceUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkspaceUuid
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGradientaiAgentConfig), fullyQualifiedName: "digitalocean.gradientaiAgent.GradientaiAgentConfig")]
        internal sealed class _Proxy : DeputyBase, digitalocean.GradientaiAgent.IGradientaiAgentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Instruction for the Agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#instruction GradientaiAgent#instruction}
            /// </remarks>
            [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}")]
            public string Instruction
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Model UUID of the Agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#model_uuid GradientaiAgent#model_uuid}
            /// </remarks>
            [JsiiProperty(name: "modelUuid", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelUuid
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name of the Agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#name GradientaiAgent#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Project ID of the Agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#project_id GradientaiAgent#project_id}
            /// </remarks>
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Region where the Agent is deployed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#region GradientaiAgent#region}
            /// </remarks>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>agent_guardrail block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#agent_guardrail GradientaiAgent#agent_guardrail}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "agentGuardrail", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentAgentGuardrail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AgentGuardrail
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>anthropic_api_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#anthropic_api_key GradientaiAgent#anthropic_api_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "anthropicApiKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentAnthropicApiKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AnthropicApiKey
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Optional Anthropic API key ID to use with Anthropic models.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#anthropic_key_uuid GradientaiAgent#anthropic_key_uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "anthropicKeyUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AnthropicKeyUuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>api_key_infos block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#api_key_infos GradientaiAgent#api_key_infos}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiKeyInfos", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentApiKeyInfos\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ApiKeyInfos
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>api_keys block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#api_keys GradientaiAgent#api_keys}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiKeys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentApiKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ApiKeys
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>chatbot block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#chatbot GradientaiAgent#chatbot}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "chatbot", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentChatbot\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Chatbot
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>chatbot_identifiers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#chatbot_identifiers GradientaiAgent#chatbot_identifiers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "chatbotIdentifiers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentChatbotIdentifiers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ChatbotIdentifiers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>child_agents block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#child_agents GradientaiAgent#child_agents}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "childAgents", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentChildAgents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ChildAgents
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Timestamp when the Agent was created.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#created_at GradientaiAgent#created_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreatedAt
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>deployment block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#deployment GradientaiAgent#deployment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deployment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentDeployment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Deployment
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Description for the Agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#description GradientaiAgent#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>functions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#functions GradientaiAgent#functions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "functions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentFunctions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Functions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#id GradientaiAgent#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If case condition.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#if_case GradientaiAgent#if_case}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ifCase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IfCase
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>K value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#k GradientaiAgent#k}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "k", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? K
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>knowledge_bases block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#knowledge_bases GradientaiAgent#knowledge_bases}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "knowledgeBases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentKnowledgeBases\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KnowledgeBases
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Ids of the knowledge base(s) to attach to the agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#knowledge_base_uuid GradientaiAgent#knowledge_base_uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "knowledgeBaseUuid", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? KnowledgeBaseUuid
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Maximum tokens allowed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#max_tokens GradientaiAgent#max_tokens}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxTokens", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxTokens
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>model block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#model GradientaiAgent#model}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "model", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentModel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Model
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>open_ai_api_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#open_ai_api_key GradientaiAgent#open_ai_api_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openAiApiKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentOpenAiApiKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OpenAiApiKey
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Optional OpenAI API key ID to use with OpenAI models.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#open_ai_key_uuid GradientaiAgent#open_ai_key_uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openAiKeyUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OpenAiKeyUuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>parent_agents block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#parent_agents GradientaiAgent#parent_agents}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parentAgents", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentParentAgents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ParentAgents
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Indicates if the agent should provide citations in responses.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#provide_citations GradientaiAgent#provide_citations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provideCitations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ProvideCitations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Retrieval method used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#retrieval_method GradientaiAgent#retrieval_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retrievalMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RetrievalMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>User who created the route.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#route_created_by GradientaiAgent#route_created_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routeCreatedBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RouteCreatedBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Route name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#route_name GradientaiAgent#route_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RouteName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Route UUID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#route_uuid GradientaiAgent#route_uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routeUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RouteUuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>List of Tags.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#tags GradientaiAgent#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Agent temperature setting.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#temperature GradientaiAgent#temperature}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "temperature", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Temperature
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>template block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#template GradientaiAgent#template}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "template", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.gradientaiAgent.GradientaiAgentTemplate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Template
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Top P sampling parameter.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#top_p GradientaiAgent#top_p}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "topP", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TopP
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>URL for the Agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#url GradientaiAgent#url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Url
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>User ID linked with the Agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#user_id GradientaiAgent#user_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Identifier for the workspace.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#workspace_uuid GradientaiAgent#workspace_uuid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workspaceUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkspaceUuid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
