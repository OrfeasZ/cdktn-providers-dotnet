using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlBackup
{
    [JsiiClass(nativeType: typeof(oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotOutputReference), fullyQualifiedName: "oci.mysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MysqlMysqlBackupDbSystemSnapshotOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public MysqlMysqlBackupDbSystemSnapshotOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected MysqlMysqlBackupDbSystemSnapshotOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlMysqlBackupDbSystemSnapshotOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "backupPolicy", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotBackupPolicyList\"}")]
        public virtual oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotBackupPolicyList BackupPolicy
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotBackupPolicyList>()!;
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

        [JsiiProperty(name: "dataStorage", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotDataStorageList\"}")]
        public virtual oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotDataStorageList DataStorage
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotDataStorageList>()!;
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

        [JsiiProperty(name: "deletionPolicy", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotDeletionPolicyList\"}")]
        public virtual oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotDeletionPolicyList DeletionPolicy
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotDeletionPolicyList>()!;
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

        [JsiiProperty(name: "encryptData", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotEncryptDataList\"}")]
        public virtual oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotEncryptDataList EncryptData
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotEncryptDataList>()!;
        }

        [JsiiProperty(name: "endpoints", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotEndpointsList\"}")]
        public virtual oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotEndpointsList Endpoints
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotEndpointsList>()!;
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

        [JsiiProperty(name: "maintenance", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotMaintenanceList\"}")]
        public virtual oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotMaintenanceList Maintenance
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotMaintenanceList>()!;
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

        [JsiiProperty(name: "readEndpoint", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotReadEndpointList\"}")]
        public virtual oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotReadEndpointList ReadEndpoint
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotReadEndpointList>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rest", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotRestList\"}")]
        public virtual oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotRestList Rest
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotRestList>()!;
        }

        [JsiiProperty(name: "secureConnections", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotSecureConnectionsList\"}")]
        public virtual oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotSecureConnectionsList SecureConnections
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshotSecureConnectionsList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.mysqlMysqlBackup.MysqlMysqlBackupDbSystemSnapshot\"}", isOptional: true)]
        public virtual oci.MysqlMysqlBackup.IMysqlMysqlBackupDbSystemSnapshot? InternalValue
        {
            get => GetInstanceProperty<oci.MysqlMysqlBackup.IMysqlMysqlBackupDbSystemSnapshot?>();
            set => SetInstanceProperty(value);
        }
    }
}
