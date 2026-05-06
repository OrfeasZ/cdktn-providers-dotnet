using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseDatabase
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseDatabase.DataOciDatabaseDatabaseDatabaseOutputReference), fullyQualifiedName: "oci.dataOciDatabaseDatabase.DataOciDatabaseDatabaseDatabaseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseDatabaseDatabaseOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseDatabaseDatabaseOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseDatabaseDatabaseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseDatabaseDatabaseOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupTdePassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupTdePassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CharacterSet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseAdminPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseSoftwareImageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseSoftwareImageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbBackupConfig", typeJson: "{\"fqn\":\"oci.dataOciDatabaseDatabase.DataOciDatabaseDatabaseDatabaseDbBackupConfigList\"}")]
        public virtual oci.DataOciDatabaseDatabase.DataOciDatabaseDatabaseDatabaseDbBackupConfigList DbBackupConfig
        {
            get => GetInstanceProperty<oci.DataOciDatabaseDatabase.DataOciDatabaseDatabaseDatabaseDbBackupConfigList>()!;
        }

        [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbUniqueName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbUniqueName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbWorkload
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "encryptionKeyLocationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseDatabase.DataOciDatabaseDatabaseDatabaseEncryptionKeyLocationDetailsList\"}")]
        public virtual oci.DataOciDatabaseDatabase.DataOciDatabaseDatabaseDatabaseEncryptionKeyLocationDetailsList EncryptionKeyLocationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseDatabase.DataOciDatabaseDatabaseDatabaseEncryptionKeyLocationDetailsList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "isActiveDataGuardEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsActiveDataGuardEnabled
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

        [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NcharacterSet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pdbName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PdbName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pluggableDatabases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PluggableDatabases
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtectionMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sidPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SidPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceEncryptionKeyLocationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseDatabase.DataOciDatabaseDatabaseDatabaseSourceEncryptionKeyLocationDetailsList\"}")]
        public virtual oci.DataOciDatabaseDatabase.DataOciDatabaseDatabaseDatabaseSourceEncryptionKeyLocationDetailsList SourceEncryptionKeyLocationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseDatabase.DataOciDatabaseDatabaseDatabaseSourceEncryptionKeyLocationDetailsList>()!;
        }

        [JsiiProperty(name: "sourceTdeWalletPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceTdeWalletPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageSizeDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseDatabase.DataOciDatabaseDatabaseDatabaseStorageSizeDetailsList\"}")]
        public virtual oci.DataOciDatabaseDatabase.DataOciDatabaseDatabaseDatabaseStorageSizeDetailsList StorageSizeDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseDatabase.DataOciDatabaseDatabaseDatabaseStorageSizeDetailsList>()!;
        }

        [JsiiProperty(name: "tdeWalletPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TdeWalletPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transportType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransportType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseDatabase.DataOciDatabaseDatabaseDatabase\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseDatabase.IDataOciDatabaseDatabaseDatabase? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseDatabase.IDataOciDatabaseDatabaseDatabase?>();
            set => SetInstanceProperty(value);
        }
    }
}
