using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformAgent
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanAgentPlatformAgentParentAgentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanAgentPlatformAgentParentAgentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanAgentPlatformAgentParentAgentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanAgentPlatformAgentParentAgentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "anthropicApiKey", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsAnthropicApiKeyList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsAnthropicApiKeyList AnthropicApiKey
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsAnthropicApiKeyList>()!;
        }

        [JsiiProperty(name: "apiKeyInfos", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsApiKeyInfosList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsApiKeyInfosList ApiKeyInfos
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsApiKeyInfosList>()!;
        }

        [JsiiProperty(name: "apiKeys", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsApiKeysList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsApiKeysList ApiKeys
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsApiKeysList>()!;
        }

        [JsiiProperty(name: "chatbot", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsChatbotList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsChatbotList Chatbot
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsChatbotList>()!;
        }

        [JsiiProperty(name: "chatbotIdentifiers", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsChatbotIdentifiersList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsChatbotIdentifiersList ChatbotIdentifiers
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsChatbotIdentifiersList>()!;
        }

        [JsiiProperty(name: "deployment", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsDeploymentList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsDeploymentList Deployment
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgentsDeploymentList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgent.DataDigitaloceanAgentPlatformAgentParentAgents\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgent.IDataDigitaloceanAgentPlatformAgentParentAgents? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgent.IDataDigitaloceanAgentPlatformAgentParentAgents?>();
            set => SetInstanceProperty(value);
        }
    }
}
