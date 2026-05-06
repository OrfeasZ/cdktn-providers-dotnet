using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GloballyDistributedDatabaseShardedDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseConfig")]
    public class GloballyDistributedDatabaseShardedDatabaseConfig : oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseConfig
    {
        private object _catalogDetails;

        /// <summary>catalog_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#catalog_details GloballyDistributedDatabaseShardedDatabase#catalog_details}
        /// </remarks>
        [JsiiProperty(name: "catalogDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseCatalogDetails\"},\"kind\":\"array\"}}]}}")]
        public object CatalogDetails
        {
            get => _catalogDetails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseCatalogDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseCatalogDetails).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseCatalogDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _catalogDetails = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#character_set GloballyDistributedDatabaseShardedDatabase#character_set}.</summary>
        [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}")]
        public string CharacterSet
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#compartment_id GloballyDistributedDatabaseShardedDatabase#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public string CompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#db_deployment_type GloballyDistributedDatabaseShardedDatabase#db_deployment_type}.</summary>
        [JsiiProperty(name: "dbDeploymentType", typeJson: "{\"primitive\":\"string\"}")]
        public string DbDeploymentType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#db_version GloballyDistributedDatabaseShardedDatabase#db_version}.</summary>
        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string DbVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#db_workload GloballyDistributedDatabaseShardedDatabase#db_workload}.</summary>
        [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}")]
        public string DbWorkload
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#display_name GloballyDistributedDatabaseShardedDatabase#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#listener_port GloballyDistributedDatabaseShardedDatabase#listener_port}.</summary>
        [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}")]
        public double ListenerPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#listener_port_tls GloballyDistributedDatabaseShardedDatabase#listener_port_tls}.</summary>
        [JsiiProperty(name: "listenerPortTls", typeJson: "{\"primitive\":\"number\"}")]
        public double ListenerPortTls
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#ncharacter_set GloballyDistributedDatabaseShardedDatabase#ncharacter_set}.</summary>
        [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}")]
        public string NcharacterSet
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#ons_port_local GloballyDistributedDatabaseShardedDatabase#ons_port_local}.</summary>
        [JsiiProperty(name: "onsPortLocal", typeJson: "{\"primitive\":\"number\"}")]
        public double OnsPortLocal
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#ons_port_remote GloballyDistributedDatabaseShardedDatabase#ons_port_remote}.</summary>
        [JsiiProperty(name: "onsPortRemote", typeJson: "{\"primitive\":\"number\"}")]
        public double OnsPortRemote
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#prefix GloballyDistributedDatabaseShardedDatabase#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public string Prefix
        {
            get;
            set;
        }

        private object _shardDetails;

        /// <summary>shard_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#shard_details GloballyDistributedDatabaseShardedDatabase#shard_details}
        /// </remarks>
        [JsiiProperty(name: "shardDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseShardDetails\"},\"kind\":\"array\"}}]}}")]
        public object ShardDetails
        {
            get => _shardDetails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseShardDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseShardDetails).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseShardDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _shardDetails = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#sharding_method GloballyDistributedDatabaseShardedDatabase#sharding_method}.</summary>
        [JsiiProperty(name: "shardingMethod", typeJson: "{\"primitive\":\"string\"}")]
        public string ShardingMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#ca_signed_certificate GloballyDistributedDatabaseShardedDatabase#ca_signed_certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "caSignedCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaSignedCertificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#chunks GloballyDistributedDatabaseShardedDatabase#chunks}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "chunks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Chunks
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#cluster_certificate_common_name GloballyDistributedDatabaseShardedDatabase#cluster_certificate_common_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterCertificateCommonName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterCertificateCommonName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#configure_gsms_trigger GloballyDistributedDatabaseShardedDatabase#configure_gsms_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configureGsmsTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConfigureGsmsTrigger
        {
            get;
            set;
        }

        private object? _configureGsmsTriggerIsLatestGsmImage;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#configure_gsms_trigger_is_latest_gsm_image GloballyDistributedDatabaseShardedDatabase#configure_gsms_trigger_is_latest_gsm_image}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configureGsmsTriggerIsLatestGsmImage", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ConfigureGsmsTriggerIsLatestGsmImage
        {
            get => _configureGsmsTriggerIsLatestGsmImage;
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
                _configureGsmsTriggerIsLatestGsmImage = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#configure_gsms_trigger_old_gsm_names GloballyDistributedDatabaseShardedDatabase#configure_gsms_trigger_old_gsm_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configureGsmsTriggerOldGsmNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ConfigureGsmsTriggerOldGsmNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#configure_sharding_trigger GloballyDistributedDatabaseShardedDatabase#configure_sharding_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configureShardingTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConfigureShardingTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#defined_tags GloballyDistributedDatabaseShardedDatabase#defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#download_gsm_certificate_signing_request_trigger GloballyDistributedDatabaseShardedDatabase#download_gsm_certificate_signing_request_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "downloadGsmCertificateSigningRequestTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DownloadGsmCertificateSigningRequestTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#get_connection_string_trigger GloballyDistributedDatabaseShardedDatabase#get_connection_string_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fetchConnectionStringTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FetchConnectionStringTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#freeform_tags GloballyDistributedDatabaseShardedDatabase#freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#generate_gsm_certificate_signing_request_trigger GloballyDistributedDatabaseShardedDatabase#generate_gsm_certificate_signing_request_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "generateGsmCertificateSigningRequestTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GenerateGsmCertificateSigningRequestTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#generate_wallet_password GloballyDistributedDatabaseShardedDatabase#generate_wallet_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "generateWalletPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GenerateWalletPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#generate_wallet_trigger GloballyDistributedDatabaseShardedDatabase#generate_wallet_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "generateWalletTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GenerateWalletTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#id GloballyDistributedDatabaseShardedDatabase#id}.</summary>
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

        private object? _patchOperations;

        /// <summary>patch_operations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#patch_operations GloballyDistributedDatabaseShardedDatabase#patch_operations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "patchOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabasePatchOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PatchOperations
        {
            get => _patchOperations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabasePatchOperations[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabasePatchOperations).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _patchOperations = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#replication_factor GloballyDistributedDatabaseShardedDatabase#replication_factor}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicationFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReplicationFactor
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#replication_method GloballyDistributedDatabaseShardedDatabase#replication_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplicationMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#replication_unit GloballyDistributedDatabaseShardedDatabase#replication_unit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicationUnit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReplicationUnit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#start_database_trigger GloballyDistributedDatabaseShardedDatabase#start_database_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StartDatabaseTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#stop_database_trigger GloballyDistributedDatabaseShardedDatabase#stop_database_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stopDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StopDatabaseTrigger
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#timeouts GloballyDistributedDatabaseShardedDatabase#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseTimeouts\"}", isOptional: true)]
        public oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#upload_signed_certificate_and_generate_wallet_trigger GloballyDistributedDatabaseShardedDatabase#upload_signed_certificate_and_generate_wallet_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uploadSignedCertificateAndGenerateWalletTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UploadSignedCertificateAndGenerateWalletTrigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#validate_network_trigger GloballyDistributedDatabaseShardedDatabase#validate_network_trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "validateNetworkTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ValidateNetworkTrigger
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
