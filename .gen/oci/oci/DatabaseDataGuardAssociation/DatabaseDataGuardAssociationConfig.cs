using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDataGuardAssociation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseDataGuardAssociation.DatabaseDataGuardAssociationConfig")]
    public class DatabaseDataGuardAssociationConfig : oci.DatabaseDataGuardAssociation.IDatabaseDataGuardAssociationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#creation_type DatabaseDataGuardAssociation#creation_type}.</summary>
        [JsiiProperty(name: "creationType", typeJson: "{\"primitive\":\"string\"}")]
        public string CreationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#database_admin_password DatabaseDataGuardAssociation#database_admin_password}.</summary>
        [JsiiProperty(name: "databaseAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public string DatabaseAdminPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#database_id DatabaseDataGuardAssociation#database_id}.</summary>
        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}")]
        public string DatabaseId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#delete_standby_db_home_on_delete DatabaseDataGuardAssociation#delete_standby_db_home_on_delete}.</summary>
        [JsiiProperty(name: "deleteStandbyDbHomeOnDelete", typeJson: "{\"primitive\":\"string\"}")]
        public string DeleteStandbyDbHomeOnDelete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#protection_mode DatabaseDataGuardAssociation#protection_mode}.</summary>
        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}")]
        public string ProtectionMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#transport_type DatabaseDataGuardAssociation#transport_type}.</summary>
        [JsiiProperty(name: "transportType", typeJson: "{\"primitive\":\"string\"}")]
        public string TransportType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#availability_domain DatabaseDataGuardAssociation#availability_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#backup_network_nsg_ids DatabaseDataGuardAssociation#backup_network_nsg_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupNetworkNsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? BackupNetworkNsgIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#cluster_placement_group_id DatabaseDataGuardAssociation#cluster_placement_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterPlacementGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#compute_count DatabaseDataGuardAssociation#compute_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ComputeCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#compute_model DatabaseDataGuardAssociation#compute_model}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computeModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComputeModel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#cpu_core_count DatabaseDataGuardAssociation#cpu_core_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CpuCoreCount
        {
            get;
            set;
        }

        private object? _createAsync;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#create_async DatabaseDataGuardAssociation#create_async}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "createAsync", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? CreateAsync
        {
            get => _createAsync;
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
                _createAsync = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#database_defined_tags DatabaseDataGuardAssociation#database_defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseDefinedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DatabaseDefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#database_freeform_tags DatabaseDataGuardAssociation#database_freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseFreeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DatabaseFreeformTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#database_software_image_id DatabaseDataGuardAssociation#database_software_image_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseSoftwareImageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseSoftwareImageId
        {
            get;
            set;
        }

        /// <summary>data_collection_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#data_collection_options DatabaseDataGuardAssociation#data_collection_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataCollectionOptions", typeJson: "{\"fqn\":\"oci.databaseDataGuardAssociation.DatabaseDataGuardAssociationDataCollectionOptions\"}", isOptional: true)]
        public oci.DatabaseDataGuardAssociation.IDatabaseDataGuardAssociationDataCollectionOptions? DataCollectionOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#db_system_defined_tags DatabaseDataGuardAssociation#db_system_defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbSystemDefinedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DbSystemDefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#db_system_freeform_tags DatabaseDataGuardAssociation#db_system_freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbSystemFreeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DbSystemFreeformTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#db_system_security_attributes DatabaseDataGuardAssociation#db_system_security_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbSystemSecurityAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DbSystemSecurityAttributes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#display_name DatabaseDataGuardAssociation#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#domain DatabaseDataGuardAssociation#domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Domain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#fault_domains DatabaseDataGuardAssociation#fault_domains}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "faultDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? FaultDomains
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#hostname DatabaseDataGuardAssociation#hostname}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Hostname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#id DatabaseDataGuardAssociation#id}.</summary>
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

        private object? _isActiveDataGuardEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#is_active_data_guard_enabled DatabaseDataGuardAssociation#is_active_data_guard_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isActiveDataGuardEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsActiveDataGuardEnabled
        {
            get => _isActiveDataGuardEnabled;
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
                _isActiveDataGuardEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#license_model DatabaseDataGuardAssociation#license_model}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LicenseModel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#migrate_trigger DatabaseDataGuardAssociation#migrate_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "migrateTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MigrateTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#node_count DatabaseDataGuardAssociation#node_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NodeCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#nsg_ids DatabaseDataGuardAssociation#nsg_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NsgIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#peer_db_home_id DatabaseDataGuardAssociation#peer_db_home_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerDbHomeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerDbHomeId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#peer_db_system_id DatabaseDataGuardAssociation#peer_db_system_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerDbSystemId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerDbSystemId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#peer_db_unique_name DatabaseDataGuardAssociation#peer_db_unique_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerDbUniqueName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerDbUniqueName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#peer_sid_prefix DatabaseDataGuardAssociation#peer_sid_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerSidPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerSidPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#peer_vm_cluster_id DatabaseDataGuardAssociation#peer_vm_cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerVmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerVmClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#private_ip DatabaseDataGuardAssociation#private_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#private_ip_v6 DatabaseDataGuardAssociation#private_ip_v6}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIpV6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateIpV6
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#shape DatabaseDataGuardAssociation#shape}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Shape
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#storage_volume_performance_mode DatabaseDataGuardAssociation#storage_volume_performance_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageVolumePerformanceMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageVolumePerformanceMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#subnet_id DatabaseDataGuardAssociation#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#subscription_id DatabaseDataGuardAssociation#subscription_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubscriptionId
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#timeouts DatabaseDataGuardAssociation#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseDataGuardAssociation.DatabaseDataGuardAssociationTimeouts\"}", isOptional: true)]
        public oci.DatabaseDataGuardAssociation.IDatabaseDataGuardAssociationTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#time_zone DatabaseDataGuardAssociation#time_zone}.</summary>
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
