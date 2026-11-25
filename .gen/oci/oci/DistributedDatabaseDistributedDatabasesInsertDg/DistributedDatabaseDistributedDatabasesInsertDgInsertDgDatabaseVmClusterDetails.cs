using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabasesInsertDg
{
    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedDatabasesInsertDg.DistributedDatabaseDistributedDatabasesInsertDgInsertDgDatabaseVmClusterDetails")]
    public class DistributedDatabaseDistributedDatabasesInsertDgInsertDgDatabaseVmClusterDetails : oci.DistributedDatabaseDistributedDatabasesInsertDg.IDistributedDatabaseDistributedDatabasesInsertDgInsertDgDatabaseVmClusterDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#backup_network_nsg_ids DistributedDatabaseDistributedDatabasesInsertDg#backup_network_nsg_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupNetworkNsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? BackupNetworkNsgIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#backup_subnet_id DistributedDatabaseDistributedDatabasesInsertDg#backup_subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackupSubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#compartment_id DistributedDatabaseDistributedDatabasesInsertDg#compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#domain DistributedDatabaseDistributedDatabasesInsertDg#domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Domain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#enabled_ecpu_count DistributedDatabaseDistributedDatabasesInsertDg#enabled_ecpu_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabledEcpuCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EnabledEcpuCount
        {
            get;
            set;
        }

        private object? _isDiagnosticsEventsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#is_diagnostics_events_enabled DistributedDatabaseDistributedDatabasesInsertDg#is_diagnostics_events_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isDiagnosticsEventsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsDiagnosticsEventsEnabled
        {
            get => _isDiagnosticsEventsEnabled;
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
                _isDiagnosticsEventsEnabled = value;
            }
        }

        private object? _isHealthMonitoringEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#is_health_monitoring_enabled DistributedDatabaseDistributedDatabasesInsertDg#is_health_monitoring_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isHealthMonitoringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsHealthMonitoringEnabled
        {
            get => _isHealthMonitoringEnabled;
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
                _isHealthMonitoringEnabled = value;
            }
        }

        private object? _isIncidentLogsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#is_incident_logs_enabled DistributedDatabaseDistributedDatabasesInsertDg#is_incident_logs_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isIncidentLogsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsIncidentLogsEnabled
        {
            get => _isIncidentLogsEnabled;
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
                _isIncidentLogsEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#license_model DistributedDatabaseDistributedDatabasesInsertDg#license_model}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LicenseModel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#nsg_ids DistributedDatabaseDistributedDatabasesInsertDg#nsg_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NsgIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#private_zone_id DistributedDatabaseDistributedDatabasesInsertDg#private_zone_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateZoneId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#ssh_public_keys DistributedDatabaseDistributedDatabasesInsertDg#ssh_public_keys}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sshPublicKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SshPublicKeys
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#subnet_id DistributedDatabaseDistributedDatabasesInsertDg#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#subscription_id DistributedDatabaseDistributedDatabasesInsertDg#subscription_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubscriptionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#total_ecpu_count DistributedDatabaseDistributedDatabasesInsertDg#total_ecpu_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "totalEcpuCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TotalEcpuCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert_dg#vm_file_system_storage_size DistributedDatabaseDistributedDatabasesInsertDg#vm_file_system_storage_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vmFileSystemStorageSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VmFileSystemStorageSize
        {
            get;
            set;
        }
    }
}
