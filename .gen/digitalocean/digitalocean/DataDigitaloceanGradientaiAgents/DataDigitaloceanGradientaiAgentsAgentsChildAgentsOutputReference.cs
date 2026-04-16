using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiAgents
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanGradientaiAgentsAgentsChildAgentsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanGradientaiAgentsAgentsChildAgentsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanGradientaiAgentsAgentsChildAgentsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanGradientaiAgentsAgentsChildAgentsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "anthropicApiKey", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsAnthropicApiKeyList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsAnthropicApiKeyList AnthropicApiKey
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsAnthropicApiKeyList>()!;
        }

        [JsiiProperty(name: "apiKeyInfos", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsApiKeyInfosList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsApiKeyInfosList ApiKeyInfos
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsApiKeyInfosList>()!;
        }

        [JsiiProperty(name: "apiKeys", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsApiKeysList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsApiKeysList ApiKeys
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsApiKeysList>()!;
        }

        [JsiiProperty(name: "chatbot", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsChatbotList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsChatbotList Chatbot
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsChatbotList>()!;
        }

        [JsiiProperty(name: "chatbotIdentifiers", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsChatbotIdentifiersList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsChatbotIdentifiersList ChatbotIdentifiers
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsChatbotIdentifiersList>()!;
        }

        [JsiiProperty(name: "deployment", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsDeploymentList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsDeploymentList Deployment
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgentsDeploymentList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsChildAgents\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.IDataDigitaloceanGradientaiAgentsAgentsChildAgents? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.IDataDigitaloceanGradientaiAgentsAgentsChildAgents?>();
            set => SetInstanceProperty(value);
        }
    }
}
