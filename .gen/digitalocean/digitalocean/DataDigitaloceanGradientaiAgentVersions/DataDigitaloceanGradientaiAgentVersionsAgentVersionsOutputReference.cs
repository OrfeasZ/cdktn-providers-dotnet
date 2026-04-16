using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiAgentVersions
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanGradientaiAgentVersions.DataDigitaloceanGradientaiAgentVersionsAgentVersionsOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiAgentVersions.DataDigitaloceanGradientaiAgentVersionsAgentVersionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanGradientaiAgentVersionsAgentVersionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanGradientaiAgentVersionsAgentVersionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanGradientaiAgentVersionsAgentVersionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanGradientaiAgentVersionsAgentVersionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentUuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attachedChildAgents", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentVersions.DataDigitaloceanGradientaiAgentVersionsAgentVersionsAttachedChildAgentsList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentVersions.DataDigitaloceanGradientaiAgentVersionsAgentVersionsAttachedChildAgentsList AttachedChildAgents
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentVersions.DataDigitaloceanGradientaiAgentVersionsAgentVersionsAttachedChildAgentsList>()!;
        }

        [JsiiProperty(name: "attachedFunctions", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentVersions.DataDigitaloceanGradientaiAgentVersionsAgentVersionsAttachedFunctionsList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentVersions.DataDigitaloceanGradientaiAgentVersionsAgentVersionsAttachedFunctionsList AttachedFunctions
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentVersions.DataDigitaloceanGradientaiAgentVersionsAgentVersionsAttachedFunctionsList>()!;
        }

        [JsiiProperty(name: "attachedGuardrails", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentVersions.DataDigitaloceanGradientaiAgentVersionsAgentVersionsAttachedGuardrailsList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentVersions.DataDigitaloceanGradientaiAgentVersionsAgentVersionsAttachedGuardrailsList AttachedGuardrails
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentVersions.DataDigitaloceanGradientaiAgentVersionsAgentVersionsAttachedGuardrailsList>()!;
        }

        [JsiiProperty(name: "attachedKnowledgeBases", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentVersions.DataDigitaloceanGradientaiAgentVersionsAgentVersionsAttachedKnowledgeBasesList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentVersions.DataDigitaloceanGradientaiAgentVersionsAgentVersionsAttachedKnowledgeBasesList AttachedKnowledgeBases
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentVersions.DataDigitaloceanGradientaiAgentVersionsAgentVersionsAttachedKnowledgeBasesList>()!;
        }

        [JsiiProperty(name: "canRollback", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CanRollback
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdByEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedByEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentlyApplied", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CurrentlyApplied
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
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

        [JsiiProperty(name: "maxTokens", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTokens
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "modelName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provideCitations", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ProvideCitations
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "retrievalMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RetrievalMethod
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

        [JsiiProperty(name: "topP", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TopP
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "triggerAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TriggerAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versionHash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionHash
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentVersions.DataDigitaloceanGradientaiAgentVersionsAgentVersions\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentVersions.IDataDigitaloceanGradientaiAgentVersionsAgentVersions? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentVersions.IDataDigitaloceanGradientaiAgentVersionsAgentVersions?>();
            set => SetInstanceProperty(value);
        }
    }
}
