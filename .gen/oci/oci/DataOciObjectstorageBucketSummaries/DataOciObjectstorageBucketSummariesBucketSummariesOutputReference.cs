using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciObjectstorageBucketSummaries
{
    [JsiiClass(nativeType: typeof(oci.DataOciObjectstorageBucketSummaries.DataOciObjectstorageBucketSummariesBucketSummariesOutputReference), fullyQualifiedName: "oci.dataOciObjectstorageBucketSummaries.DataOciObjectstorageBucketSummariesBucketSummariesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciObjectstorageBucketSummariesBucketSummariesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciObjectstorageBucketSummariesBucketSummariesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciObjectstorageBucketSummariesBucketSummariesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciObjectstorageBucketSummariesBucketSummariesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "approximateCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApproximateCount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "approximateSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApproximateSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoTiering", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoTiering
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bucketId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Etag
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "isReadOnly", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsReadOnly
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Metadata
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectEventsEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ObjectEventsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "objectLifecyclePolicyEtag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectLifecyclePolicyEtag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicationEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ReplicationEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "retentionRules", typeJson: "{\"fqn\":\"oci.dataOciObjectstorageBucketSummaries.DataOciObjectstorageBucketSummariesBucketSummariesRetentionRulesList\"}")]
        public virtual oci.DataOciObjectstorageBucketSummaries.DataOciObjectstorageBucketSummariesBucketSummariesRetentionRulesList RetentionRules
        {
            get => GetInstanceProperty<oci.DataOciObjectstorageBucketSummaries.DataOciObjectstorageBucketSummariesBucketSummariesRetentionRulesList>()!;
        }

        [JsiiProperty(name: "storageTier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageTier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versioning", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Versioning
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciObjectstorageBucketSummaries.DataOciObjectstorageBucketSummariesBucketSummaries\"}", isOptional: true)]
        public virtual oci.DataOciObjectstorageBucketSummaries.IDataOciObjectstorageBucketSummariesBucketSummaries? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciObjectstorageBucketSummaries.IDataOciObjectstorageBucketSummariesBucketSummaries?>();
            set => SetInstanceProperty(value);
        }
    }
}
