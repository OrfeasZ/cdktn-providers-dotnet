using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFunctionsPbfListingVersions
{
    [JsiiClass(nativeType: typeof(oci.DataOciFunctionsPbfListingVersions.DataOciFunctionsPbfListingVersionsPbfListingVersionsCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciFunctionsPbfListingVersions.DataOciFunctionsPbfListingVersionsPbfListingVersionsCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFunctionsPbfListingVersionsPbfListingVersionsCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFunctionsPbfListingVersionsPbfListingVersionsCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFunctionsPbfListingVersionsPbfListingVersionsCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFunctionsPbfListingVersionsPbfListingVersionsCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "changeSummary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChangeSummary
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"oci.dataOciFunctionsPbfListingVersions.DataOciFunctionsPbfListingVersionsPbfListingVersionsCollectionItemsConfigList\"}")]
        public virtual oci.DataOciFunctionsPbfListingVersions.DataOciFunctionsPbfListingVersionsPbfListingVersionsCollectionItemsConfigList Config
        {
            get => GetInstanceProperty<oci.DataOciFunctionsPbfListingVersions.DataOciFunctionsPbfListingVersionsPbfListingVersionsCollectionItemsConfigList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pbfListingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PbfListingId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requirements", typeJson: "{\"fqn\":\"oci.dataOciFunctionsPbfListingVersions.DataOciFunctionsPbfListingVersionsPbfListingVersionsCollectionItemsRequirementsList\"}")]
        public virtual oci.DataOciFunctionsPbfListingVersions.DataOciFunctionsPbfListingVersionsPbfListingVersionsCollectionItemsRequirementsList Requirements
        {
            get => GetInstanceProperty<oci.DataOciFunctionsPbfListingVersions.DataOciFunctionsPbfListingVersionsPbfListingVersionsCollectionItemsRequirementsList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "triggers", typeJson: "{\"fqn\":\"oci.dataOciFunctionsPbfListingVersions.DataOciFunctionsPbfListingVersionsPbfListingVersionsCollectionItemsTriggersList\"}")]
        public virtual oci.DataOciFunctionsPbfListingVersions.DataOciFunctionsPbfListingVersionsPbfListingVersionsCollectionItemsTriggersList Triggers
        {
            get => GetInstanceProperty<oci.DataOciFunctionsPbfListingVersions.DataOciFunctionsPbfListingVersionsPbfListingVersionsCollectionItemsTriggersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFunctionsPbfListingVersions.DataOciFunctionsPbfListingVersionsPbfListingVersionsCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciFunctionsPbfListingVersions.IDataOciFunctionsPbfListingVersionsPbfListingVersionsCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFunctionsPbfListingVersions.IDataOciFunctionsPbfListingVersionsPbfListingVersionsCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
