using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabase
{
    [JsiiClass(nativeType: typeof(oci.DatabaseDatabase.DatabaseDatabaseDatabaseOutputReference), fullyQualifiedName: "oci.databaseDatabase.DatabaseDatabaseDatabaseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseDatabaseDatabaseOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseDatabaseDatabaseOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseDatabaseDatabaseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseDatabaseDatabaseOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDbBackupConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseDatabaseDbBackupConfig\"}}]")]
        public virtual void PutDbBackupConfig(oci.DatabaseDatabase.IDatabaseDatabaseDatabaseDbBackupConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseDatabase.IDatabaseDatabaseDatabaseDbBackupConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEncryptionKeyLocationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseDatabaseEncryptionKeyLocationDetails\"}}]")]
        public virtual void PutEncryptionKeyLocationDetails(oci.DatabaseDatabase.IDatabaseDatabaseDatabaseEncryptionKeyLocationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseDatabase.IDatabaseDatabaseDatabaseEncryptionKeyLocationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceEncryptionKeyLocationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseDatabaseSourceEncryptionKeyLocationDetails\"}}]")]
        public virtual void PutSourceEncryptionKeyLocationDetails(oci.DatabaseDatabase.IDatabaseDatabaseDatabaseSourceEncryptionKeyLocationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseDatabase.IDatabaseDatabaseDatabaseSourceEncryptionKeyLocationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageSizeDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseDatabaseStorageSizeDetails\"}}]")]
        public virtual void PutStorageSizeDetails(oci.DatabaseDatabase.IDatabaseDatabaseDatabaseStorageSizeDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseDatabase.IDatabaseDatabaseDatabaseStorageSizeDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdminPassword")]
        public virtual void ResetAdminPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackupId")]
        public virtual void ResetBackupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackupTdePassword")]
        public virtual void ResetBackupTdePassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCharacterSet")]
        public virtual void ResetCharacterSet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseAdminPassword")]
        public virtual void ResetDatabaseAdminPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseSoftwareImageId")]
        public virtual void ResetDatabaseSoftwareImageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbBackupConfig")]
        public virtual void ResetDbBackupConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbName")]
        public virtual void ResetDbName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbUniqueName")]
        public virtual void ResetDbUniqueName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbWorkload")]
        public virtual void ResetDbWorkload()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionKeyLocationDetails")]
        public virtual void ResetEncryptionKeyLocationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsActiveDataGuardEnabled")]
        public virtual void ResetIsActiveDataGuardEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyId")]
        public virtual void ResetKmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyVersionId")]
        public virtual void ResetKmsKeyVersionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNcharacterSet")]
        public virtual void ResetNcharacterSet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPdbName")]
        public virtual void ResetPdbName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPluggableDatabases")]
        public virtual void ResetPluggableDatabases()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtectionMode")]
        public virtual void ResetProtectionMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSidPrefix")]
        public virtual void ResetSidPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceDatabaseId")]
        public virtual void ResetSourceDatabaseId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceEncryptionKeyLocationDetails")]
        public virtual void ResetSourceEncryptionKeyLocationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceTdeWalletPassword")]
        public virtual void ResetSourceTdeWalletPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageSizeDetails")]
        public virtual void ResetStorageSizeDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTdeWalletPassword")]
        public virtual void ResetTdeWalletPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransportType")]
        public virtual void ResetTransportType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVaultId")]
        public virtual void ResetVaultId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dbBackupConfig", typeJson: "{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseDatabaseDbBackupConfigOutputReference\"}")]
        public virtual oci.DatabaseDatabase.DatabaseDatabaseDatabaseDbBackupConfigOutputReference DbBackupConfig
        {
            get => GetInstanceProperty<oci.DatabaseDatabase.DatabaseDatabaseDatabaseDbBackupConfigOutputReference>()!;
        }

        [JsiiProperty(name: "encryptionKeyLocationDetails", typeJson: "{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseDatabaseEncryptionKeyLocationDetailsOutputReference\"}")]
        public virtual oci.DatabaseDatabase.DatabaseDatabaseDatabaseEncryptionKeyLocationDetailsOutputReference EncryptionKeyLocationDetails
        {
            get => GetInstanceProperty<oci.DatabaseDatabase.DatabaseDatabaseDatabaseEncryptionKeyLocationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "sourceEncryptionKeyLocationDetails", typeJson: "{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseDatabaseSourceEncryptionKeyLocationDetailsOutputReference\"}")]
        public virtual oci.DatabaseDatabase.DatabaseDatabaseDatabaseSourceEncryptionKeyLocationDetailsOutputReference SourceEncryptionKeyLocationDetails
        {
            get => GetInstanceProperty<oci.DatabaseDatabase.DatabaseDatabaseDatabaseSourceEncryptionKeyLocationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "storageSizeDetails", typeJson: "{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseDatabaseStorageSizeDetailsOutputReference\"}")]
        public virtual oci.DatabaseDatabase.DatabaseDatabaseDatabaseStorageSizeDetailsOutputReference StorageSizeDetails
        {
            get => GetInstanceProperty<oci.DatabaseDatabase.DatabaseDatabaseDatabaseStorageSizeDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupTdePasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackupTdePasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "characterSetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CharacterSetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseAdminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseAdminPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseSoftwareImageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseSoftwareImageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbBackupConfigInput", typeJson: "{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseDatabaseDbBackupConfig\"}", isOptional: true)]
        public virtual oci.DatabaseDatabase.IDatabaseDatabaseDatabaseDbBackupConfig? DbBackupConfigInput
        {
            get => GetInstanceProperty<oci.DatabaseDatabase.IDatabaseDatabaseDatabaseDbBackupConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbUniqueNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbUniqueNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbWorkloadInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbWorkloadInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionKeyLocationDetailsInput", typeJson: "{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseDatabaseEncryptionKeyLocationDetails\"}", isOptional: true)]
        public virtual oci.DatabaseDatabase.IDatabaseDatabaseDatabaseEncryptionKeyLocationDetails? EncryptionKeyLocationDetailsInput
        {
            get => GetInstanceProperty<oci.DatabaseDatabase.IDatabaseDatabaseDatabaseEncryptionKeyLocationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isActiveDataGuardEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsActiveDataGuardEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyVersionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyVersionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ncharacterSetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NcharacterSetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pdbNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PdbNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pluggableDatabasesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PluggableDatabasesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protectionModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtectionModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sidPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SidPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceEncryptionKeyLocationDetailsInput", typeJson: "{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseDatabaseSourceEncryptionKeyLocationDetails\"}", isOptional: true)]
        public virtual oci.DatabaseDatabase.IDatabaseDatabaseDatabaseSourceEncryptionKeyLocationDetails? SourceEncryptionKeyLocationDetailsInput
        {
            get => GetInstanceProperty<oci.DatabaseDatabase.IDatabaseDatabaseDatabaseSourceEncryptionKeyLocationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceTdeWalletPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceTdeWalletPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageSizeDetailsInput", typeJson: "{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseDatabaseStorageSizeDetails\"}", isOptional: true)]
        public virtual oci.DatabaseDatabase.IDatabaseDatabaseDatabaseStorageSizeDetails? StorageSizeDetailsInput
        {
            get => GetInstanceProperty<oci.DatabaseDatabase.IDatabaseDatabaseDatabaseStorageSizeDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tdeWalletPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TdeWalletPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transportTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransportTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vaultIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VaultIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "backupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "backupTdePassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupTdePassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CharacterSet
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseAdminPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseSoftwareImageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseSoftwareImageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbUniqueName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbUniqueName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbWorkload
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isActiveDataGuardEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsActiveDataGuardEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyVersionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyVersionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NcharacterSet
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pdbName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PdbName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pluggableDatabases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PluggableDatabases
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtectionMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sidPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SidPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceTdeWalletPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceTdeWalletPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tdeWalletPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TdeWalletPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transportType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransportType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VaultId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseDatabase.DatabaseDatabaseDatabase\"}", isOptional: true)]
        public virtual oci.DatabaseDatabase.IDatabaseDatabaseDatabase? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseDatabase.IDatabaseDatabaseDatabase?>();
            set => SetInstanceProperty(value);
        }
    }
}
