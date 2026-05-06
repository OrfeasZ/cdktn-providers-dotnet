using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GloballyDistributedDatabaseShardedDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseCatalogDetails")]
    public class GloballyDistributedDatabaseShardedDatabaseCatalogDetails : oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseCatalogDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#admin_password GloballyDistributedDatabaseShardedDatabase#admin_password}.</summary>
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public string AdminPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#cloud_autonomous_vm_cluster_id GloballyDistributedDatabaseShardedDatabase#cloud_autonomous_vm_cluster_id}.</summary>
        [JsiiProperty(name: "cloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public string CloudAutonomousVmClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#compute_count GloballyDistributedDatabaseShardedDatabase#compute_count}.</summary>
        [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}")]
        public double ComputeCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#data_storage_size_in_gbs GloballyDistributedDatabaseShardedDatabase#data_storage_size_in_gbs}.</summary>
        [JsiiProperty(name: "dataStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public double DataStorageSizeInGbs
        {
            get;
            set;
        }

        private object _isAutoScalingEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#is_auto_scaling_enabled GloballyDistributedDatabaseShardedDatabase#is_auto_scaling_enabled}.</summary>
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

        /// <summary>encryption_key_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#encryption_key_details GloballyDistributedDatabaseShardedDatabase#encryption_key_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionKeyDetails", typeJson: "{\"fqn\":\"oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseCatalogDetailsEncryptionKeyDetails\"}", isOptional: true)]
        public oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseCatalogDetailsEncryptionKeyDetails? EncryptionKeyDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#peer_cloud_autonomous_vm_cluster_id GloballyDistributedDatabaseShardedDatabase#peer_cloud_autonomous_vm_cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerCloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerCloudAutonomousVmClusterId
        {
            get;
            set;
        }
    }
}
