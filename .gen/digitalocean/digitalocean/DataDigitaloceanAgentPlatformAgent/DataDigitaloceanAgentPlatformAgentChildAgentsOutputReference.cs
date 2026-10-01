using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformAgent
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanAgentPlatformAgentChildAgentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanAgentPlatformAgentChildAgentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanAgentPlatformAgentChildAgentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanAgentPlatformAgentChildAgentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "anthropicApiKey", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsAnthropicApiKeyList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsAnthropicApiKeyList AnthropicApiKey
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsAnthropicApiKeyList>()!;
        }

        [JsiiProperty(name: "apiKeyInfos", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsApiKeyInfosList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsApiKeyInfosList ApiKeyInfos
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsApiKeyInfosList>()!;
        }

        [JsiiProperty(name: "apiKeys", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsApiKeysList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsApiKeysList ApiKeys
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsApiKeysList>()!;
        }

        [JsiiProperty(name: "chatbot", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsChatbotList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsChatbotList Chatbot
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsChatbotList>()!;
        }

        [JsiiProperty(name: "chatbotIdentifiers", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsChatbotIdentifiersList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsChatbotIdentifiersList ChatbotIdentifiers
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsChatbotIdentifiersList>()!;
        }

        [JsiiProperty(name: "deployment", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsDeploymentList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsDeploymentList Deployment
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgentsDeploymentList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Instruction
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentChildAgents\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgent.IDataDigitaloceanAgentPlatformAgentChildAgents? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgent.IDataDigitaloceanAgentPlatformAgentChildAgents?>();
            set => SetInstanceProperty(value);
        }
    }
}
