using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetails), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetails")]
    public interface IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#availability_domain DistributedDatabaseDistributedDatabase#availability_domain}.</summary>
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>db_storage_vault_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#db_storage_vault_details DistributedDatabaseDistributedDatabase#db_storage_vault_details}
        /// </remarks>
        [JsiiProperty(name: "dbStorageVaultDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsDbStorageVaultDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsDbStorageVaultDetails? DbStorageVaultDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#protection_mode DistributedDatabaseDistributedDatabase#protection_mode}.</summary>
        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProtectionMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#transport_type DistributedDatabaseDistributedDatabase#transport_type}.</summary>
        [JsiiProperty(name: "transportType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransportType
        {
            get
            {
                return null;
            }
        }

        /// <summary>vm_cluster_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#vm_cluster_details DistributedDatabaseDistributedDatabase#vm_cluster_details}
        /// </remarks>
        [JsiiProperty(name: "vmClusterDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsVmClusterDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsVmClusterDetails? VmClusterDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#vm_cluster_id DistributedDatabaseDistributedDatabase#vm_cluster_id}.</summary>
        [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VmClusterId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetails), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#availability_domain DistributedDatabaseDistributedDatabase#availability_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityDomain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>db_storage_vault_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#db_storage_vault_details DistributedDatabaseDistributedDatabase#db_storage_vault_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbStorageVaultDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsDbStorageVaultDetails\"}", isOptional: true)]
            public oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsDbStorageVaultDetails? DbStorageVaultDetails
            {
                get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsDbStorageVaultDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#protection_mode DistributedDatabaseDistributedDatabase#protection_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProtectionMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#transport_type DistributedDatabaseDistributedDatabase#transport_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transportType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransportType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>vm_cluster_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#vm_cluster_details DistributedDatabaseDistributedDatabase#vm_cluster_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vmClusterDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsVmClusterDetails\"}", isOptional: true)]
            public oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsVmClusterDetails? VmClusterDetails
            {
                get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetailsVmClusterDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#vm_cluster_id DistributedDatabaseDistributedDatabase#vm_cluster_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VmClusterId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
