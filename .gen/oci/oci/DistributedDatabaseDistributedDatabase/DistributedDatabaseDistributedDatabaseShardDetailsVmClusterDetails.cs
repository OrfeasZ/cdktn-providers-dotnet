using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseShardDetailsVmClusterDetails")]
    public class DistributedDatabaseDistributedDatabaseShardDetailsVmClusterDetails : oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseShardDetailsVmClusterDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/distributed_database_distributed_database#backup_network_nsg_ids DistributedDatabaseDistributedDatabase#backup_network_nsg_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupNetworkNsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? BackupNetworkNsgIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/distributed_database_distributed_database#backup_subnet_id DistributedDatabaseDistributedDatabase#backup_subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackupSubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/distributed_database_distributed_database#domain DistributedDatabaseDistributedDatabase#domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Domain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/distributed_database_distributed_database#enabled_ecpu_count DistributedDatabaseDistributedDatabase#enabled_ecpu_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabledEcpuCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EnabledEcpuCount
        {
            get;
            set;
        }

        private object? _isDiagnosticsEventsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/distributed_database_distributed_database#is_diagnostics_events_enabled DistributedDatabaseDistributedDatabase#is_diagnostics_events_enabled}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/distributed_database_distributed_database#is_health_monitoring_enabled DistributedDatabaseDistributedDatabase#is_health_monitoring_enabled}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/distributed_database_distributed_database#is_incident_logs_enabled DistributedDatabaseDistributedDatabase#is_incident_logs_enabled}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/distributed_database_distributed_database#license_model DistributedDatabaseDistributedDatabase#license_model}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LicenseModel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/distributed_database_distributed_database#nsg_ids DistributedDatabaseDistributedDatabase#nsg_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NsgIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/distributed_database_distributed_database#private_zone_id DistributedDatabaseDistributedDatabase#private_zone_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateZoneId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/distributed_database_distributed_database#ssh_public_keys DistributedDatabaseDistributedDatabase#ssh_public_keys}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sshPublicKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SshPublicKeys
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/distributed_database_distributed_database#subnet_id DistributedDatabaseDistributedDatabase#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/distributed_database_distributed_database#total_ecpu_count DistributedDatabaseDistributedDatabase#total_ecpu_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "totalEcpuCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TotalEcpuCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/distributed_database_distributed_database#vm_file_system_storage_size DistributedDatabaseDistributedDatabase#vm_file_system_storage_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vmFileSystemStorageSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VmFileSystemStorageSize
        {
            get;
            set;
        }
    }
}
