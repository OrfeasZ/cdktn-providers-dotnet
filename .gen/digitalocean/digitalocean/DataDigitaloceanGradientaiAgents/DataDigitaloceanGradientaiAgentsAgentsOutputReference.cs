using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiAgents
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanGradientaiAgentsAgentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanGradientaiAgentsAgentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanGradientaiAgentsAgentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanGradientaiAgentsAgentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentGuardrail", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsAgentGuardrailList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsAgentGuardrailList AgentGuardrail
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsAgentGuardrailList>()!;
        }

        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "anthropicApiKey", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsAnthropicApiKeyList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsAnthropicApiKeyList AnthropicApiKey
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsAnthropicApiKeyList>()!;
        }

        [JsiiProperty(name: "apiKeyInfos", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsApiKeyInfosList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsApiKeyInfosList ApiKeyInfos
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsApiKeyInfosList>()!;
        }

        [JsiiProperty(name: "apiKeys", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsApiKeysList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsApiKeysList ApiKeys
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsApiKeysList>()!;
        }

        [JsiiProperty(name: "chatbot", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChatbotList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChatbotList Chatbot
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChatbotList>()!;
        }

        [JsiiProperty(name: "chatbotIdentifiers", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChatbotIdentifiersList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChatbotIdentifiersList ChatbotIdentifiers
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChatbotIdentifiersList>()!;
        }

        [JsiiProperty(name: "childAgents", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsList ChildAgents
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployment", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsDeploymentList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsDeploymentList Deployment
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsDeploymentList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "functions", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsFunctionsList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsFunctionsList Functions
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsFunctionsList>()!;
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

        [JsiiProperty(name: "knowledgeBases", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsKnowledgeBasesList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsKnowledgeBasesList KnowledgeBases
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsKnowledgeBasesList>()!;
        }

        [JsiiProperty(name: "maxTokens", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTokens
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsModelList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsModelList Model
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsModelList>()!;
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

        [JsiiProperty(name: "openAiApiKey", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsOpenAiApiKeyList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsOpenAiApiKeyList OpenAiApiKey
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsOpenAiApiKeyList>()!;
        }

        [JsiiProperty(name: "parentAgents", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsParentAgentsList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsParentAgentsList ParentAgents
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsParentAgentsList>()!;
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

        [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsTemplateList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsTemplateList Template
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsTemplateList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgents\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.IDataDigitaloceanGradientaiAgentsAgents? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.IDataDigitaloceanGradientaiAgentsAgents?>();
            set => SetInstanceProperty(value);
        }
    }
}
