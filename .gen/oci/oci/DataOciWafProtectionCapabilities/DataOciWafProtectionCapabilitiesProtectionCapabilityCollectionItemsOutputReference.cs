using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciWafProtectionCapabilities
{
    [JsiiClass(nativeType: typeof(oci.DataOciWafProtectionCapabilities.DataOciWafProtectionCapabilitiesProtectionCapabilityCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciWafProtectionCapabilities.DataOciWafProtectionCapabilitiesProtectionCapabilityCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciWafProtectionCapabilitiesProtectionCapabilityCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciWafProtectionCapabilitiesProtectionCapabilityCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciWafProtectionCapabilitiesProtectionCapabilityCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciWafProtectionCapabilitiesProtectionCapabilityCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "collaborativeActionThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CollaborativeActionThreshold
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "collaborativeWeights", typeJson: "{\"fqn\":\"oci.dataOciWafProtectionCapabilities.DataOciWafProtectionCapabilitiesProtectionCapabilityCollectionItemsCollaborativeWeightsList\"}")]
        public virtual oci.DataOciWafProtectionCapabilities.DataOciWafProtectionCapabilitiesProtectionCapabilityCollectionItemsCollaborativeWeightsList CollaborativeWeights
        {
            get => GetInstanceProperty<oci.DataOciWafProtectionCapabilities.DataOciWafProtectionCapabilitiesProtectionCapabilityCollectionItemsCollaborativeWeightsList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "groupTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GroupTags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "isLatestVersion", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLatestVersion
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Version
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciWafProtectionCapabilities.DataOciWafProtectionCapabilitiesProtectionCapabilityCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciWafProtectionCapabilities.IDataOciWafProtectionCapabilitiesProtectionCapabilityCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciWafProtectionCapabilities.IDataOciWafProtectionCapabilitiesProtectionCapabilityCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
