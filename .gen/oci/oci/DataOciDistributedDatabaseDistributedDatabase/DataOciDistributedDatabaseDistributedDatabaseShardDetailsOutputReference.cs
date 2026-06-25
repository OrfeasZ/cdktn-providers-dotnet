using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDistributedDatabaseDistributedDatabase
{
    [JsiiClass(nativeType: typeof(oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseShardDetailsOutputReference), fullyQualifiedName: "oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseShardDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDistributedDatabaseDistributedDatabaseShardDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDistributedDatabaseDistributedDatabaseShardDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDistributedDatabaseDistributedDatabaseShardDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDistributedDatabaseDistributedDatabaseShardDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "containerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbHomeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbHomeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbStorageVaultDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseShardDetailsDbStorageVaultDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseShardDetailsDbStorageVaultDetailsList DbStorageVaultDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseShardDetailsDbStorageVaultDetailsList>()!;
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kmsKeyVersionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyVersionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseShardDetailsMetadataList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseShardDetailsMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseShardDetailsMetadataList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsList PeerDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsList>()!;
        }

        [JsiiProperty(name: "peerVmClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PeerVmClusterIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "shardGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShardGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shardSpace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShardSpace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportingResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SupportingResourceId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmClusterDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseShardDetailsVmClusterDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseShardDetailsVmClusterDetailsList VmClusterDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseShardDetailsVmClusterDetailsList>()!;
        }

        [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseShardDetails\"}", isOptional: true)]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.IDataOciDistributedDatabaseDistributedDatabaseShardDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.IDataOciDistributedDatabaseDistributedDatabaseShardDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
