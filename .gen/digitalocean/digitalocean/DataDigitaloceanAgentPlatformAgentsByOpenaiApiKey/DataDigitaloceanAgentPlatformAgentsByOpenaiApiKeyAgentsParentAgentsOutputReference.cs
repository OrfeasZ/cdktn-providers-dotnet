using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "anthropicApiKey", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsAnthropicApiKeyList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsAnthropicApiKeyList AnthropicApiKey
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsAnthropicApiKeyList>()!;
        }

        [JsiiProperty(name: "apiKeyInfos", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsApiKeyInfosList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsApiKeyInfosList ApiKeyInfos
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsApiKeyInfosList>()!;
        }

        [JsiiProperty(name: "apiKeys", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsApiKeysList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsApiKeysList ApiKeys
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsApiKeysList>()!;
        }

        [JsiiProperty(name: "chatbot", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsChatbotList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsChatbotList Chatbot
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsChatbotList>()!;
        }

        [JsiiProperty(name: "chatbotIdentifiers", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsChatbotIdentifiersList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsChatbotIdentifiersList ChatbotIdentifiers
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsChatbotIdentifiersList>()!;
        }

        [JsiiProperty(name: "deployment", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsDeploymentList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsDeploymentList Deployment
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgentsDeploymentList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgents\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.IDataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgents? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgentsByOpenaiApiKey.IDataDigitaloceanAgentPlatformAgentsByOpenaiApiKeyAgentsParentAgents?>();
            set => SetInstanceProperty(value);
        }
    }
}
