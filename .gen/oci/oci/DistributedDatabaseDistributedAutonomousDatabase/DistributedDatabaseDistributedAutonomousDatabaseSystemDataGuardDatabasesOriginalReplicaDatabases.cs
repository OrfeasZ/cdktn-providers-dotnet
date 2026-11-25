using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseSystemDataGuardDatabasesOriginalReplicaDatabases")]
    public class DistributedDatabaseDistributedAutonomousDatabaseSystemDataGuardDatabasesOriginalReplicaDatabases : oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseSystemDataGuardDatabasesOriginalReplicaDatabases
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#cloud_autonomous_vm_cluster_id DistributedDatabaseDistributedAutonomousDatabase#cloud_autonomous_vm_cluster_id}.</summary>
        [JsiiProperty(name: "cloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public string CloudAutonomousVmClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#compute_count DistributedDatabaseDistributedAutonomousDatabase#compute_count}.</summary>
        [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}")]
        public double ComputeCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#data_storage_size_in_gbs DistributedDatabaseDistributedAutonomousDatabase#data_storage_size_in_gbs}.</summary>
        [JsiiProperty(name: "dataStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public double DataStorageSizeInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#source DistributedDatabaseDistributedAutonomousDatabase#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public string Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#admin_password DistributedDatabaseDistributedAutonomousDatabase#admin_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdminPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#admin_password_secret_id DistributedDatabaseDistributedAutonomousDatabase#admin_password_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminPasswordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdminPasswordSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#admin_password_secret_version_number DistributedDatabaseDistributedAutonomousDatabase#admin_password_secret_version_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminPasswordSecretVersionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AdminPasswordSecretVersionNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#fast_start_fail_over_lag_limit_in_seconds DistributedDatabaseDistributedAutonomousDatabase#fast_start_fail_over_lag_limit_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fastStartFailOverLagLimitInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FastStartFailOverLagLimitInSeconds
        {
            get;
            set;
        }

        private object? _isAutoScalingEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#is_auto_scaling_enabled DistributedDatabaseDistributedAutonomousDatabase#is_auto_scaling_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isAutoScalingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsAutoScalingEnabled
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isAutoScalingEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#kms_key_id DistributedDatabaseDistributedAutonomousDatabase#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#kms_key_version_id DistributedDatabaseDistributedAutonomousDatabase#kms_key_version_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyVersionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#okv_end_point_group_name DistributedDatabaseDistributedAutonomousDatabase#okv_end_point_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "okvEndPointGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OkvEndPointGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#okv_key_store_id DistributedDatabaseDistributedAutonomousDatabase#okv_key_store_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "okvKeyStoreId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OkvKeyStoreId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#protection_mode DistributedDatabaseDistributedAutonomousDatabase#protection_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProtectionMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#shard_space_name DistributedDatabaseDistributedAutonomousDatabase#shard_space_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shardSpaceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShardSpaceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#standby_maintenance_buffer_in_days DistributedDatabaseDistributedAutonomousDatabase#standby_maintenance_buffer_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "standbyMaintenanceBufferInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StandbyMaintenanceBufferInDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#vault_id DistributedDatabaseDistributedAutonomousDatabase#vault_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vaultId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VaultId
        {
            get;
            set;
        }
    }
}
