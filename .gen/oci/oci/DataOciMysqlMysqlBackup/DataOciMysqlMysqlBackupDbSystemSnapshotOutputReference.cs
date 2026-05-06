using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMysqlMysqlBackup
{
    [JsiiClass(nativeType: typeof(oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotOutputReference), fullyQualifiedName: "oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMysqlMysqlBackupDbSystemSnapshotOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMysqlMysqlBackupDbSystemSnapshotOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMysqlMysqlBackupDbSystemSnapshotOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMysqlMysqlBackupDbSystemSnapshotOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminUsername
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupPolicy", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotBackupPolicyList\"}")]
        public virtual oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotBackupPolicyList BackupPolicy
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotBackupPolicyList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "crashRecovery", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CrashRecovery
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseManagement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseManagement
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataStorage", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotDataStorageList\"}")]
        public virtual oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotDataStorageList DataStorage
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotDataStorageList>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deletionPolicy", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotDeletionPolicyList\"}")]
        public virtual oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotDeletionPolicyList DeletionPolicy
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotDeletionPolicyList>()!;
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

        [JsiiProperty(name: "encryptData", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotEncryptDataList\"}")]
        public virtual oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotEncryptDataList EncryptData
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotEncryptDataList>()!;
        }

        [JsiiProperty(name: "endpoints", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotEndpointsList\"}")]
        public virtual oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotEndpointsList Endpoints
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotEndpointsList>()!;
        }

        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FaultDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "hostnameLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostnameLabel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isHighlyAvailable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHighlyAvailable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "maintenance", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotMaintenanceList\"}")]
        public virtual oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotMaintenanceList Maintenance
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotMaintenanceList>()!;
        }

        [JsiiProperty(name: "mysqlVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MysqlVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "portX", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PortX
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "readEndpoint", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotReadEndpointList\"}")]
        public virtual oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotReadEndpointList ReadEndpoint
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotReadEndpointList>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rest", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotRestList\"}")]
        public virtual oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotRestList Rest
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotRestList>()!;
        }

        [JsiiProperty(name: "secureConnections", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotSecureConnectionsList\"}")]
        public virtual oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotSecureConnectionsList SecureConnections
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshotSecureConnectionsList>()!;
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SecurityAttributes
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShapeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupDbSystemSnapshot\"}", isOptional: true)]
        public virtual oci.DataOciMysqlMysqlBackup.IDataOciMysqlMysqlBackupDbSystemSnapshot? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.IDataOciMysqlMysqlBackupDbSystemSnapshot?>();
            set => SetInstanceProperty(value);
        }
    }
}
