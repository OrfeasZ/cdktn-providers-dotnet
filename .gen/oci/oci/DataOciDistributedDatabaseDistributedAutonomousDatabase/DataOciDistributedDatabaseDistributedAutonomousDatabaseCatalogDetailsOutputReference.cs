using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDistributedDatabaseDistributedAutonomousDatabase
{
    [JsiiClass(nativeType: typeof(oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOutputReference), fullyQualifiedName: "oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudAutonomousVmClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ComputeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "containerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isAutoScalingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoScalingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsMetadataList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsMetadataList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "okvEndPointGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OkvEndPointGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "okvKeyStoreId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OkvKeyStoreId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerCloudAutonomousVmClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PeerCloudAutonomousVmClusterIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "peerDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsPeerDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsPeerDetailsList PeerDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsPeerDetailsList>()!;
        }

        [JsiiProperty(name: "shardGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShardGroup
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseCatalogDetails\"}", isOptional: true)]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.IDataOciDistributedDatabaseDistributedAutonomousDatabaseCatalogDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.IDataOciDistributedDatabaseDistributedAutonomousDatabaseCatalogDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
