using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbCloudVmCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.odbCloudVmCluster.OdbCloudVmClusterConfig")]
    public class OdbCloudVmClusterConfig : aws.OdbCloudVmCluster.IOdbCloudVmClusterConfig
    {
        /// <summary>The number of CPU cores to enable on the VM cluster. Changing this will create a new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#cpu_core_count OdbCloudVmCluster#cpu_core_count}
        /// </remarks>
        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public double CpuCoreCount
        {
            get;
            set;
        }

        /// <summary>The size of the data disk group, in terabytes (TBs), to allocate for the VM cluster.</summary>
        /// <remarks>
        /// Changing this will create a new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#data_storage_size_in_tbs OdbCloudVmCluster#data_storage_size_in_tbs}
        /// </remarks>
        [JsiiProperty(name: "dataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public double DataStorageSizeInTbs
        {
            get;
            set;
        }

        /// <summary>The list of database servers for the VM cluster. Changing this will create a new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#db_servers OdbCloudVmCluster#db_servers}
        /// </remarks>
        [JsiiProperty(name: "dbServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] DbServers
        {
            get;
            set;
        }

        /// <summary>A user-friendly name for the VM cluster. This member is required. Changing this will create a new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#display_name OdbCloudVmCluster#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>A valid software version of Oracle Grid Infrastructure (GI).</summary>
        /// <remarks>
        /// To get the list of valid values, use the ListGiVersions operation and specify the shape of the Exadata infrastructure. Example: 19.0.0.0 This member is required. Changing this will create a new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#gi_version OdbCloudVmCluster#gi_version}
        /// </remarks>
        [JsiiProperty(name: "giVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string GiVersion
        {
            get;
            set;
        }

        /// <summary>The host name prefix for the VM cluster.</summary>
        /// <remarks>
        /// Constraints: - Can't be "localhost" or "hostname". - Can't contain "-version". - The maximum length of the combined hostname and domain is 63 characters. - The hostname must be unique within the subnet. This member is required. Changing this will create a new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#hostname_prefix OdbCloudVmCluster#hostname_prefix}
        /// </remarks>
        [JsiiProperty(name: "hostnamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public string HostnamePrefix
        {
            get;
            set;
        }

        /// <summary>The public key portion of one or more key pairs used for SSH access to the VM cluster.</summary>
        /// <remarks>
        /// This member is required. Changing this will create a new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#ssh_public_keys OdbCloudVmCluster#ssh_public_keys}
        /// </remarks>
        [JsiiProperty(name: "sshPublicKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SshPublicKeys
        {
            get;
            set;
        }

        /// <summary>The unique identifier of the Exadata infrastructure for this VM cluster. Changing this will create a new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#cloud_exadata_infrastructure_arn OdbCloudVmCluster#cloud_exadata_infrastructure_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudExadataInfrastructureArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CloudExadataInfrastructureArn
        {
            get;
            set;
        }

        /// <summary>The unique identifier of the Exadata infrastructure for this VM cluster. Changing this will create a new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#cloud_exadata_infrastructure_id OdbCloudVmCluster#cloud_exadata_infrastructure_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudExadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CloudExadataInfrastructureId
        {
            get;
            set;
        }

        /// <summary>The name of the Grid Infrastructure (GI) cluster. Changing this will create a new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#cluster_name OdbCloudVmCluster#cluster_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterName
        {
            get;
            set;
        }

        private object? _dataCollectionOptions;

        /// <summary>data_collection_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#data_collection_options OdbCloudVmCluster#data_collection_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataCollectionOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbCloudVmCluster.OdbCloudVmClusterDataCollectionOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DataCollectionOptions
        {
            get => _dataCollectionOptions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.OdbCloudVmCluster.IOdbCloudVmClusterDataCollectionOptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.OdbCloudVmCluster.IOdbCloudVmClusterDataCollectionOptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataCollectionOptions = value;
            }
        }

        /// <summary>The amount of local node storage, in gigabytes (GBs), to allocate for the VM cluster.</summary>
        /// <remarks>
        /// Changing this will create a new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#db_node_storage_size_in_gbs OdbCloudVmCluster#db_node_storage_size_in_gbs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbNodeStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DbNodeStorageSizeInGbs
        {
            get;
            set;
        }

        private object? _isLocalBackupEnabled;

        /// <summary>Specifies whether to enable database backups to local Exadata storage for the VM cluster.</summary>
        /// <remarks>
        /// Changing this will create a new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#is_local_backup_enabled OdbCloudVmCluster#is_local_backup_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isLocalBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsLocalBackupEnabled
        {
            get => _isLocalBackupEnabled;
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
                _isLocalBackupEnabled = value;
            }
        }

        private object? _isSparseDiskgroupEnabled;

        /// <summary>Specifies whether to create a sparse disk group for the VM cluster. Changing this will create a new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#is_sparse_diskgroup_enabled OdbCloudVmCluster#is_sparse_diskgroup_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isSparseDiskgroupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsSparseDiskgroupEnabled
        {
            get => _isSparseDiskgroupEnabled;
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
                _isSparseDiskgroupEnabled = value;
            }
        }

        /// <summary>The Oracle license model to apply to the VM cluster. Default: LICENSE_INCLUDED. Changing this will create a new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#license_model OdbCloudVmCluster#license_model}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LicenseModel
        {
            get;
            set;
        }

        /// <summary>The amount of memory, in gigabytes (GBs), to allocate for the VM cluster.</summary>
        /// <remarks>
        /// Changing this will create a new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#memory_size_in_gbs OdbCloudVmCluster#memory_size_in_gbs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memorySizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemorySizeInGbs
        {
            get;
            set;
        }

        /// <summary>The unique identifier of the ODB network for the VM cluster.</summary>
        /// <remarks>
        /// This member is required. Changing this will create a new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#odb_network_arn OdbCloudVmCluster#odb_network_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "odbNetworkArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OdbNetworkArn
        {
            get;
            set;
        }

        /// <summary>The unique identifier of the ODB network for the VM cluster.</summary>
        /// <remarks>
        /// This member is required. Changing this will create a new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#odb_network_id OdbCloudVmCluster#odb_network_id}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#region OdbCloudVmCluster#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>The port number for TCP connections to the single client access name (SCAN) listener.</summary>
        /// <remarks>
        /// Valid values: 1024–8999 with the following exceptions: 2484 , 6100 , 6200 , 7060, 7070 , 7085 , and 7879Default: 1521. Changing this will create a new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#scan_listener_port_tcp OdbCloudVmCluster#scan_listener_port_tcp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scanListenerPortTcp", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ScanListenerPortTcp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#tags OdbCloudVmCluster#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#timeouts OdbCloudVmCluster#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.odbCloudVmCluster.OdbCloudVmClusterTimeouts\"}", isOptional: true)]
        public aws.OdbCloudVmCluster.IOdbCloudVmClusterTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>The configured time zone of the VM cluster. Changing this will create a new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_vm_cluster#timezone OdbCloudVmCluster#timezone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Timezone
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
