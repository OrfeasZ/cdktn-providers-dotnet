using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiAgents
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsModelOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsModelOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanGradientaiAgentsAgentsModelOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanGradientaiAgentsAgentsModelOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanGradientaiAgentsAgentsModelOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanGradientaiAgentsAgentsModelOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agreement", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsModelAgreementList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsModelAgreementList Agreement
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsModelAgreementList>()!;
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

        [JsiiProperty(name: "versions", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsModelVersionsList\"}")]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsModelVersionsList Versions
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsModelVersionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanGradientaiAgents.DataDigitaloceanGradientaiAgentsAgentsModel\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanGradientaiAgents.IDataDigitaloceanGradientaiAgentsAgentsModel? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanGradientaiAgents.IDataDigitaloceanGradientaiAgentsAgentsModel?>();
            set => SetInstanceProperty(value);
        }
    }
}
