using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudAutonomousVmCluster
{
    [JsiiInterface(nativeType: typeof(IDatabaseCloudAutonomousVmClusterConfig), fullyQualifiedName: "oci.databaseCloudAutonomousVmCluster.DatabaseCloudAutonomousVmClusterConfig")]
    public interface IDatabaseCloudAutonomousVmClusterConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#cloud_exadata_infrastructure_id DatabaseCloudAutonomousVmCluster#cloud_exadata_infrastructure_id}.</summary>
        [JsiiProperty(name: "cloudExadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        string CloudExadataInfrastructureId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#compartment_id DatabaseCloudAutonomousVmCluster#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#display_name DatabaseCloudAutonomousVmCluster#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#subnet_id DatabaseCloudAutonomousVmCluster#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#autonomous_data_storage_size_in_tbs DatabaseCloudAutonomousVmCluster#autonomous_data_storage_size_in_tbs}.</summary>
        [JsiiProperty(name: "autonomousDataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AutonomousDataStorageSizeInTbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#cluster_time_zone DatabaseCloudAutonomousVmCluster#cluster_time_zone}.</summary>
        [JsiiProperty(name: "clusterTimeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterTimeZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#compute_model DatabaseCloudAutonomousVmCluster#compute_model}.</summary>
        [JsiiProperty(name: "computeModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputeModel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#cpu_core_count_per_node DatabaseCloudAutonomousVmCluster#cpu_core_count_per_node}.</summary>
        [JsiiProperty(name: "cpuCoreCountPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CpuCoreCountPerNode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#db_servers DatabaseCloudAutonomousVmCluster#db_servers}.</summary>
        [JsiiProperty(name: "dbServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DbServers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#defined_tags DatabaseCloudAutonomousVmCluster#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#description DatabaseCloudAutonomousVmCluster#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#freeform_tags DatabaseCloudAutonomousVmCluster#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#id DatabaseCloudAutonomousVmCluster#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#is_mtls_enabled_vm_cluster DatabaseCloudAutonomousVmCluster#is_mtls_enabled_vm_cluster}.</summary>
        [JsiiProperty(name: "isMtlsEnabledVmCluster", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMtlsEnabledVmCluster
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#license_model DatabaseCloudAutonomousVmCluster#license_model}.</summary>
        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LicenseModel
        {
            get
            {
                return null;
            }
        }

        /// <summary>maintenance_window_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#maintenance_window_details DatabaseCloudAutonomousVmCluster#maintenance_window_details}
        /// </remarks>
        [JsiiProperty(name: "maintenanceWindowDetails", typeJson: "{\"fqn\":\"oci.databaseCloudAutonomousVmCluster.DatabaseCloudAutonomousVmClusterMaintenanceWindowDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseCloudAutonomousVmCluster.IDatabaseCloudAutonomousVmClusterMaintenanceWindowDetails? MaintenanceWindowDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#memory_per_oracle_compute_unit_in_gbs DatabaseCloudAutonomousVmCluster#memory_per_oracle_compute_unit_in_gbs}.</summary>
        [JsiiProperty(name: "memoryPerOracleComputeUnitInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MemoryPerOracleComputeUnitInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#nsg_ids DatabaseCloudAutonomousVmCluster#nsg_ids}.</summary>
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NsgIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#opc_dry_run DatabaseCloudAutonomousVmCluster#opc_dry_run}.</summary>
        [JsiiProperty(name: "opcDryRun", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OpcDryRun
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#scan_listener_port_non_tls DatabaseCloudAutonomousVmCluster#scan_listener_port_non_tls}.</summary>
        [JsiiProperty(name: "scanListenerPortNonTls", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScanListenerPortNonTls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#scan_listener_port_tls DatabaseCloudAutonomousVmCluster#scan_listener_port_tls}.</summary>
        [JsiiProperty(name: "scanListenerPortTls", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScanListenerPortTls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#security_attributes DatabaseCloudAutonomousVmCluster#security_attributes}.</summary>
        [JsiiProperty(name: "securityAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? SecurityAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#subscription_id DatabaseCloudAutonomousVmCluster#subscription_id}.</summary>
        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubscriptionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#timeouts DatabaseCloudAutonomousVmCluster#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseCloudAutonomousVmCluster.DatabaseCloudAutonomousVmClusterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseCloudAutonomousVmCluster.IDatabaseCloudAutonomousVmClusterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#time_updated DatabaseCloudAutonomousVmCluster#time_updated}.</summary>
        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeUpdated
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#total_container_databases DatabaseCloudAutonomousVmCluster#total_container_databases}.</summary>
        [JsiiProperty(name: "totalContainerDatabases", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TotalContainerDatabases
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseCloudAutonomousVmClusterConfig), fullyQualifiedName: "oci.databaseCloudAutonomousVmCluster.DatabaseCloudAutonomousVmClusterConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseCloudAutonomousVmCluster.IDatabaseCloudAutonomousVmClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#cloud_exadata_infrastructure_id DatabaseCloudAutonomousVmCluster#cloud_exadata_infrastructure_id}.</summary>
            [JsiiProperty(name: "cloudExadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}")]
            public string CloudExadataInfrastructureId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#compartment_id DatabaseCloudAutonomousVmCluster#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#display_name DatabaseCloudAutonomousVmCluster#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#subnet_id DatabaseCloudAutonomousVmCluster#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#autonomous_data_storage_size_in_tbs DatabaseCloudAutonomousVmCluster#autonomous_data_storage_size_in_tbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autonomousDataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AutonomousDataStorageSizeInTbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#cluster_time_zone DatabaseCloudAutonomousVmCluster#cluster_time_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusterTimeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterTimeZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#compute_model DatabaseCloudAutonomousVmCluster#compute_model}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeModel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#cpu_core_count_per_node DatabaseCloudAutonomousVmCluster#cpu_core_count_per_node}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuCoreCountPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CpuCoreCountPerNode
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#db_servers DatabaseCloudAutonomousVmCluster#db_servers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DbServers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#defined_tags DatabaseCloudAutonomousVmCluster#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#description DatabaseCloudAutonomousVmCluster#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#freeform_tags DatabaseCloudAutonomousVmCluster#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#id DatabaseCloudAutonomousVmCluster#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#is_mtls_enabled_vm_cluster DatabaseCloudAutonomousVmCluster#is_mtls_enabled_vm_cluster}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isMtlsEnabledVmCluster", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsMtlsEnabledVmCluster
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#license_model DatabaseCloudAutonomousVmCluster#license_model}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LicenseModel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>maintenance_window_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#maintenance_window_details DatabaseCloudAutonomousVmCluster#maintenance_window_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceWindowDetails", typeJson: "{\"fqn\":\"oci.databaseCloudAutonomousVmCluster.DatabaseCloudAutonomousVmClusterMaintenanceWindowDetails\"}", isOptional: true)]
            public oci.DatabaseCloudAutonomousVmCluster.IDatabaseCloudAutonomousVmClusterMaintenanceWindowDetails? MaintenanceWindowDetails
            {
                get => GetInstanceProperty<oci.DatabaseCloudAutonomousVmCluster.IDatabaseCloudAutonomousVmClusterMaintenanceWindowDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#memory_per_oracle_compute_unit_in_gbs DatabaseCloudAutonomousVmCluster#memory_per_oracle_compute_unit_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memoryPerOracleComputeUnitInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MemoryPerOracleComputeUnitInGbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#nsg_ids DatabaseCloudAutonomousVmCluster#nsg_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NsgIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#opc_dry_run DatabaseCloudAutonomousVmCluster#opc_dry_run}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "opcDryRun", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OpcDryRun
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#scan_listener_port_non_tls DatabaseCloudAutonomousVmCluster#scan_listener_port_non_tls}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scanListenerPortNonTls", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScanListenerPortNonTls
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#scan_listener_port_tls DatabaseCloudAutonomousVmCluster#scan_listener_port_tls}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scanListenerPortTls", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScanListenerPortTls
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#security_attributes DatabaseCloudAutonomousVmCluster#security_attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? SecurityAttributes
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#subscription_id DatabaseCloudAutonomousVmCluster#subscription_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubscriptionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#timeouts DatabaseCloudAutonomousVmCluster#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseCloudAutonomousVmCluster.DatabaseCloudAutonomousVmClusterTimeouts\"}", isOptional: true)]
            public oci.DatabaseCloudAutonomousVmCluster.IDatabaseCloudAutonomousVmClusterTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseCloudAutonomousVmCluster.IDatabaseCloudAutonomousVmClusterTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#time_updated DatabaseCloudAutonomousVmCluster#time_updated}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeUpdated
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_autonomous_vm_cluster#total_container_databases DatabaseCloudAutonomousVmCluster#total_container_databases}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "totalContainerDatabases", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalContainerDatabases
            {
                get => GetInstanceProperty<double?>();
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
