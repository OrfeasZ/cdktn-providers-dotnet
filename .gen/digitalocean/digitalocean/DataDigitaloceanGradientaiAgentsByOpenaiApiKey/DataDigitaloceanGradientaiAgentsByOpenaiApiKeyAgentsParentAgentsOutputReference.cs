using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "anthropicApiKey", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsAnthropicApiKeyList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsAnthropicApiKeyList AnthropicApiKey
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsAnthropicApiKeyList>()!;
        }

        [JsiiProperty(name: "apiKeyInfos", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsApiKeyInfosList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsApiKeyInfosList ApiKeyInfos
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsApiKeyInfosList>()!;
        }

        [JsiiProperty(name: "apiKeys", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsApiKeysList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsApiKeysList ApiKeys
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsApiKeysList>()!;
        }

        [JsiiProperty(name: "chatbot", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsChatbotList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsChatbotList Chatbot
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsChatbotList>()!;
        }

        [JsiiProperty(name: "chatbotIdentifiers", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsChatbotIdentifiersList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsChatbotIdentifiersList ChatbotIdentifiers
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsChatbotIdentifiersList>()!;
        }

        [JsiiProperty(name: "deployment", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsDeploymentList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsDeploymentList Deployment
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgentsDeploymentList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgents\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.IDataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgents? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.IDataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsParentAgents?>();
            set => SetInstanceProperty(value);
        }
    }
}
