using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseOpensearchConfig
{
    [JsiiInterface(nativeType: typeof(IDatabaseOpensearchConfigConfig), fullyQualifiedName: "digitalocean.databaseOpensearchConfig.DatabaseOpensearchConfigConfig")]
    public interface IDatabaseOpensearchConfigConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#cluster_id DatabaseOpensearchConfig#cluster_id}.</summary>
        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#action_auto_create_index_enabled DatabaseOpensearchConfig#action_auto_create_index_enabled}.</summary>
        [JsiiProperty(name: "actionAutoCreateIndexEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ActionAutoCreateIndexEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#action_destructive_requires_name DatabaseOpensearchConfig#action_destructive_requires_name}.</summary>
        [JsiiProperty(name: "actionDestructiveRequiresName", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ActionDestructiveRequiresName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#cluster_max_shards_per_node DatabaseOpensearchConfig#cluster_max_shards_per_node}.</summary>
        [JsiiProperty(name: "clusterMaxShardsPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ClusterMaxShardsPerNode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#cluster_routing_allocation_node_concurrent_recoveries DatabaseOpensearchConfig#cluster_routing_allocation_node_concurrent_recoveries}.</summary>
        [JsiiProperty(name: "clusterRoutingAllocationNodeConcurrentRecoveries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ClusterRoutingAllocationNodeConcurrentRecoveries
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#enable_security_audit DatabaseOpensearchConfig#enable_security_audit}.</summary>
        [JsiiProperty(name: "enableSecurityAudit", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableSecurityAudit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#http_max_content_length_bytes DatabaseOpensearchConfig#http_max_content_length_bytes}.</summary>
        [JsiiProperty(name: "httpMaxContentLengthBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpMaxContentLengthBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#http_max_header_size_bytes DatabaseOpensearchConfig#http_max_header_size_bytes}.</summary>
        [JsiiProperty(name: "httpMaxHeaderSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpMaxHeaderSizeBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#http_max_initial_line_length_bytes DatabaseOpensearchConfig#http_max_initial_line_length_bytes}.</summary>
        [JsiiProperty(name: "httpMaxInitialLineLengthBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpMaxInitialLineLengthBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#id DatabaseOpensearchConfig#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_fielddata_cache_size_percentage DatabaseOpensearchConfig#indices_fielddata_cache_size_percentage}.</summary>
        [JsiiProperty(name: "indicesFielddataCacheSizePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IndicesFielddataCacheSizePercentage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_memory_index_buffer_size_percentage DatabaseOpensearchConfig#indices_memory_index_buffer_size_percentage}.</summary>
        [JsiiProperty(name: "indicesMemoryIndexBufferSizePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IndicesMemoryIndexBufferSizePercentage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_memory_max_index_buffer_size_mb DatabaseOpensearchConfig#indices_memory_max_index_buffer_size_mb}.</summary>
        [JsiiProperty(name: "indicesMemoryMaxIndexBufferSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IndicesMemoryMaxIndexBufferSizeMb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_memory_min_index_buffer_size_mb DatabaseOpensearchConfig#indices_memory_min_index_buffer_size_mb}.</summary>
        [JsiiProperty(name: "indicesMemoryMinIndexBufferSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IndicesMemoryMinIndexBufferSizeMb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_queries_cache_size_percentage DatabaseOpensearchConfig#indices_queries_cache_size_percentage}.</summary>
        [JsiiProperty(name: "indicesQueriesCacheSizePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IndicesQueriesCacheSizePercentage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_query_bool_max_clause_count DatabaseOpensearchConfig#indices_query_bool_max_clause_count}.</summary>
        [JsiiProperty(name: "indicesQueryBoolMaxClauseCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IndicesQueryBoolMaxClauseCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_recovery_max_concurrent_file_chunks DatabaseOpensearchConfig#indices_recovery_max_concurrent_file_chunks}.</summary>
        [JsiiProperty(name: "indicesRecoveryMaxConcurrentFileChunks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IndicesRecoveryMaxConcurrentFileChunks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_recovery_max_mb_per_sec DatabaseOpensearchConfig#indices_recovery_max_mb_per_sec}.</summary>
        [JsiiProperty(name: "indicesRecoveryMaxMbPerSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IndicesRecoveryMaxMbPerSec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#ism_enabled DatabaseOpensearchConfig#ism_enabled}.</summary>
        [JsiiProperty(name: "ismEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsmEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#ism_history_enabled DatabaseOpensearchConfig#ism_history_enabled}.</summary>
        [JsiiProperty(name: "ismHistoryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsmHistoryEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#ism_history_max_age_hours DatabaseOpensearchConfig#ism_history_max_age_hours}.</summary>
        [JsiiProperty(name: "ismHistoryMaxAgeHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IsmHistoryMaxAgeHours
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#ism_history_max_docs DatabaseOpensearchConfig#ism_history_max_docs}.</summary>
        [JsiiProperty(name: "ismHistoryMaxDocs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IsmHistoryMaxDocs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#ism_history_rollover_check_period_hours DatabaseOpensearchConfig#ism_history_rollover_check_period_hours}.</summary>
        [JsiiProperty(name: "ismHistoryRolloverCheckPeriodHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IsmHistoryRolloverCheckPeriodHours
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#ism_history_rollover_retention_period_days DatabaseOpensearchConfig#ism_history_rollover_retention_period_days}.</summary>
        [JsiiProperty(name: "ismHistoryRolloverRetentionPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IsmHistoryRolloverRetentionPeriodDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#override_main_response_version DatabaseOpensearchConfig#override_main_response_version}.</summary>
        [JsiiProperty(name: "overrideMainResponseVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OverrideMainResponseVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#plugins_alerting_filter_by_backend_roles_enabled DatabaseOpensearchConfig#plugins_alerting_filter_by_backend_roles_enabled}.</summary>
        [JsiiProperty(name: "pluginsAlertingFilterByBackendRolesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PluginsAlertingFilterByBackendRolesEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#reindex_remote_whitelist DatabaseOpensearchConfig#reindex_remote_whitelist}.</summary>
        [JsiiProperty(name: "reindexRemoteWhitelist", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ReindexRemoteWhitelist
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#script_max_compilations_rate DatabaseOpensearchConfig#script_max_compilations_rate}.</summary>
        [JsiiProperty(name: "scriptMaxCompilationsRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScriptMaxCompilationsRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#search_max_buckets DatabaseOpensearchConfig#search_max_buckets}.</summary>
        [JsiiProperty(name: "searchMaxBuckets", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SearchMaxBuckets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_analyze_queue_size DatabaseOpensearchConfig#thread_pool_analyze_queue_size}.</summary>
        [JsiiProperty(name: "threadPoolAnalyzeQueueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThreadPoolAnalyzeQueueSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_analyze_size DatabaseOpensearchConfig#thread_pool_analyze_size}.</summary>
        [JsiiProperty(name: "threadPoolAnalyzeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThreadPoolAnalyzeSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_force_merge_size DatabaseOpensearchConfig#thread_pool_force_merge_size}.</summary>
        [JsiiProperty(name: "threadPoolForceMergeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThreadPoolForceMergeSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_get_queue_size DatabaseOpensearchConfig#thread_pool_get_queue_size}.</summary>
        [JsiiProperty(name: "threadPoolGetQueueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThreadPoolGetQueueSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_get_size DatabaseOpensearchConfig#thread_pool_get_size}.</summary>
        [JsiiProperty(name: "threadPoolGetSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThreadPoolGetSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_search_queue_size DatabaseOpensearchConfig#thread_pool_search_queue_size}.</summary>
        [JsiiProperty(name: "threadPoolSearchQueueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThreadPoolSearchQueueSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_search_size DatabaseOpensearchConfig#thread_pool_search_size}.</summary>
        [JsiiProperty(name: "threadPoolSearchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThreadPoolSearchSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_search_throttled_queue_size DatabaseOpensearchConfig#thread_pool_search_throttled_queue_size}.</summary>
        [JsiiProperty(name: "threadPoolSearchThrottledQueueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThreadPoolSearchThrottledQueueSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_search_throttled_size DatabaseOpensearchConfig#thread_pool_search_throttled_size}.</summary>
        [JsiiProperty(name: "threadPoolSearchThrottledSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThreadPoolSearchThrottledSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_write_queue_size DatabaseOpensearchConfig#thread_pool_write_queue_size}.</summary>
        [JsiiProperty(name: "threadPoolWriteQueueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThreadPoolWriteQueueSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_write_size DatabaseOpensearchConfig#thread_pool_write_size}.</summary>
        [JsiiProperty(name: "threadPoolWriteSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThreadPoolWriteSize
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseOpensearchConfigConfig), fullyQualifiedName: "digitalocean.databaseOpensearchConfig.DatabaseOpensearchConfigConfig")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DatabaseOpensearchConfig.IDatabaseOpensearchConfigConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#cluster_id DatabaseOpensearchConfig#cluster_id}.</summary>
            [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#action_auto_create_index_enabled DatabaseOpensearchConfig#action_auto_create_index_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "actionAutoCreateIndexEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ActionAutoCreateIndexEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#action_destructive_requires_name DatabaseOpensearchConfig#action_destructive_requires_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "actionDestructiveRequiresName", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ActionDestructiveRequiresName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#cluster_max_shards_per_node DatabaseOpensearchConfig#cluster_max_shards_per_node}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusterMaxShardsPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ClusterMaxShardsPerNode
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#cluster_routing_allocation_node_concurrent_recoveries DatabaseOpensearchConfig#cluster_routing_allocation_node_concurrent_recoveries}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusterRoutingAllocationNodeConcurrentRecoveries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ClusterRoutingAllocationNodeConcurrentRecoveries
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#enable_security_audit DatabaseOpensearchConfig#enable_security_audit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableSecurityAudit", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableSecurityAudit
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#http_max_content_length_bytes DatabaseOpensearchConfig#http_max_content_length_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpMaxContentLengthBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpMaxContentLengthBytes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#http_max_header_size_bytes DatabaseOpensearchConfig#http_max_header_size_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpMaxHeaderSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpMaxHeaderSizeBytes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#http_max_initial_line_length_bytes DatabaseOpensearchConfig#http_max_initial_line_length_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpMaxInitialLineLengthBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpMaxInitialLineLengthBytes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#id DatabaseOpensearchConfig#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_fielddata_cache_size_percentage DatabaseOpensearchConfig#indices_fielddata_cache_size_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "indicesFielddataCacheSizePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IndicesFielddataCacheSizePercentage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_memory_index_buffer_size_percentage DatabaseOpensearchConfig#indices_memory_index_buffer_size_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "indicesMemoryIndexBufferSizePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IndicesMemoryIndexBufferSizePercentage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_memory_max_index_buffer_size_mb DatabaseOpensearchConfig#indices_memory_max_index_buffer_size_mb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "indicesMemoryMaxIndexBufferSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IndicesMemoryMaxIndexBufferSizeMb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_memory_min_index_buffer_size_mb DatabaseOpensearchConfig#indices_memory_min_index_buffer_size_mb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "indicesMemoryMinIndexBufferSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IndicesMemoryMinIndexBufferSizeMb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_queries_cache_size_percentage DatabaseOpensearchConfig#indices_queries_cache_size_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "indicesQueriesCacheSizePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IndicesQueriesCacheSizePercentage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_query_bool_max_clause_count DatabaseOpensearchConfig#indices_query_bool_max_clause_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "indicesQueryBoolMaxClauseCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IndicesQueryBoolMaxClauseCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_recovery_max_concurrent_file_chunks DatabaseOpensearchConfig#indices_recovery_max_concurrent_file_chunks}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "indicesRecoveryMaxConcurrentFileChunks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IndicesRecoveryMaxConcurrentFileChunks
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_recovery_max_mb_per_sec DatabaseOpensearchConfig#indices_recovery_max_mb_per_sec}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "indicesRecoveryMaxMbPerSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IndicesRecoveryMaxMbPerSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#ism_enabled DatabaseOpensearchConfig#ism_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ismEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsmEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#ism_history_enabled DatabaseOpensearchConfig#ism_history_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ismHistoryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsmHistoryEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#ism_history_max_age_hours DatabaseOpensearchConfig#ism_history_max_age_hours}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ismHistoryMaxAgeHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IsmHistoryMaxAgeHours
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#ism_history_max_docs DatabaseOpensearchConfig#ism_history_max_docs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ismHistoryMaxDocs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IsmHistoryMaxDocs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#ism_history_rollover_check_period_hours DatabaseOpensearchConfig#ism_history_rollover_check_period_hours}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ismHistoryRolloverCheckPeriodHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IsmHistoryRolloverCheckPeriodHours
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#ism_history_rollover_retention_period_days DatabaseOpensearchConfig#ism_history_rollover_retention_period_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ismHistoryRolloverRetentionPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IsmHistoryRolloverRetentionPeriodDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#override_main_response_version DatabaseOpensearchConfig#override_main_response_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "overrideMainResponseVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OverrideMainResponseVersion
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#plugins_alerting_filter_by_backend_roles_enabled DatabaseOpensearchConfig#plugins_alerting_filter_by_backend_roles_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pluginsAlertingFilterByBackendRolesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PluginsAlertingFilterByBackendRolesEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#reindex_remote_whitelist DatabaseOpensearchConfig#reindex_remote_whitelist}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reindexRemoteWhitelist", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ReindexRemoteWhitelist
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#script_max_compilations_rate DatabaseOpensearchConfig#script_max_compilations_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scriptMaxCompilationsRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScriptMaxCompilationsRate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#search_max_buckets DatabaseOpensearchConfig#search_max_buckets}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "searchMaxBuckets", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SearchMaxBuckets
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_analyze_queue_size DatabaseOpensearchConfig#thread_pool_analyze_queue_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "threadPoolAnalyzeQueueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThreadPoolAnalyzeQueueSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_analyze_size DatabaseOpensearchConfig#thread_pool_analyze_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "threadPoolAnalyzeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThreadPoolAnalyzeSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_force_merge_size DatabaseOpensearchConfig#thread_pool_force_merge_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "threadPoolForceMergeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThreadPoolForceMergeSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_get_queue_size DatabaseOpensearchConfig#thread_pool_get_queue_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "threadPoolGetQueueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThreadPoolGetQueueSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_get_size DatabaseOpensearchConfig#thread_pool_get_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "threadPoolGetSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThreadPoolGetSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_search_queue_size DatabaseOpensearchConfig#thread_pool_search_queue_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "threadPoolSearchQueueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThreadPoolSearchQueueSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_search_size DatabaseOpensearchConfig#thread_pool_search_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "threadPoolSearchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThreadPoolSearchSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_search_throttled_queue_size DatabaseOpensearchConfig#thread_pool_search_throttled_queue_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "threadPoolSearchThrottledQueueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThreadPoolSearchThrottledQueueSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_search_throttled_size DatabaseOpensearchConfig#thread_pool_search_throttled_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "threadPoolSearchThrottledSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThreadPoolSearchThrottledSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_write_queue_size DatabaseOpensearchConfig#thread_pool_write_queue_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "threadPoolWriteQueueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThreadPoolWriteQueueSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_write_size DatabaseOpensearchConfig#thread_pool_write_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "threadPoolWriteSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThreadPoolWriteSize
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
