using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformAgents
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanAgentPlatformAgentsAgentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanAgentPlatformAgentsAgentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanAgentPlatformAgentsAgentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanAgentPlatformAgentsAgentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentGuardrail", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsAgentGuardrailList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsAgentGuardrailList AgentGuardrail
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsAgentGuardrailList>()!;
        }

        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "anthropicApiKey", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsAnthropicApiKeyList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsAnthropicApiKeyList AnthropicApiKey
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsAnthropicApiKeyList>()!;
        }

        [JsiiProperty(name: "apiKeyInfos", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsApiKeyInfosList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsApiKeyInfosList ApiKeyInfos
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsApiKeyInfosList>()!;
        }

        [JsiiProperty(name: "apiKeys", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsApiKeysList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsApiKeysList ApiKeys
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsApiKeysList>()!;
        }

        [JsiiProperty(name: "chatbot", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsChatbotList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsChatbotList Chatbot
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsChatbotList>()!;
        }

        [JsiiProperty(name: "chatbotIdentifiers", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsChatbotIdentifiersList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsChatbotIdentifiersList ChatbotIdentifiers
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsChatbotIdentifiersList>()!;
        }

        [JsiiProperty(name: "childAgents", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsChildAgentsList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsChildAgentsList ChildAgents
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsChildAgentsList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployment", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsDeploymentList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsDeploymentList Deployment
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsDeploymentList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "functions", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsFunctionsList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsFunctionsList Functions
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsFunctionsList>()!;
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

        [JsiiProperty(name: "knowledgeBases", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsKnowledgeBasesList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsKnowledgeBasesList KnowledgeBases
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsKnowledgeBasesList>()!;
        }

        [JsiiProperty(name: "maxTokens", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTokens
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsModelList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsModelList Model
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsModelList>()!;
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

        [JsiiProperty(name: "openAiApiKey", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsOpenAiApiKeyList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsOpenAiApiKeyList OpenAiApiKey
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsOpenAiApiKeyList>()!;
        }

        [JsiiProperty(name: "parentAgents", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsList ParentAgents
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsList>()!;
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

        [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsTemplateList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsTemplateList Template
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsTemplateList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgents\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.IDataDigitaloceanAgentPlatformAgentsAgents? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.IDataDigitaloceanAgentPlatformAgentsAgents?>();
            set => SetInstanceProperty(value);
        }
    }
}
