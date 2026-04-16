using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentGuardrail", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsAgentGuardrailList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsAgentGuardrailList AgentGuardrail
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsAgentGuardrailList>()!;
        }

        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "anthropicApiKey", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsAnthropicApiKeyList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsAnthropicApiKeyList AnthropicApiKey
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsAnthropicApiKeyList>()!;
        }

        [JsiiProperty(name: "apiKeyInfos", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsApiKeyInfosList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsApiKeyInfosList ApiKeyInfos
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsApiKeyInfosList>()!;
        }

        [JsiiProperty(name: "apiKeys", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsApiKeysList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsApiKeysList ApiKeys
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsApiKeysList>()!;
        }

        [JsiiProperty(name: "chatbot", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsChatbotList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsChatbotList Chatbot
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsChatbotList>()!;
        }

        [JsiiProperty(name: "chatbotIdentifiers", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsChatbotIdentifiersList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsChatbotIdentifiersList ChatbotIdentifiers
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsChatbotIdentifiersList>()!;
        }

        [JsiiProperty(name: "childAgents", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsChildAgentsList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsChildAgentsList ChildAgents
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsChildAgentsList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployment", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsDeploymentList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsDeploymentList Deployment
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsDeploymentList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "functions", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsFunctionsList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsFunctionsList Functions
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsFunctionsList>()!;
        }

        [JsiiProperty(name: "ifCase", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IfCase
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Instruction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "k", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double K
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "knowledgeBases", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsKnowledgeBasesList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsKnowledgeBasesList KnowledgeBases
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsKnowledgeBasesList>()!;
        }

        [JsiiProperty(name: "maxTokens", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTokens
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsModelList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsModelList Model
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsModelList>()!;
        }

        [JsiiProperty(name: "modelUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelUuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "openAiApiKey", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsOpenAiApiKeyList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsOpenAiApiKeyList OpenAiApiKey
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsOpenAiApiKeyList>()!;
        }

        [JsiiProperty(name: "parentAgents", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsList ParentAgents
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsList>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "retrievalMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RetrievalMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routeCreatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RouteCreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routeCreatedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RouteCreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RouteName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routeUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RouteUuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "temperature", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Temperature
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsTemplateList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsTemplateList Template
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsTemplateList>()!;
        }

        [JsiiProperty(name: "topP", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TopP
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgents\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.IDataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgents? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.IDataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgents?>();
            set => SetInstanceProperty(value);
        }
    }
}
