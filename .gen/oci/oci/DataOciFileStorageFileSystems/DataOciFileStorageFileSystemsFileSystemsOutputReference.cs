using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFileStorageFileSystems
{
    [JsiiClass(nativeType: typeof(oci.DataOciFileStorageFileSystems.DataOciFileStorageFileSystemsFileSystemsOutputReference), fullyQualifiedName: "oci.dataOciFileStorageFileSystems.DataOciFileStorageFileSystemsFileSystemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFileStorageFileSystemsFileSystemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFileStorageFileSystemsFileSystemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFileStorageFileSystemsFileSystemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFileStorageFileSystemsFileSystemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "areQuotaRulesEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AreQuotaRulesEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloneAttachStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloneAttachStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloneCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CloneCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "detachCloneTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DetachCloneTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "filesystemSnapshotPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FilesystemSnapshotPolicyId
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

        [JsiiProperty(name: "isCloneParent", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCloneParent
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHydrated", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHydrated
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isLockOverride", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLockOverride
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isTargetable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsTargetable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locks", typeJson: "{\"fqn\":\"oci.dataOciFileStorageFileSystems.DataOciFileStorageFileSystemsFileSystemsLocksList\"}")]
        public virtual oci.DataOciFileStorageFileSystems.DataOciFileStorageFileSystemsFileSystemsLocksList Locks
        {
            get => GetInstanceProperty<oci.DataOciFileStorageFileSystems.DataOciFileStorageFileSystemsFileSystemsLocksList>()!;
        }

        [JsiiProperty(name: "meteredBytes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MeteredBytes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "quotaEnforcementState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QuotaEnforcementState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicationSourceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicationSourceCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "replicationTargetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationTargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.dataOciFileStorageFileSystems.DataOciFileStorageFileSystemsFileSystemsSourceDetailsList\"}")]
        public virtual oci.DataOciFileStorageFileSystems.DataOciFileStorageFileSystemsFileSystemsSourceDetailsList SourceDetails
        {
            get => GetInstanceProperty<oci.DataOciFileStorageFileSystems.DataOciFileStorageFileSystemsFileSystemsSourceDetailsList>()!;
        }

        [JsiiProperty(name: "sourceSnapshotId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceSnapshotId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFileStorageFileSystems.DataOciFileStorageFileSystemsFileSystems\"}", isOptional: true)]
        public virtual oci.DataOciFileStorageFileSystems.IDataOciFileStorageFileSystemsFileSystems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFileStorageFileSystems.IDataOciFileStorageFileSystemsFileSystems?>();
            set => SetInstanceProperty(value);
        }
    }
}
