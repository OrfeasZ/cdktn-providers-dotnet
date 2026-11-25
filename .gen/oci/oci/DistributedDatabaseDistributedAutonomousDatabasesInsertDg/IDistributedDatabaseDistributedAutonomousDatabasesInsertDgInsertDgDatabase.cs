using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase")]
    public interface IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#source DistributedDatabaseDistributedAutonomousDatabasesInsertDg#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        string Source
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#cloud_autonomous_vm_cluster_id DistributedDatabaseDistributedAutonomousDatabasesInsertDg#cloud_autonomous_vm_cluster_id}.</summary>
        [JsiiProperty(name: "cloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudAutonomousVmClusterId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#fast_start_fail_over_lag_limit_in_seconds DistributedDatabaseDistributedAutonomousDatabasesInsertDg#fast_start_fail_over_lag_limit_in_seconds}.</summary>
        [JsiiProperty(name: "fastStartFailOverLagLimitInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FastStartFailOverLagLimitInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#protection_mode DistributedDatabaseDistributedAutonomousDatabasesInsertDg#protection_mode}.</summary>
        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProtectionMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#standby_maintenance_buffer_in_days DistributedDatabaseDistributedAutonomousDatabasesInsertDg#standby_maintenance_buffer_in_days}.</summary>
        [JsiiProperty(name: "standbyMaintenanceBufferInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StandbyMaintenanceBufferInDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#source DistributedDatabaseDistributedAutonomousDatabasesInsertDg#source}.</summary>
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
            public string Source
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#cloud_autonomous_vm_cluster_id DistributedDatabaseDistributedAutonomousDatabasesInsertDg#cloud_autonomous_vm_cluster_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudAutonomousVmClusterId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#fast_start_fail_over_lag_limit_in_seconds DistributedDatabaseDistributedAutonomousDatabasesInsertDg#fast_start_fail_over_lag_limit_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fastStartFailOverLagLimitInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FastStartFailOverLagLimitInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#protection_mode DistributedDatabaseDistributedAutonomousDatabasesInsertDg#protection_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProtectionMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert_dg#standby_maintenance_buffer_in_days DistributedDatabaseDistributedAutonomousDatabasesInsertDg#standby_maintenance_buffer_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "standbyMaintenanceBufferInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StandbyMaintenanceBufferInDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
