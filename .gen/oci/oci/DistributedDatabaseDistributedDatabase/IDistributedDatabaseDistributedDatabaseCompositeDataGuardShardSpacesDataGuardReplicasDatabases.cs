using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesDataGuardReplicasDatabases), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesDataGuardReplicasDatabases")]
    public interface IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesDataGuardReplicasDatabases
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#source DistributedDatabaseDistributedDatabase#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        string Source
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#admin_password DistributedDatabaseDistributedDatabase#admin_password}.</summary>
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdminPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#admin_password_secret_id DistributedDatabaseDistributedDatabase#admin_password_secret_id}.</summary>
        [JsiiProperty(name: "adminPasswordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdminPasswordSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#admin_password_secret_version_number DistributedDatabaseDistributedDatabase#admin_password_secret_version_number}.</summary>
        [JsiiProperty(name: "adminPasswordSecretVersionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AdminPasswordSecretVersionNumber
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#availability_domain DistributedDatabaseDistributedDatabase#availability_domain}.</summary>
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#db_home_id DistributedDatabaseDistributedDatabase#db_home_id}.</summary>
        [JsiiProperty(name: "dbHomeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbHomeId
        {
            get
            {
                return null;
            }
        }

        /// <summary>db_storage_vault_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#db_storage_vault_details DistributedDatabaseDistributedDatabase#db_storage_vault_details}
        /// </remarks>
        [JsiiProperty(name: "dbStorageVaultDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesDataGuardReplicasDatabasesDbStorageVaultDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesDataGuardReplicasDatabasesDbStorageVaultDetails? DbStorageVaultDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#exascale_db_storage_vault_id DistributedDatabaseDistributedDatabase#exascale_db_storage_vault_id}.</summary>
        [JsiiProperty(name: "exascaleDbStorageVaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExascaleDbStorageVaultId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#kms_key_id DistributedDatabaseDistributedDatabase#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#kms_key_version_id DistributedDatabaseDistributedDatabase#kms_key_version_id}.</summary>
        [JsiiProperty(name: "kmsKeyVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyVersionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#protection_mode DistributedDatabaseDistributedDatabase#protection_mode}.</summary>
        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProtectionMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#tde_wallet_password DistributedDatabaseDistributedDatabase#tde_wallet_password}.</summary>
        [JsiiProperty(name: "tdeWalletPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TdeWalletPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#tde_wallet_password_secret_id DistributedDatabaseDistributedDatabase#tde_wallet_password_secret_id}.</summary>
        [JsiiProperty(name: "tdeWalletPasswordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TdeWalletPasswordSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#tde_wallet_password_secret_version_number DistributedDatabaseDistributedDatabase#tde_wallet_password_secret_version_number}.</summary>
        [JsiiProperty(name: "tdeWalletPasswordSecretVersionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TdeWalletPasswordSecretVersionNumber
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#transport_type DistributedDatabaseDistributedDatabase#transport_type}.</summary>
        [JsiiProperty(name: "transportType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransportType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#vault_id DistributedDatabaseDistributedDatabase#vault_id}.</summary>
        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VaultId
        {
            get
            {
                return null;
            }
        }

        /// <summary>vm_cluster_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#vm_cluster_details DistributedDatabaseDistributedDatabase#vm_cluster_details}
        /// </remarks>
        [JsiiProperty(name: "vmClusterDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesDataGuardReplicasDatabasesVmClusterDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesDataGuardReplicasDatabasesVmClusterDetails? VmClusterDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#vm_cluster_id DistributedDatabaseDistributedDatabase#vm_cluster_id}.</summary>
        [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VmClusterId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesDataGuardReplicasDatabases), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesDataGuardReplicasDatabases")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesDataGuardReplicasDatabases
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#source DistributedDatabaseDistributedDatabase#source}.</summary>
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
            public string Source
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#admin_password DistributedDatabaseDistributedDatabase#admin_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdminPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#admin_password_secret_id DistributedDatabaseDistributedDatabase#admin_password_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adminPasswordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdminPasswordSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#admin_password_secret_version_number DistributedDatabaseDistributedDatabase#admin_password_secret_version_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adminPasswordSecretVersionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AdminPasswordSecretVersionNumber
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#availability_domain DistributedDatabaseDistributedDatabase#availability_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityDomain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#db_home_id DistributedDatabaseDistributedDatabase#db_home_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbHomeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbHomeId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>db_storage_vault_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#db_storage_vault_details DistributedDatabaseDistributedDatabase#db_storage_vault_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbStorageVaultDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesDataGuardReplicasDatabasesDbStorageVaultDetails\"}", isOptional: true)]
            public oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesDataGuardReplicasDatabasesDbStorageVaultDetails? DbStorageVaultDetails
            {
                get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesDataGuardReplicasDatabasesDbStorageVaultDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#exascale_db_storage_vault_id DistributedDatabaseDistributedDatabase#exascale_db_storage_vault_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exascaleDbStorageVaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExascaleDbStorageVaultId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#kms_key_id DistributedDatabaseDistributedDatabase#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#kms_key_version_id DistributedDatabaseDistributedDatabase#kms_key_version_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyVersionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#protection_mode DistributedDatabaseDistributedDatabase#protection_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProtectionMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#tde_wallet_password DistributedDatabaseDistributedDatabase#tde_wallet_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tdeWalletPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TdeWalletPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#tde_wallet_password_secret_id DistributedDatabaseDistributedDatabase#tde_wallet_password_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tdeWalletPasswordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TdeWalletPasswordSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#tde_wallet_password_secret_version_number DistributedDatabaseDistributedDatabase#tde_wallet_password_secret_version_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tdeWalletPasswordSecretVersionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TdeWalletPasswordSecretVersionNumber
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#transport_type DistributedDatabaseDistributedDatabase#transport_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transportType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransportType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#vault_id DistributedDatabaseDistributedDatabase#vault_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VaultId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>vm_cluster_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#vm_cluster_details DistributedDatabaseDistributedDatabase#vm_cluster_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vmClusterDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesDataGuardReplicasDatabasesVmClusterDetails\"}", isOptional: true)]
            public oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesDataGuardReplicasDatabasesVmClusterDetails? VmClusterDetails
            {
                get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesDataGuardReplicasDatabasesVmClusterDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_database#vm_cluster_id DistributedDatabaseDistributedDatabase#vm_cluster_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VmClusterId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
