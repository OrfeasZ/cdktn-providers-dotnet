using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetails")]
    public class DistributedDatabaseDistributedDatabaseShardDetails : oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#admin_password DistributedDatabaseDistributedDatabase#admin_password}.</summary>
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public string AdminPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#source DistributedDatabaseDistributedDatabase#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public string Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#availability_domain DistributedDatabaseDistributedDatabase#availability_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityDomain
        {
            get;
            set;
        }

        /// <summary>db_storage_vault_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#db_storage_vault_details DistributedDatabaseDistributedDatabase#db_storage_vault_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbStorageVaultDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsDbStorageVaultDetails\"}", isOptional: true)]
        public oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsDbStorageVaultDetails? DbStorageVaultDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#kms_key_id DistributedDatabaseDistributedDatabase#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#kms_key_version_id DistributedDatabaseDistributedDatabase#kms_key_version_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyVersionId
        {
            get;
            set;
        }

        private object? _peerDetails;

        /// <summary>peer_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#peer_details DistributedDatabaseDistributedDatabase#peer_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetails" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "peerDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsPeerDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PeerDetails
        {
            get => _peerDetails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsPeerDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _peerDetails = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#peer_vm_cluster_ids DistributedDatabaseDistributedDatabase#peer_vm_cluster_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerVmClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PeerVmClusterIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#shard_space DistributedDatabaseDistributedDatabase#shard_space}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shardSpace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShardSpace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#vault_id DistributedDatabaseDistributedDatabase#vault_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VaultId
        {
            get;
            set;
        }

        /// <summary>vm_cluster_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#vm_cluster_details DistributedDatabaseDistributedDatabase#vm_cluster_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vmClusterDetails", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsVmClusterDetails\"}", isOptional: true)]
        public oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsVmClusterDetails? VmClusterDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/distributed_database_distributed_database#vm_cluster_id DistributedDatabaseDistributedDatabase#vm_cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VmClusterId
        {
            get;
            set;
        }
    }
}
