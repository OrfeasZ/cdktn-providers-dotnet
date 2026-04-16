using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsModelOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsModelOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsModelOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsModelOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsModelOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsModelOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agreement", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsModelAgreementList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsModelAgreementList Agreement
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsModelAgreementList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inferenceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InferenceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inferenceVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InferenceVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isFoundational", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFoundational
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentUuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Provider
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uploadComplete", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UploadComplete
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "usecases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Usecases
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "versions", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsModelVersionsList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsModelVersionsList Versions
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsModelVersionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgentsByOpenaiApiKey.DataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsModel\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.IDataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsModel? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgentsByOpenaiApiKey.IDataDigitaloceanGradientaiAgentsByOpenaiApiKeyAgentsModel?>();
            set => SetInstanceProperty(value);
        }
    }
}
