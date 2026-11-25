using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    [JsiiClass(nativeType: typeof(oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesOutputReference), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDbStorageVaultDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesDbStorageVaultDetails\"}}]")]
        public virtual void PutDbStorageVaultDetails(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesDbStorageVaultDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesDbStorageVaultDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVmClusterDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesVmClusterDetails\"}}]")]
        public virtual void PutVmClusterDetails(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesVmClusterDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesVmClusterDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdminPassword")]
        public virtual void ResetAdminPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdminPasswordSecretId")]
        public virtual void ResetAdminPasswordSecretId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdminPasswordSecretVersionNumber")]
        public virtual void ResetAdminPasswordSecretVersionNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAvailabilityDomain")]
        public virtual void ResetAvailabilityDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbHomeId")]
        public virtual void ResetDbHomeId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbStorageVaultDetails")]
        public virtual void ResetDbStorageVaultDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExascaleDbStorageVaultId")]
        public virtual void ResetExascaleDbStorageVaultId()
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

        [JsiiMethod(name: "resetProtectionMode")]
        public virtual void ResetProtectionMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTdeWalletPassword")]
        public virtual void ResetTdeWalletPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTdeWalletPasswordSecretId")]
        public virtual void ResetTdeWalletPasswordSecretId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTdeWalletPasswordSecretVersionNumber")]
        public virtual void ResetTdeWalletPasswordSecretVersionNumber()
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

        [JsiiMethod(name: "resetVmClusterDetails")]
        public virtual void ResetVmClusterDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVmClusterId")]
        public virtual void ResetVmClusterId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "containerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbStorageVaultDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesDbStorageVaultDetailsOutputReference\"}")]
        public virtual oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesDbStorageVaultDetailsOutputReference DbStorageVaultDetails
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesDbStorageVaultDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesMetadataList\"}")]
        public virtual oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesMetadataList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
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

        [JsiiProperty(name: "vmClusterDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesVmClusterDetailsOutputReference\"}")]
        public virtual oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesVmClusterDetailsOutputReference VmClusterDetails
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesVmClusterDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminPasswordSecretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminPasswordSecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminPasswordSecretVersionNumberInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AdminPasswordSecretVersionNumberInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbHomeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbHomeIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbStorageVaultDetailsInput", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesDbStorageVaultDetails\"}", isOptional: true)]
        public virtual oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesDbStorageVaultDetails? DbStorageVaultDetailsInput
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesDbStorageVaultDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exascaleDbStorageVaultIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExascaleDbStorageVaultIdInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "protectionModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtectionModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tdeWalletPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TdeWalletPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tdeWalletPasswordSecretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TdeWalletPasswordSecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tdeWalletPasswordSecretVersionNumberInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TdeWalletPasswordSecretVersionNumberInput
        {
            get => GetInstanceProperty<double?>();
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

        [JsiiOptional]
        [JsiiProperty(name: "vmClusterDetailsInput", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesVmClusterDetails\"}", isOptional: true)]
        public virtual oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesVmClusterDetails? VmClusterDetailsInput
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabasesVmClusterDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmClusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VmClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "adminPasswordSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminPasswordSecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "adminPasswordSecretVersionNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AdminPasswordSecretVersionNumber
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbHomeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbHomeId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "exascaleDbStorageVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExascaleDbStorageVaultId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
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

        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtectionMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
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

        [JsiiProperty(name: "tdeWalletPasswordSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TdeWalletPasswordSecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tdeWalletPasswordSecretVersionNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TdeWalletPasswordSecretVersionNumber
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabases" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabases\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabases cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesOriginalReplicaDatabases).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
