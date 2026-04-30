using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbCloudAutonomousVmCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.odbCloudAutonomousVmCluster.OdbCloudAutonomousVmClusterConfig")]
    public class OdbCloudAutonomousVmClusterConfig : aws.OdbCloudAutonomousVmCluster.IOdbCloudAutonomousVmClusterConfig
    {
        /// <summary>The data storage size allocated for Autonomous Databases in the Autonomous VM cluster, in TB.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#autonomous_data_storage_size_in_tbs OdbCloudAutonomousVmCluster#autonomous_data_storage_size_in_tbs}
        /// </remarks>
        [JsiiProperty(name: "autonomousDataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public double AutonomousDataStorageSizeInTbs
        {
            get;
            set;
        }

        /// <summary>The number of CPU cores enabled per node in the Autonomous VM cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#cpu_core_count_per_node OdbCloudAutonomousVmCluster#cpu_core_count_per_node}
        /// </remarks>
        [JsiiProperty(name: "cpuCoreCountPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public double CpuCoreCountPerNode
        {
            get;
            set;
        }

        /// <summary>The database servers in the Autonomous VM cluster. Changing this will force terraform to create new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#db_servers OdbCloudAutonomousVmCluster#db_servers}
        /// </remarks>
        [JsiiProperty(name: "dbServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] DbServers
        {
            get;
            set;
        }

        /// <summary>The display name of the Autonomous VM cluster. Changing this will force terraform to create new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#display_name OdbCloudAutonomousVmCluster#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>The amount of memory allocated per Oracle Compute Unit, in GB.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#memory_per_oracle_compute_unit_in_gbs OdbCloudAutonomousVmCluster#memory_per_oracle_compute_unit_in_gbs}
        /// </remarks>
        [JsiiProperty(name: "memoryPerOracleComputeUnitInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public double MemoryPerOracleComputeUnitInGbs
        {
            get;
            set;
        }

        /// <summary>The SCAN listener port for non-TLS (TCP) protocol.</summary>
        /// <remarks>
        /// The default is 1521. Changing this will force terraform to create new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#scan_listener_port_non_tls OdbCloudAutonomousVmCluster#scan_listener_port_non_tls}
        /// </remarks>
        [JsiiProperty(name: "scanListenerPortNonTls", typeJson: "{\"primitive\":\"number\"}")]
        public double ScanListenerPortNonTls
        {
            get;
            set;
        }

        /// <summary>The SCAN listener port for TLS (TCP) protocol.</summary>
        /// <remarks>
        /// The default is 2484. Changing this will force terraform to create new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#scan_listener_port_tls OdbCloudAutonomousVmCluster#scan_listener_port_tls}
        /// </remarks>
        [JsiiProperty(name: "scanListenerPortTls", typeJson: "{\"primitive\":\"number\"}")]
        public double ScanListenerPortTls
        {
            get;
            set;
        }

        /// <summary>The total number of Autonomous Container Databases that can be created with the allocated local storage.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#total_container_databases OdbCloudAutonomousVmCluster#total_container_databases}
        /// </remarks>
        [JsiiProperty(name: "totalContainerDatabases", typeJson: "{\"primitive\":\"number\"}")]
        public double TotalContainerDatabases
        {
            get;
            set;
        }

        /// <summary>The unique identifier of the Exadata infrastructure for this VM cluster. Changing this will create a new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#cloud_exadata_infrastructure_arn OdbCloudAutonomousVmCluster#cloud_exadata_infrastructure_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudExadataInfrastructureArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CloudExadataInfrastructureArn
        {
            get;
            set;
        }

        /// <summary>Exadata infrastructure id. Changing this will force terraform to create new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#cloud_exadata_infrastructure_id OdbCloudAutonomousVmCluster#cloud_exadata_infrastructure_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudExadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CloudExadataInfrastructureId
        {
            get;
            set;
        }

        /// <summary>The description of the Autonomous VM cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#description OdbCloudAutonomousVmCluster#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        private object? _isMtlsEnabledVmCluster;

        /// <summary>Indicates whether mutual TLS (mTLS) authentication is enabled for the Autonomous VM cluster.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#is_mtls_enabled_vm_cluster OdbCloudAutonomousVmCluster#is_mtls_enabled_vm_cluster}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isMtlsEnabledVmCluster", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsMtlsEnabledVmCluster
        {
            get => _isMtlsEnabledVmCluster;
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
                _isMtlsEnabledVmCluster = value;
            }
        }

        /// <summary>The license model for the Autonomous VM cluster.</summary>
        /// <remarks>
        /// Valid values are LICENSE_INCLUDED or BRING_YOUR_OWN_LICENSE . Changing this will force terraform to create new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#license_model OdbCloudAutonomousVmCluster#license_model}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LicenseModel
        {
            get;
            set;
        }

        private object? _maintenanceWindow;

        /// <summary>maintenance_window block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#maintenance_window OdbCloudAutonomousVmCluster#maintenance_window}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbCloudAutonomousVmCluster.OdbCloudAutonomousVmClusterMaintenanceWindow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MaintenanceWindow
        {
            get => _maintenanceWindow;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.OdbCloudAutonomousVmCluster.IOdbCloudAutonomousVmClusterMaintenanceWindow[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.OdbCloudAutonomousVmCluster.IOdbCloudAutonomousVmClusterMaintenanceWindow).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _maintenanceWindow = value;
            }
        }

        /// <summary>The unique identifier of the ODB network for the VM cluster.</summary>
        /// <remarks>
        /// This member is required. Changing this will create a new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#odb_network_arn OdbCloudAutonomousVmCluster#odb_network_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "odbNetworkArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OdbNetworkArn
        {
            get;
            set;
        }

        /// <summary>The unique identifier of the ODB network associated with this Autonomous VM Cluster.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#odb_network_id OdbCloudAutonomousVmCluster#odb_network_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "odbNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OdbNetworkId
        {
            get;
            set;
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#region OdbCloudAutonomousVmCluster#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#tags OdbCloudAutonomousVmCluster#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#timeouts OdbCloudAutonomousVmCluster#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.odbCloudAutonomousVmCluster.OdbCloudAutonomousVmClusterTimeouts\"}", isOptional: true)]
        public aws.OdbCloudAutonomousVmCluster.IOdbCloudAutonomousVmClusterTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>The time zone of the Autonomous VM cluster. Changing this will force terraform to create new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_autonomous_vm_cluster#time_zone OdbCloudAutonomousVmCluster#time_zone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeZone
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
