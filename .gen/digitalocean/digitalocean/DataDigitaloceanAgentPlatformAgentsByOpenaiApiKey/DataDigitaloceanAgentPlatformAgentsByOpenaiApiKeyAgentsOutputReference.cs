using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentGuardrail", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsAgentGuardrailList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsAgentGuardrailList AgentGuardrail
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsAgentGuardrailList>()!;
        }

        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "anthropicApiKey", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsAnthropicApiKeyList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsAnthropicApiKeyList AnthropicApiKey
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsAnthropicApiKeyList>()!;
        }

        [JsiiProperty(name: "apiKeyInfos", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsApiKeyInfosList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsApiKeyInfosList ApiKeyInfos
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsApiKeyInfosList>()!;
        }

        [JsiiProperty(name: "apiKeys", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsApiKeysList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsApiKeysList ApiKeys
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsApiKeysList>()!;
        }

        [JsiiProperty(name: "chatbot", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsChatbotList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsChatbotList Chatbot
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsChatbotList>()!;
        }

        [JsiiProperty(name: "chatbotIdentifiers", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsChatbotIdentifiersList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsChatbotIdentifiersList ChatbotIdentifiers
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsChatbotIdentifiersList>()!;
        }

        [JsiiProperty(name: "childAgents", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsChildAgentsList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsChildAgentsList ChildAgents
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsChildAgentsList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployment", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsDeploymentList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsDeploymentList Deployment
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsDeploymentList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "functions", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsFunctionsList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsFunctionsList Functions
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsFunctionsList>()!;
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

        [JsiiProperty(name: "knowledgeBases", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsKnowledgeBasesList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsKnowledgeBasesList KnowledgeBases
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsKnowledgeBasesList>()!;
        }

        [JsiiProperty(name: "maxTokens", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTokens
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsModelList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsModelList Model
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsModelList>()!;
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

        [JsiiProperty(name: "openAiApiKey", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsOpenAiApiKeyList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsOpenAiApiKeyList OpenAiApiKey
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsOpenAiApiKeyList>()!;
        }

        [JsiiProperty(name: "parentAgents", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsList ParentAgents
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsList>()!;
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

        [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsTemplateList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsTemplateList Template
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsTemplateList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgents\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.IDataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgents? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.IDataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgents?>();
            set => SetInstanceProperty(value);
        }
    }
}
