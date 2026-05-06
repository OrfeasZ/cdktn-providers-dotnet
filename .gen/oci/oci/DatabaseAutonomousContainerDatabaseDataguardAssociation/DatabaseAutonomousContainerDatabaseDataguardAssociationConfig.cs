using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousContainerDatabaseDataguardAssociation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseAutonomousContainerDatabaseDataguardAssociation.DatabaseAutonomousContainerDatabaseDataguardAssociationConfig")]
    public class DatabaseAutonomousContainerDatabaseDataguardAssociationConfig : oci.DatabaseAutonomousContainerDatabaseDataguardAssociation.IDatabaseAutonomousContainerDatabaseDataguardAssociationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#autonomous_container_database_id DatabaseAutonomousContainerDatabaseDataguardAssociation#autonomous_container_database_id}.</summary>
        [JsiiProperty(name: "autonomousContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public string AutonomousContainerDatabaseId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#peer_autonomous_container_database_display_name DatabaseAutonomousContainerDatabaseDataguardAssociation#peer_autonomous_container_database_display_name}.</summary>
        [JsiiProperty(name: "peerAutonomousContainerDatabaseDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public string PeerAutonomousContainerDatabaseDisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#protection_mode DatabaseAutonomousContainerDatabaseDataguardAssociation#protection_mode}.</summary>
        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}")]
        public string ProtectionMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#autonomous_container_database_dataguard_association_id DatabaseAutonomousContainerDatabaseDataguardAssociation#autonomous_container_database_dataguard_association_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autonomousContainerDatabaseDataguardAssociationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutonomousContainerDatabaseDataguardAssociationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#fast_start_fail_over_lag_limit_in_seconds DatabaseAutonomousContainerDatabaseDataguardAssociation#fast_start_fail_over_lag_limit_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fastStartFailOverLagLimitInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FastStartFailOverLagLimitInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#id DatabaseAutonomousContainerDatabaseDataguardAssociation#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        private object? _isAutomaticFailoverEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#is_automatic_failover_enabled DatabaseAutonomousContainerDatabaseDataguardAssociation#is_automatic_failover_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isAutomaticFailoverEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsAutomaticFailoverEnabled
        {
            get => _isAutomaticFailoverEnabled;
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
                _isAutomaticFailoverEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#migrate_trigger DatabaseAutonomousContainerDatabaseDataguardAssociation#migrate_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "migrateTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MigrateTrigger
        {
            get;
            set;
        }

        /// <summary>peer_autonomous_container_database_backup_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#peer_autonomous_container_database_backup_config DatabaseAutonomousContainerDatabaseDataguardAssociation#peer_autonomous_container_database_backup_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "peerAutonomousContainerDatabaseBackupConfig", typeJson: "{\"fqn\":\"oci.databaseAutonomousContainerDatabaseDataguardAssociation.DatabaseAutonomousContainerDatabaseDataguardAssociationPeerAutonomousContainerDatabaseBackupConfig\"}", isOptional: true)]
        public oci.DatabaseAutonomousContainerDatabaseDataguardAssociation.IDatabaseAutonomousContainerDatabaseDataguardAssociationPeerAutonomousContainerDatabaseBackupConfig? PeerAutonomousContainerDatabaseBackupConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#peer_autonomous_container_database_compartment_id DatabaseAutonomousContainerDatabaseDataguardAssociation#peer_autonomous_container_database_compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerAutonomousContainerDatabaseCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerAutonomousContainerDatabaseCompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#peer_autonomous_vm_cluster_id DatabaseAutonomousContainerDatabaseDataguardAssociation#peer_autonomous_vm_cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerAutonomousVmClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#peer_cloud_autonomous_vm_cluster_id DatabaseAutonomousContainerDatabaseDataguardAssociation#peer_cloud_autonomous_vm_cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerCloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerCloudAutonomousVmClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#peer_db_unique_name DatabaseAutonomousContainerDatabaseDataguardAssociation#peer_db_unique_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerDbUniqueName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerDbUniqueName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#standby_maintenance_buffer_in_days DatabaseAutonomousContainerDatabaseDataguardAssociation#standby_maintenance_buffer_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "standbyMaintenanceBufferInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StandbyMaintenanceBufferInDays
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_dataguard_association#timeouts DatabaseAutonomousContainerDatabaseDataguardAssociation#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseAutonomousContainerDatabaseDataguardAssociation.DatabaseAutonomousContainerDatabaseDataguardAssociationTimeouts\"}", isOptional: true)]
        public oci.DatabaseAutonomousContainerDatabaseDataguardAssociation.IDatabaseAutonomousContainerDatabaseDataguardAssociationTimeouts? Timeouts
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
