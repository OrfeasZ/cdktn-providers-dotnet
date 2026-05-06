using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseAutonomousDatabaseBackups
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseAutonomousDatabaseBackups.DataOciDatabaseAutonomousDatabaseBackupsAutonomousDatabaseBackupsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseAutonomousDatabaseBackups.DataOciDatabaseAutonomousDatabaseBackupsAutonomousDatabaseBackupsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseAutonomousDatabaseBackupsAutonomousDatabaseBackupsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseAutonomousDatabaseBackupsAutonomousDatabaseBackupsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseAutonomousDatabaseBackupsAutonomousDatabaseBackupsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseAutonomousDatabaseBackupsAutonomousDatabaseBackupsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "autonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupDestinationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabaseBackups.DataOciDatabaseAutonomousDatabaseBackupsAutonomousDatabaseBackupsBackupDestinationDetailsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabaseBackups.DataOciDatabaseAutonomousDatabaseBackupsAutonomousDatabaseBackupsBackupDestinationDetailsList BackupDestinationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabaseBackups.DataOciDatabaseAutonomousDatabaseBackupsAutonomousDatabaseBackupsBackupDestinationDetailsList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DatabaseSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "infrastructureType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InfrastructureType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAutomatic", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutomatic
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isLongTermBackup", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLongTermBackup
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRestorable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRestorable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "keyStoreId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyStoreId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyStoreWalletName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyStoreWalletName
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "retentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetentionPeriodInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sourceDatabaseDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabaseBackups.DataOciDatabaseAutonomousDatabaseBackupsAutonomousDatabaseBackupsSourceDatabaseDetailsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabaseBackups.DataOciDatabaseAutonomousDatabaseBackupsAutonomousDatabaseBackupsSourceDatabaseDetailsList SourceDatabaseDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabaseBackups.DataOciDatabaseAutonomousDatabaseBackupsAutonomousDatabaseBackupsSourceDatabaseDetailsList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeAvailableTill", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAvailableTill
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabaseBackups.DataOciDatabaseAutonomousDatabaseBackupsAutonomousDatabaseBackups\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseAutonomousDatabaseBackups.IDataOciDatabaseAutonomousDatabaseBackupsAutonomousDatabaseBackups? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabaseBackups.IDataOciDatabaseAutonomousDatabaseBackupsAutonomousDatabaseBackups?>();
            set => SetInstanceProperty(value);
        }
    }
}
