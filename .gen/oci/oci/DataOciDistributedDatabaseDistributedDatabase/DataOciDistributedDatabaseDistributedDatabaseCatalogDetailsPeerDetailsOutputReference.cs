using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDistributedDatabaseDistributedDatabase
{
    [JsiiClass(nativeType: typeof(oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsOutputReference), fullyQualifiedName: "oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsOutputReference(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "dbStorageVaultDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsDbStorageVaultDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsDbStorageVaultDetailsList DbStorageVaultDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsDbStorageVaultDetailsList>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsMetadataList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsMetadataList>()!;
        }

        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtectionMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shardGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShardGroup
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

        [JsiiProperty(name: "transportType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransportType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmClusterDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsVmClusterDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsVmClusterDetailsList VmClusterDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetailsVmClusterDetailsList>()!;
        }

        [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetails\"}", isOptional: true)]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.IDataOciDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.IDataOciDistributedDatabaseDistributedDatabaseCatalogDetailsPeerDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
