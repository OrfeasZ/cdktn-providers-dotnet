using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GloballyDistributedDatabaseShardedDatabase
{
    [JsiiInterface(nativeType: typeof(IGloballyDistributedDatabaseShardedDatabaseConfig), fullyQualifiedName: "oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseConfig")]
    public interface IGloballyDistributedDatabaseShardedDatabaseConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>catalog_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#catalog_details GloballyDistributedDatabaseShardedDatabase#catalog_details}
        /// </remarks>
        [JsiiProperty(name: "catalogDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseCatalogDetails\"},\"kind\":\"array\"}}]}}")]
        object CatalogDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#character_set GloballyDistributedDatabaseShardedDatabase#character_set}.</summary>
        [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}")]
        string CharacterSet
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#compartment_id GloballyDistributedDatabaseShardedDatabase#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#db_deployment_type GloballyDistributedDatabaseShardedDatabase#db_deployment_type}.</summary>
        [JsiiProperty(name: "dbDeploymentType", typeJson: "{\"primitive\":\"string\"}")]
        string DbDeploymentType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#db_version GloballyDistributedDatabaseShardedDatabase#db_version}.</summary>
        [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}")]
        string DbVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#db_workload GloballyDistributedDatabaseShardedDatabase#db_workload}.</summary>
        [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}")]
        string DbWorkload
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#display_name GloballyDistributedDatabaseShardedDatabase#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#listener_port GloballyDistributedDatabaseShardedDatabase#listener_port}.</summary>
        [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}")]
        double ListenerPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#listener_port_tls GloballyDistributedDatabaseShardedDatabase#listener_port_tls}.</summary>
        [JsiiProperty(name: "listenerPortTls", typeJson: "{\"primitive\":\"number\"}")]
        double ListenerPortTls
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#ncharacter_set GloballyDistributedDatabaseShardedDatabase#ncharacter_set}.</summary>
        [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}")]
        string NcharacterSet
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#ons_port_local GloballyDistributedDatabaseShardedDatabase#ons_port_local}.</summary>
        [JsiiProperty(name: "onsPortLocal", typeJson: "{\"primitive\":\"number\"}")]
        double OnsPortLocal
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#ons_port_remote GloballyDistributedDatabaseShardedDatabase#ons_port_remote}.</summary>
        [JsiiProperty(name: "onsPortRemote", typeJson: "{\"primitive\":\"number\"}")]
        double OnsPortRemote
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#prefix GloballyDistributedDatabaseShardedDatabase#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        string Prefix
        {
            get;
        }

        /// <summary>shard_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#shard_details GloballyDistributedDatabaseShardedDatabase#shard_details}
        /// </remarks>
        [JsiiProperty(name: "shardDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseShardDetails\"},\"kind\":\"array\"}}]}}")]
        object ShardDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#sharding_method GloballyDistributedDatabaseShardedDatabase#sharding_method}.</summary>
        [JsiiProperty(name: "shardingMethod", typeJson: "{\"primitive\":\"string\"}")]
        string ShardingMethod
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#ca_signed_certificate GloballyDistributedDatabaseShardedDatabase#ca_signed_certificate}.</summary>
        [JsiiProperty(name: "caSignedCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaSignedCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#chunks GloballyDistributedDatabaseShardedDatabase#chunks}.</summary>
        [JsiiProperty(name: "chunks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Chunks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#cluster_certificate_common_name GloballyDistributedDatabaseShardedDatabase#cluster_certificate_common_name}.</summary>
        [JsiiProperty(name: "clusterCertificateCommonName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterCertificateCommonName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#configure_gsms_trigger GloballyDistributedDatabaseShardedDatabase#configure_gsms_trigger}.</summary>
        [JsiiProperty(name: "configureGsmsTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConfigureGsmsTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#configure_gsms_trigger_is_latest_gsm_image GloballyDistributedDatabaseShardedDatabase#configure_gsms_trigger_is_latest_gsm_image}.</summary>
        [JsiiProperty(name: "configureGsmsTriggerIsLatestGsmImage", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConfigureGsmsTriggerIsLatestGsmImage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#configure_gsms_trigger_old_gsm_names GloballyDistributedDatabaseShardedDatabase#configure_gsms_trigger_old_gsm_names}.</summary>
        [JsiiProperty(name: "configureGsmsTriggerOldGsmNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ConfigureGsmsTriggerOldGsmNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#configure_sharding_trigger GloballyDistributedDatabaseShardedDatabase#configure_sharding_trigger}.</summary>
        [JsiiProperty(name: "configureShardingTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConfigureShardingTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#defined_tags GloballyDistributedDatabaseShardedDatabase#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#download_gsm_certificate_signing_request_trigger GloballyDistributedDatabaseShardedDatabase#download_gsm_certificate_signing_request_trigger}.</summary>
        [JsiiProperty(name: "downloadGsmCertificateSigningRequestTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DownloadGsmCertificateSigningRequestTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#get_connection_string_trigger GloballyDistributedDatabaseShardedDatabase#get_connection_string_trigger}.</summary>
        [JsiiProperty(name: "fetchConnectionStringTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FetchConnectionStringTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#freeform_tags GloballyDistributedDatabaseShardedDatabase#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#generate_gsm_certificate_signing_request_trigger GloballyDistributedDatabaseShardedDatabase#generate_gsm_certificate_signing_request_trigger}.</summary>
        [JsiiProperty(name: "generateGsmCertificateSigningRequestTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GenerateGsmCertificateSigningRequestTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#generate_wallet_password GloballyDistributedDatabaseShardedDatabase#generate_wallet_password}.</summary>
        [JsiiProperty(name: "generateWalletPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GenerateWalletPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#generate_wallet_trigger GloballyDistributedDatabaseShardedDatabase#generate_wallet_trigger}.</summary>
        [JsiiProperty(name: "generateWalletTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GenerateWalletTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#id GloballyDistributedDatabaseShardedDatabase#id}.</summary>
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

        /// <summary>patch_operations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#patch_operations GloballyDistributedDatabaseShardedDatabase#patch_operations}
        /// </remarks>
        [JsiiProperty(name: "patchOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabasePatchOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PatchOperations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#replication_factor GloballyDistributedDatabaseShardedDatabase#replication_factor}.</summary>
        [JsiiProperty(name: "replicationFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReplicationFactor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#replication_method GloballyDistributedDatabaseShardedDatabase#replication_method}.</summary>
        [JsiiProperty(name: "replicationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplicationMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#replication_unit GloballyDistributedDatabaseShardedDatabase#replication_unit}.</summary>
        [JsiiProperty(name: "replicationUnit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReplicationUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#start_database_trigger GloballyDistributedDatabaseShardedDatabase#start_database_trigger}.</summary>
        [JsiiProperty(name: "startDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StartDatabaseTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#stop_database_trigger GloballyDistributedDatabaseShardedDatabase#stop_database_trigger}.</summary>
        [JsiiProperty(name: "stopDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StopDatabaseTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#timeouts GloballyDistributedDatabaseShardedDatabase#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#upload_signed_certificate_and_generate_wallet_trigger GloballyDistributedDatabaseShardedDatabase#upload_signed_certificate_and_generate_wallet_trigger}.</summary>
        [JsiiProperty(name: "uploadSignedCertificateAndGenerateWalletTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UploadSignedCertificateAndGenerateWalletTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#validate_network_trigger GloballyDistributedDatabaseShardedDatabase#validate_network_trigger}.</summary>
        [JsiiProperty(name: "validateNetworkTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ValidateNetworkTrigger
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGloballyDistributedDatabaseShardedDatabaseConfig), fullyQualifiedName: "oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>catalog_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#catalog_details GloballyDistributedDatabaseShardedDatabase#catalog_details}
            /// </remarks>
            [JsiiProperty(name: "catalogDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseCatalogDetails\"},\"kind\":\"array\"}}]}}")]
            public object CatalogDetails
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#character_set GloballyDistributedDatabaseShardedDatabase#character_set}.</summary>
            [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}")]
            public string CharacterSet
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#compartment_id GloballyDistributedDatabaseShardedDatabase#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#db_deployment_type GloballyDistributedDatabaseShardedDatabase#db_deployment_type}.</summary>
            [JsiiProperty(name: "dbDeploymentType", typeJson: "{\"primitive\":\"string\"}")]
            public string DbDeploymentType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#db_version GloballyDistributedDatabaseShardedDatabase#db_version}.</summary>
            [JsiiProperty(name: "dbVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string DbVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#db_workload GloballyDistributedDatabaseShardedDatabase#db_workload}.</summary>
            [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}")]
            public string DbWorkload
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#display_name GloballyDistributedDatabaseShardedDatabase#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#listener_port GloballyDistributedDatabaseShardedDatabase#listener_port}.</summary>
            [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}")]
            public double ListenerPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#listener_port_tls GloballyDistributedDatabaseShardedDatabase#listener_port_tls}.</summary>
            [JsiiProperty(name: "listenerPortTls", typeJson: "{\"primitive\":\"number\"}")]
            public double ListenerPortTls
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#ncharacter_set GloballyDistributedDatabaseShardedDatabase#ncharacter_set}.</summary>
            [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}")]
            public string NcharacterSet
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#ons_port_local GloballyDistributedDatabaseShardedDatabase#ons_port_local}.</summary>
            [JsiiProperty(name: "onsPortLocal", typeJson: "{\"primitive\":\"number\"}")]
            public double OnsPortLocal
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#ons_port_remote GloballyDistributedDatabaseShardedDatabase#ons_port_remote}.</summary>
            [JsiiProperty(name: "onsPortRemote", typeJson: "{\"primitive\":\"number\"}")]
            public double OnsPortRemote
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#prefix GloballyDistributedDatabaseShardedDatabase#prefix}.</summary>
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
            public string Prefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>shard_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#shard_details GloballyDistributedDatabaseShardedDatabase#shard_details}
            /// </remarks>
            [JsiiProperty(name: "shardDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseShardDetails\"},\"kind\":\"array\"}}]}}")]
            public object ShardDetails
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#sharding_method GloballyDistributedDatabaseShardedDatabase#sharding_method}.</summary>
            [JsiiProperty(name: "shardingMethod", typeJson: "{\"primitive\":\"string\"}")]
            public string ShardingMethod
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#ca_signed_certificate GloballyDistributedDatabaseShardedDatabase#ca_signed_certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "caSignedCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaSignedCertificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#chunks GloballyDistributedDatabaseShardedDatabase#chunks}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "chunks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Chunks
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#cluster_certificate_common_name GloballyDistributedDatabaseShardedDatabase#cluster_certificate_common_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusterCertificateCommonName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterCertificateCommonName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#configure_gsms_trigger GloballyDistributedDatabaseShardedDatabase#configure_gsms_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configureGsmsTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConfigureGsmsTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#configure_gsms_trigger_is_latest_gsm_image GloballyDistributedDatabaseShardedDatabase#configure_gsms_trigger_is_latest_gsm_image}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configureGsmsTriggerIsLatestGsmImage", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ConfigureGsmsTriggerIsLatestGsmImage
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#configure_gsms_trigger_old_gsm_names GloballyDistributedDatabaseShardedDatabase#configure_gsms_trigger_old_gsm_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configureGsmsTriggerOldGsmNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ConfigureGsmsTriggerOldGsmNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#configure_sharding_trigger GloballyDistributedDatabaseShardedDatabase#configure_sharding_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configureShardingTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConfigureShardingTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#defined_tags GloballyDistributedDatabaseShardedDatabase#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#download_gsm_certificate_signing_request_trigger GloballyDistributedDatabaseShardedDatabase#download_gsm_certificate_signing_request_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "downloadGsmCertificateSigningRequestTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DownloadGsmCertificateSigningRequestTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#get_connection_string_trigger GloballyDistributedDatabaseShardedDatabase#get_connection_string_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fetchConnectionStringTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FetchConnectionStringTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#freeform_tags GloballyDistributedDatabaseShardedDatabase#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#generate_gsm_certificate_signing_request_trigger GloballyDistributedDatabaseShardedDatabase#generate_gsm_certificate_signing_request_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "generateGsmCertificateSigningRequestTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GenerateGsmCertificateSigningRequestTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#generate_wallet_password GloballyDistributedDatabaseShardedDatabase#generate_wallet_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "generateWalletPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GenerateWalletPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#generate_wallet_trigger GloballyDistributedDatabaseShardedDatabase#generate_wallet_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "generateWalletTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GenerateWalletTrigger
            {
                get => GetInstanceProperty<double?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>patch_operations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#patch_operations GloballyDistributedDatabaseShardedDatabase#patch_operations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "patchOperations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabasePatchOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PatchOperations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#replication_factor GloballyDistributedDatabaseShardedDatabase#replication_factor}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicationFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReplicationFactor
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#replication_method GloballyDistributedDatabaseShardedDatabase#replication_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplicationMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#replication_unit GloballyDistributedDatabaseShardedDatabase#replication_unit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicationUnit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReplicationUnit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#start_database_trigger GloballyDistributedDatabaseShardedDatabase#start_database_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StartDatabaseTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#stop_database_trigger GloballyDistributedDatabaseShardedDatabase#stop_database_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stopDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StopDatabaseTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#timeouts GloballyDistributedDatabaseShardedDatabase#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.globallyDistributedDatabaseShardedDatabase.GloballyDistributedDatabaseShardedDatabaseTimeouts\"}", isOptional: true)]
            public oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.GloballyDistributedDatabaseShardedDatabase.IGloballyDistributedDatabaseShardedDatabaseTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#upload_signed_certificate_and_generate_wallet_trigger GloballyDistributedDatabaseShardedDatabase#upload_signed_certificate_and_generate_wallet_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uploadSignedCertificateAndGenerateWalletTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UploadSignedCertificateAndGenerateWalletTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/globally_distributed_database_sharded_database#validate_network_trigger GloballyDistributedDatabaseShardedDatabase#validate_network_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validateNetworkTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ValidateNetworkTrigger
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
