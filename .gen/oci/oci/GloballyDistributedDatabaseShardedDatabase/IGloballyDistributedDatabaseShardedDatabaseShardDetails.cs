using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GloballyDistributedDatabaseShardedDatabase
{
    [JsiiInterface(nativeType: typeof(IGloballyDistributedDatabaseShardedDatabaseShardDetails), fullyQualifiedName: "oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseShardDetails")]
    public interface IGloballyDistributedDatabaseShardedDatabaseShardDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#admin_password GloballyDistributedDatabaseShardedDatabase#admin_password}.</summary>
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        string AdminPassword
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#cloud_autonomous_vm_cluster_id GloballyDistributedDatabaseShardedDatabase#cloud_autonomous_vm_cluster_id}.</summary>
        [JsiiProperty(name: "cloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        string CloudAutonomousVmClusterId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#compute_count GloballyDistributedDatabaseShardedDatabase#compute_count}.</summary>
        [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}")]
        double ComputeCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#data_storage_size_in_gbs GloballyDistributedDatabaseShardedDatabase#data_storage_size_in_gbs}.</summary>
        [JsiiProperty(name: "dataStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        double DataStorageSizeInGbs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#is_auto_scaling_enabled GloballyDistributedDatabaseShardedDatabase#is_auto_scaling_enabled}.</summary>
        [JsiiProperty(name: "isAutoScalingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsAutoScalingEnabled
        {
            get;
        }

        /// <summary>encryption_key_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#encryption_key_details GloballyDistributedDatabaseShardedDatabase#encryption_key_details}
        /// </remarks>
        [JsiiProperty(name: "encryptionKeyDetails", typeJson: "{\"fqn\":\"oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseShardDetailsEncryptionKeyDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseShardDetailsEncryptionKeyDetails? EncryptionKeyDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#peer_cloud_autonomous_vm_cluster_id GloballyDistributedDatabaseShardedDatabase#peer_cloud_autonomous_vm_cluster_id}.</summary>
        [JsiiProperty(name: "peerCloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PeerCloudAutonomousVmClusterId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#shard_space GloballyDistributedDatabaseShardedDatabase#shard_space}.</summary>
        [JsiiProperty(name: "shardSpace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShardSpace
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGloballyDistributedDatabaseShardedDatabaseShardDetails), fullyQualifiedName: "oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseShardDetails")]
        internal sealed class _Proxy : DeputyBase, oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseShardDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#admin_password GloballyDistributedDatabaseShardedDatabase#admin_password}.</summary>
            [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string AdminPassword
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#cloud_autonomous_vm_cluster_id GloballyDistributedDatabaseShardedDatabase#cloud_autonomous_vm_cluster_id}.</summary>
            [JsiiProperty(name: "cloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
            public string CloudAutonomousVmClusterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#compute_count GloballyDistributedDatabaseShardedDatabase#compute_count}.</summary>
            [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}")]
            public double ComputeCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#data_storage_size_in_gbs GloballyDistributedDatabaseShardedDatabase#data_storage_size_in_gbs}.</summary>
            [JsiiProperty(name: "dataStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
            public double DataStorageSizeInGbs
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#is_auto_scaling_enabled GloballyDistributedDatabaseShardedDatabase#is_auto_scaling_enabled}.</summary>
            [JsiiProperty(name: "isAutoScalingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsAutoScalingEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>encryption_key_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#encryption_key_details GloballyDistributedDatabaseShardedDatabase#encryption_key_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionKeyDetails", typeJson: "{\"fqn\":\"oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseShardDetailsEncryptionKeyDetails\"}", isOptional: true)]
            public oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseShardDetailsEncryptionKeyDetails? EncryptionKeyDetails
            {
                get => GetInstanceProperty<oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseShardDetailsEncryptionKeyDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#peer_cloud_autonomous_vm_cluster_id GloballyDistributedDatabaseShardedDatabase#peer_cloud_autonomous_vm_cluster_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peerCloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PeerCloudAutonomousVmClusterId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#shard_space GloballyDistributedDatabaseShardedDatabase#shard_space}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shardSpace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShardSpace
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
