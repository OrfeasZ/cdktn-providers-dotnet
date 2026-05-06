using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousContainerDatabaseAddStandby
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousContainerDatabaseAddStandbyConfig), fullyQualifiedName: "oci.databaseAutonomousContainerDatabaseAddStandby.DatabaseAutonomousContainerDatabaseAddStandbyConfig")]
    public interface IDatabaseAutonomousContainerDatabaseAddStandbyConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#autonomous_container_database_id DatabaseAutonomousContainerDatabaseAddStandby#autonomous_container_database_id}.</summary>
        [JsiiProperty(name: "autonomousContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string AutonomousContainerDatabaseId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#fast_start_fail_over_lag_limit_in_seconds DatabaseAutonomousContainerDatabaseAddStandby#fast_start_fail_over_lag_limit_in_seconds}.</summary>
        [JsiiProperty(name: "fastStartFailOverLagLimitInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FastStartFailOverLagLimitInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#id DatabaseAutonomousContainerDatabaseAddStandby#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#is_automatic_failover_enabled DatabaseAutonomousContainerDatabaseAddStandby#is_automatic_failover_enabled}.</summary>
        [JsiiProperty(name: "isAutomaticFailoverEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAutomaticFailoverEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>peer_autonomous_container_database_backup_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#peer_autonomous_container_database_backup_config DatabaseAutonomousContainerDatabaseAddStandby#peer_autonomous_container_database_backup_config}
        /// </remarks>
        [JsiiProperty(name: "peerAutonomousContainerDatabaseBackupConfig", typeJson: "{\"fqn\":\"oci.databaseAutonomousContainerDatabaseAddStandby.DatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseAutonomousContainerDatabaseAddStandby.IDatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfig? PeerAutonomousContainerDatabaseBackupConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#peer_autonomous_container_database_compartment_id DatabaseAutonomousContainerDatabaseAddStandby#peer_autonomous_container_database_compartment_id}.</summary>
        [JsiiProperty(name: "peerAutonomousContainerDatabaseCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PeerAutonomousContainerDatabaseCompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#peer_autonomous_container_database_display_name DatabaseAutonomousContainerDatabaseAddStandby#peer_autonomous_container_database_display_name}.</summary>
        [JsiiProperty(name: "peerAutonomousContainerDatabaseDisplayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PeerAutonomousContainerDatabaseDisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#peer_autonomous_vm_cluster_id DatabaseAutonomousContainerDatabaseAddStandby#peer_autonomous_vm_cluster_id}.</summary>
        [JsiiProperty(name: "peerAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PeerAutonomousVmClusterId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#peer_cloud_autonomous_vm_cluster_id DatabaseAutonomousContainerDatabaseAddStandby#peer_cloud_autonomous_vm_cluster_id}.</summary>
        [JsiiProperty(name: "peerCloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PeerCloudAutonomousVmClusterId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#peer_db_unique_name DatabaseAutonomousContainerDatabaseAddStandby#peer_db_unique_name}.</summary>
        [JsiiProperty(name: "peerDbUniqueName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PeerDbUniqueName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#protection_mode DatabaseAutonomousContainerDatabaseAddStandby#protection_mode}.</summary>
        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProtectionMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#standby_maintenance_buffer_in_days DatabaseAutonomousContainerDatabaseAddStandby#standby_maintenance_buffer_in_days}.</summary>
        [JsiiProperty(name: "standbyMaintenanceBufferInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StandbyMaintenanceBufferInDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#timeouts DatabaseAutonomousContainerDatabaseAddStandby#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseAutonomousContainerDatabaseAddStandby.DatabaseAutonomousContainerDatabaseAddStandbyTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseAutonomousContainerDatabaseAddStandby.IDatabaseAutonomousContainerDatabaseAddStandbyTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousContainerDatabaseAddStandbyConfig), fullyQualifiedName: "oci.databaseAutonomousContainerDatabaseAddStandby.DatabaseAutonomousContainerDatabaseAddStandbyConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousContainerDatabaseAddStandby.IDatabaseAutonomousContainerDatabaseAddStandbyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#autonomous_container_database_id DatabaseAutonomousContainerDatabaseAddStandby#autonomous_container_database_id}.</summary>
            [JsiiProperty(name: "autonomousContainerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string AutonomousContainerDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#fast_start_fail_over_lag_limit_in_seconds DatabaseAutonomousContainerDatabaseAddStandby#fast_start_fail_over_lag_limit_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fastStartFailOverLagLimitInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FastStartFailOverLagLimitInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#id DatabaseAutonomousContainerDatabaseAddStandby#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#is_automatic_failover_enabled DatabaseAutonomousContainerDatabaseAddStandby#is_automatic_failover_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isAutomaticFailoverEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAutomaticFailoverEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>peer_autonomous_container_database_backup_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#peer_autonomous_container_database_backup_config DatabaseAutonomousContainerDatabaseAddStandby#peer_autonomous_container_database_backup_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "peerAutonomousContainerDatabaseBackupConfig", typeJson: "{\"fqn\":\"oci.databaseAutonomousContainerDatabaseAddStandby.DatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfig\"}", isOptional: true)]
            public oci.DatabaseAutonomousContainerDatabaseAddStandby.IDatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfig? PeerAutonomousContainerDatabaseBackupConfig
            {
                get => GetInstanceProperty<oci.DatabaseAutonomousContainerDatabaseAddStandby.IDatabaseAutonomousContainerDatabaseAddStandbyPeerAutonomousContainerDatabaseBackupConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#peer_autonomous_container_database_compartment_id DatabaseAutonomousContainerDatabaseAddStandby#peer_autonomous_container_database_compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peerAutonomousContainerDatabaseCompartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PeerAutonomousContainerDatabaseCompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#peer_autonomous_container_database_display_name DatabaseAutonomousContainerDatabaseAddStandby#peer_autonomous_container_database_display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peerAutonomousContainerDatabaseDisplayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PeerAutonomousContainerDatabaseDisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#peer_autonomous_vm_cluster_id DatabaseAutonomousContainerDatabaseAddStandby#peer_autonomous_vm_cluster_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peerAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PeerAutonomousVmClusterId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#peer_cloud_autonomous_vm_cluster_id DatabaseAutonomousContainerDatabaseAddStandby#peer_cloud_autonomous_vm_cluster_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peerCloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PeerCloudAutonomousVmClusterId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#peer_db_unique_name DatabaseAutonomousContainerDatabaseAddStandby#peer_db_unique_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "peerDbUniqueName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PeerDbUniqueName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#protection_mode DatabaseAutonomousContainerDatabaseAddStandby#protection_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProtectionMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#standby_maintenance_buffer_in_days DatabaseAutonomousContainerDatabaseAddStandby#standby_maintenance_buffer_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "standbyMaintenanceBufferInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StandbyMaintenanceBufferInDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database_add_standby#timeouts DatabaseAutonomousContainerDatabaseAddStandby#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseAutonomousContainerDatabaseAddStandby.DatabaseAutonomousContainerDatabaseAddStandbyTimeouts\"}", isOptional: true)]
            public oci.DatabaseAutonomousContainerDatabaseAddStandby.IDatabaseAutonomousContainerDatabaseAddStandbyTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseAutonomousContainerDatabaseAddStandby.IDatabaseAutonomousContainerDatabaseAddStandbyTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
