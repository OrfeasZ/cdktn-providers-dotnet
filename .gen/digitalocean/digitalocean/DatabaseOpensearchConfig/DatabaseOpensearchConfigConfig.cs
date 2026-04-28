using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseOpensearchConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.databaseOpensearchConfig.DatabaseOpensearchConfigConfig")]
    public class DatabaseOpensearchConfigConfig : digitalocean.DatabaseOpensearchConfig.IDatabaseOpensearchConfigConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#cluster_id DatabaseOpensearchConfig#cluster_id}.</summary>
        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterId
        {
            get;
            set;
        }

        private object? _actionAutoCreateIndexEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#action_auto_create_index_enabled DatabaseOpensearchConfig#action_auto_create_index_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actionAutoCreateIndexEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ActionAutoCreateIndexEnabled
        {
            get => _actionAutoCreateIndexEnabled;
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
                _actionAutoCreateIndexEnabled = value;
            }
        }

        private object? _actionDestructiveRequiresName;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#action_destructive_requires_name DatabaseOpensearchConfig#action_destructive_requires_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actionDestructiveRequiresName", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ActionDestructiveRequiresName
        {
            get => _actionDestructiveRequiresName;
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
                _actionDestructiveRequiresName = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#cluster_max_shards_per_node DatabaseOpensearchConfig#cluster_max_shards_per_node}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterMaxShardsPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ClusterMaxShardsPerNode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#cluster_routing_allocation_node_concurrent_recoveries DatabaseOpensearchConfig#cluster_routing_allocation_node_concurrent_recoveries}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterRoutingAllocationNodeConcurrentRecoveries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ClusterRoutingAllocationNodeConcurrentRecoveries
        {
            get;
            set;
        }

        private object? _enableSecurityAudit;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#enable_security_audit DatabaseOpensearchConfig#enable_security_audit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableSecurityAudit", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableSecurityAudit
        {
            get => _enableSecurityAudit;
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
                _enableSecurityAudit = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#http_max_content_length_bytes DatabaseOpensearchConfig#http_max_content_length_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpMaxContentLengthBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HttpMaxContentLengthBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#http_max_header_size_bytes DatabaseOpensearchConfig#http_max_header_size_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpMaxHeaderSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HttpMaxHeaderSizeBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#http_max_initial_line_length_bytes DatabaseOpensearchConfig#http_max_initial_line_length_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpMaxInitialLineLengthBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HttpMaxInitialLineLengthBytes
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_fielddata_cache_size_percentage DatabaseOpensearchConfig#indices_fielddata_cache_size_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "indicesFielddataCacheSizePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IndicesFielddataCacheSizePercentage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_memory_index_buffer_size_percentage DatabaseOpensearchConfig#indices_memory_index_buffer_size_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "indicesMemoryIndexBufferSizePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IndicesMemoryIndexBufferSizePercentage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_memory_max_index_buffer_size_mb DatabaseOpensearchConfig#indices_memory_max_index_buffer_size_mb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "indicesMemoryMaxIndexBufferSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IndicesMemoryMaxIndexBufferSizeMb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_memory_min_index_buffer_size_mb DatabaseOpensearchConfig#indices_memory_min_index_buffer_size_mb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "indicesMemoryMinIndexBufferSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IndicesMemoryMinIndexBufferSizeMb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_queries_cache_size_percentage DatabaseOpensearchConfig#indices_queries_cache_size_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "indicesQueriesCacheSizePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IndicesQueriesCacheSizePercentage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_query_bool_max_clause_count DatabaseOpensearchConfig#indices_query_bool_max_clause_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "indicesQueryBoolMaxClauseCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IndicesQueryBoolMaxClauseCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_recovery_max_concurrent_file_chunks DatabaseOpensearchConfig#indices_recovery_max_concurrent_file_chunks}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "indicesRecoveryMaxConcurrentFileChunks", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IndicesRecoveryMaxConcurrentFileChunks
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#indices_recovery_max_mb_per_sec DatabaseOpensearchConfig#indices_recovery_max_mb_per_sec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "indicesRecoveryMaxMbPerSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IndicesRecoveryMaxMbPerSec
        {
            get;
            set;
        }

        private object? _ismEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#ism_enabled DatabaseOpensearchConfig#ism_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ismEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsmEnabled
        {
            get => _ismEnabled;
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
                _ismEnabled = value;
            }
        }

        private object? _ismHistoryEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#ism_history_enabled DatabaseOpensearchConfig#ism_history_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ismHistoryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsmHistoryEnabled
        {
            get => _ismHistoryEnabled;
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
                _ismHistoryEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#ism_history_max_age_hours DatabaseOpensearchConfig#ism_history_max_age_hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ismHistoryMaxAgeHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IsmHistoryMaxAgeHours
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#ism_history_max_docs DatabaseOpensearchConfig#ism_history_max_docs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ismHistoryMaxDocs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IsmHistoryMaxDocs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#ism_history_rollover_check_period_hours DatabaseOpensearchConfig#ism_history_rollover_check_period_hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ismHistoryRolloverCheckPeriodHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IsmHistoryRolloverCheckPeriodHours
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#ism_history_rollover_retention_period_days DatabaseOpensearchConfig#ism_history_rollover_retention_period_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ismHistoryRolloverRetentionPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IsmHistoryRolloverRetentionPeriodDays
        {
            get;
            set;
        }

        private object? _overrideMainResponseVersion;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#override_main_response_version DatabaseOpensearchConfig#override_main_response_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "overrideMainResponseVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? OverrideMainResponseVersion
        {
            get => _overrideMainResponseVersion;
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
                _overrideMainResponseVersion = value;
            }
        }

        private object? _pluginsAlertingFilterByBackendRolesEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#plugins_alerting_filter_by_backend_roles_enabled DatabaseOpensearchConfig#plugins_alerting_filter_by_backend_roles_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pluginsAlertingFilterByBackendRolesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PluginsAlertingFilterByBackendRolesEnabled
        {
            get => _pluginsAlertingFilterByBackendRolesEnabled;
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
                _pluginsAlertingFilterByBackendRolesEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#reindex_remote_whitelist DatabaseOpensearchConfig#reindex_remote_whitelist}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reindexRemoteWhitelist", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ReindexRemoteWhitelist
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#script_max_compilations_rate DatabaseOpensearchConfig#script_max_compilations_rate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scriptMaxCompilationsRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScriptMaxCompilationsRate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#search_max_buckets DatabaseOpensearchConfig#search_max_buckets}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "searchMaxBuckets", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SearchMaxBuckets
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_analyze_queue_size DatabaseOpensearchConfig#thread_pool_analyze_queue_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadPoolAnalyzeQueueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadPoolAnalyzeQueueSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_analyze_size DatabaseOpensearchConfig#thread_pool_analyze_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadPoolAnalyzeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadPoolAnalyzeSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_force_merge_size DatabaseOpensearchConfig#thread_pool_force_merge_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadPoolForceMergeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadPoolForceMergeSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_get_queue_size DatabaseOpensearchConfig#thread_pool_get_queue_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadPoolGetQueueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadPoolGetQueueSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_get_size DatabaseOpensearchConfig#thread_pool_get_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadPoolGetSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadPoolGetSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_search_queue_size DatabaseOpensearchConfig#thread_pool_search_queue_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadPoolSearchQueueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadPoolSearchQueueSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_search_size DatabaseOpensearchConfig#thread_pool_search_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadPoolSearchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadPoolSearchSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_search_throttled_queue_size DatabaseOpensearchConfig#thread_pool_search_throttled_queue_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadPoolSearchThrottledQueueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadPoolSearchThrottledQueueSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_search_throttled_size DatabaseOpensearchConfig#thread_pool_search_throttled_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadPoolSearchThrottledSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadPoolSearchThrottledSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_write_queue_size DatabaseOpensearchConfig#thread_pool_write_queue_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadPoolWriteQueueSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadPoolWriteQueueSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_opensearch_config#thread_pool_write_size DatabaseOpensearchConfig#thread_pool_write_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadPoolWriteSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadPoolWriteSize
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
