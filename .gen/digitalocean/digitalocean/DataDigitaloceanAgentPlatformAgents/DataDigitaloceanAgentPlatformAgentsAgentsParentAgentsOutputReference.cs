using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformAgents
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "anthropicApiKey", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsAnthropicApiKeyList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsAnthropicApiKeyList AnthropicApiKey
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsAnthropicApiKeyList>()!;
        }

        [JsiiProperty(name: "apiKeyInfos", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsApiKeyInfosList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsApiKeyInfosList ApiKeyInfos
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsApiKeyInfosList>()!;
        }

        [JsiiProperty(name: "apiKeys", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsApiKeysList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsApiKeysList ApiKeys
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsApiKeysList>()!;
        }

        [JsiiProperty(name: "chatbot", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsChatbotList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsChatbotList Chatbot
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsChatbotList>()!;
        }

        [JsiiProperty(name: "chatbotIdentifiers", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsChatbotIdentifiersList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsChatbotIdentifiersList ChatbotIdentifiers
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsChatbotIdentifiersList>()!;
        }

        [JsiiProperty(name: "deployment", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsDeploymentList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsDeploymentList Deployment
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgentsDeploymentList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsAgentsParentAgents\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanAgentPlatformAgents.IDataDigitaloceanAgentPlatformAgentsAgentsParentAgents? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformAgents.IDataDigitaloceanAgentPlatformAgentsAgentsParentAgents?>();
            set => SetInstanceProperty(value);
        }
    }
}
