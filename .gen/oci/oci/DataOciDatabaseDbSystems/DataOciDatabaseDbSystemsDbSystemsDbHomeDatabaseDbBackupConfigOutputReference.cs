using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseDbSystems
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseDbSystems.DataOciDatabaseDbSystemsDbSystemsDbHomeDatabaseDbBackupConfigOutputReference), fullyQualifiedName: "oci.dataOciDatabaseDbSystems.DataOciDatabaseDbSystemsDbSystemsDbHomeDatabaseDbBackupConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseDbSystemsDbSystemsDbHomeDatabaseDbBackupConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseDbSystemsDbSystemsDbHomeDatabaseDbBackupConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseDbSystemsDbSystemsDbHomeDatabaseDbBackupConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseDbSystemsDbSystemsDbHomeDatabaseDbBackupConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "autoBackupEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AutoBackupEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "autoBackupWindow", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoBackupWindow
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoFullBackupDay", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoFullBackupDay
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoFullBackupWindow", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoFullBackupWindow
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupDeletionPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupDeletionPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupDestinationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseDbSystems.DataOciDatabaseDbSystemsDbSystemsDbHomeDatabaseDbBackupConfigBackupDestinationDetailsList\"}")]
        public virtual oci.DataOciDatabaseDbSystems.DataOciDatabaseDbSystemsDbSystemsDbHomeDatabaseDbBackupConfigBackupDestinationDetailsList BackupDestinationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseDbSystems.DataOciDatabaseDbSystemsDbSystemsDbHomeDatabaseDbBackupConfigBackupDestinationDetailsList>()!;
        }

        [JsiiProperty(name: "recoveryWindowInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecoveryWindowInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "runImmediateFullBackup", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RunImmediateFullBackup
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseDbSystems.DataOciDatabaseDbSystemsDbSystemsDbHomeDatabaseDbBackupConfig\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseDbSystems.IDataOciDatabaseDbSystemsDbSystemsDbHomeDatabaseDbBackupConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseDbSystems.IDataOciDatabaseDbSystemsDbSystemsDbHomeDatabaseDbBackupConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
