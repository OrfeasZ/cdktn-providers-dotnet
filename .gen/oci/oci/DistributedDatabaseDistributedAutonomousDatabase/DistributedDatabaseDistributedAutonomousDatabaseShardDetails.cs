using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseShardDetails")]
    public class DistributedDatabaseDistributedAutonomousDatabaseShardDetails : oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseShardDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#cloud_autonomous_vm_cluster_id DistributedDatabaseDistributedAutonomousDatabase#cloud_autonomous_vm_cluster_id}.</summary>
        [JsiiProperty(name: "cloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public string CloudAutonomousVmClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#compute_count DistributedDatabaseDistributedAutonomousDatabase#compute_count}.</summary>
        [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}")]
        public double ComputeCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#data_storage_size_in_gbs DistributedDatabaseDistributedAutonomousDatabase#data_storage_size_in_gbs}.</summary>
        [JsiiProperty(name: "dataStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public double DataStorageSizeInGbs
        {
            get;
            set;
        }

        private object _isAutoScalingEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#is_auto_scaling_enabled DistributedDatabaseDistributedAutonomousDatabase#is_auto_scaling_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isAutoScalingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsAutoScalingEnabled
        {
            get => _isAutoScalingEnabled;
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
                _isAutoScalingEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#source DistributedDatabaseDistributedAutonomousDatabase#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public string Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#admin_password DistributedDatabaseDistributedAutonomousDatabase#admin_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdminPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#kms_key_id DistributedDatabaseDistributedAutonomousDatabase#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#kms_key_version_id DistributedDatabaseDistributedAutonomousDatabase#kms_key_version_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyVersionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#okv_end_point_group DistributedDatabaseDistributedAutonomousDatabase#okv_end_point_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "okvEndPointGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OkvEndPointGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#okv_key_store_id DistributedDatabaseDistributedAutonomousDatabase#okv_key_store_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "okvKeyStoreId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OkvKeyStoreId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#peer_cloud_autonomous_vm_cluster_ids DistributedDatabaseDistributedAutonomousDatabase#peer_cloud_autonomous_vm_cluster_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerCloudAutonomousVmClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PeerCloudAutonomousVmClusterIds
        {
            get;
            set;
        }

        private object? _peerDetails;

        /// <summary>peer_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#peer_details DistributedDatabaseDistributedAutonomousDatabase#peer_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseShardDetailsPeerDetails" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "peerDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseShardDetailsPeerDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseShardDetailsPeerDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseShardDetailsPeerDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _peerDetails = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#shard_space DistributedDatabaseDistributedAutonomousDatabase#shard_space}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shardSpace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShardSpace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#vault_id DistributedDatabaseDistributedAutonomousDatabase#vault_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VaultId
        {
            get;
            set;
        }
    }
}
